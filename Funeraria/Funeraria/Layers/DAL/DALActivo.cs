using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.Layers.DAL
{
    class DALActivo : IDALActivo
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        Usuarios _Usuario = new Usuarios();
        public DALActivo()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public bool DaleteActivo(int pId)
        {
            double rows = 0;
            string sql = @"DELETE FROM Activo
                           WHERE IdActivo = @filtro";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@filtro", pId);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<ActivoDTO> GetActivoByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<ActivoDTO> lista = new List<ActivoDTO>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT Activo.IdActivo, Activo.Nombre, Activo.Descripcion, Activo.Cantidad, 
                               Activo.Costo, Activo.Precio, Activo.InformacionAdicional, Activo.Estado, 
                               TipoActivo.Descripcion AS TipoActivo FROM Activo INNER JOIN
                               TipoActivo ON Activo.TipoActivo = TipoActivo.IdTipoActivo
						       where Activo.Nombre+Activo.Descripcion+TipoActivo.Descripcion like @filtro ";

                command.Parameters.AddWithValue("@filtro", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                // esto se hace cuando se utiliza un store procedure en la base de datos
                // command.CommandText = "usp_SELECT_Cliente_All";
                // command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ActivoDTO oActivo = new ActivoDTO();
                        oActivo.IdActivo = int.Parse(dr["IdActivo"].ToString());
                        oActivo.Nombre = dr["Nombre"].ToString();
                        oActivo.Descripcion = dr["Descripcion"].ToString();
                        oActivo.TipoActivo = dr["TipoActivo"].ToString();
                        oActivo.Cantidad = int.Parse(dr["Cantidad"].ToString());
                        oActivo.Costo = (dr["Costo"].ToString());
                        oActivo.Precio = (dr["Precio"].ToString());
                        oActivo.InformacionAdicional = dr["InformacionAdicional"].ToString();
                        oActivo.Estado = (dr["Estado"].ToString());                       
                        lista.Add(oActivo);
                    }
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                msg.AppendFormat("SQL            {0}\n", command.CommandText);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            return lista;
        }
        public Activo GetActivoById(int pActivo)
        {
            DataSet ds = null;
            Activo oActivo = null;
            string sql = @" select * from Activo Where IdActivo = @filtro";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", pActivo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
  
                    DataRow dr = ds.Tables[0].Rows[0];
                    oActivo = new Activo()
                    {
                        IdActivo = int.Parse(dr["IdActivo"].ToString()),
                        Nombre = (dr["Nombre"].ToString()),
                        Descripcion = dr["Descripcion"].ToString(),
                        TipoActivo = (int)dr["TipoActivo"],
                        Cantidad = int.Parse(dr["Cantidad"].ToString()),
                        Costo = float.Parse(dr["Costo"].ToString()),
                        Precio = float.Parse(dr["Precio"].ToString()),
                        InformacionAdicional = dr["InformacionAdicional"].ToString(),
                        Img = (byte[])dr["Img"],
                        Estado = (bool)dr["Estado"],
                    };


                }

                return oActivo;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                msg.AppendFormat("SQL            {0}\n", command.CommandText);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }
        public List<Activo> GetAllActivos()
        {
            DataSet ds = null;
            List<Activo> lista = new List<Activo>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Activo";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                // esto se hace cuando se utiliza un store procedure en la base de datos
                // command.CommandText = "usp_SELECT_Cliente_All";
                // command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Activo oActivo = new Activo();
                        oActivo.IdActivo = int.Parse(dr["IdActivo"].ToString());
                        oActivo.Nombre = dr["Nombre"].ToString();
                        oActivo.Descripcion = dr["Descripcion"].ToString();
                        oActivo.TipoActivo = int.Parse(dr["TipoActivo"].ToString());
                        oActivo.Cantidad = int.Parse(dr["Cantidad"].ToString());
                        oActivo.Costo = float.Parse(dr["Costo"].ToString());
                        oActivo.Precio = float.Parse(dr["Precio"].ToString());
                        oActivo.InformacionAdicional = dr["InformacionAdicional"].ToString();
                        oActivo.Estado = bool.Parse(dr["Estado"].ToString());
                        oActivo.Img = (byte[])dr["Img"];
                        lista.Add(oActivo);
                    }
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                msg.AppendFormat("SQL            {0}\n", command.CommandText);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            return lista;
        }
        public int GetNextNumeroActivo()
        {
            //DataSet ds = null;
            //IDbCommand command = new SqlCommand();
            //int numeroActivo;
            //string sql = @"SELECT NEXT VALUE FOR SequenceNoActivo";

            //DataTable dt = null;
            //try
            //{
            //    command.CommandText = sql;
            //    command.CommandType = CommandType.Text;

            //    using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            //    {

            //        ds = db.ExecuteReader(command, "query");
            //    }

            //     Extraer la tabla 
            //    dt = ds.Tables[0];
            //    Extraer el valor que viene en el DataTable 
            //    if ((dt.Rows[0][0].ToString()) == "")
            //    {
            //        numeroActivo = 1;
            //        return numeroActivo;
            //    }
            //    numeroActivo = int.Parse(dt.Rows[0][0].ToString());
            //    return numeroActivo;
            //}
            //catch (Exception er)
            //{

            //    throw;
            //}
            throw new NotImplementedException();
        }
        public Activo SaveActivo(Activo pActivo)
        {
            Activo oActivo = null;
            double rows = 0;
            string sql = @"INSERT INTO Activo
           ([IdActivo]
           ,[Nombre]
           ,[Descripcion]
           ,[TipoActivo]
           ,[Cantidad]
           ,[Costo]
           ,[Precio]
           ,[InformacionAdicional]
           ,[Img]
           ,[Estado])
     VALUES
           (@IdActivo
           ,@Nombre
           ,@Descripcion
           ,@TipoActivo 
           ,@Cantidad 
           ,@Costo
           ,@Precio
           ,@InformacionAdicional 
           ,@Img
           ,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdActivo", pActivo.IdActivo);
            cmd.Parameters.AddWithValue("@Nombre", pActivo.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", pActivo.Descripcion);
            cmd.Parameters.AddWithValue("@TipoActivo", pActivo.TipoActivo);
            cmd.Parameters.AddWithValue("@Cantidad", pActivo.Cantidad);
            cmd.Parameters.AddWithValue("@Costo", pActivo.Costo);
            cmd.Parameters.AddWithValue("@Precio", pActivo.Precio);
            cmd.Parameters.AddWithValue("@InformacionAdicional", pActivo.InformacionAdicional);
            cmd.Parameters.AddWithValue("@Img", pActivo.Img.ToArray());
            cmd.Parameters.AddWithValue("@Estado", pActivo.Estado);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }

            if (rows > 0)
            {
                oActivo = GetActivoById(pActivo.IdActivo);
            }
            return oActivo;
        }
        public Activo UpdateActivo(Activo pActivo)
        {
            Activo oActivo = null;
            string sql = @" UPDATE Activo
                        SET
                        [Nombre] = @Nombre
                         ,[Descripcion] = @Descripcion
                         ,[TipoActivo] = @TipoActivo
                         ,[Cantidad] = @Cantidad
                         ,[Costo] = @Costo
                         ,[Precio] = @Precio
                         ,[InformacionAdicional] = @InformacionAdicional
                         ,[Img] = @Img
                         ,[Estado] = @Estado
                        WHERE IdActivo = @IdActivo";

        SqlCommand command = new SqlCommand();
        double rows = 0;

            try
            {

                // Pasar parámetros
                command.Parameters.AddWithValue("@Nombre", pActivo.Nombre);
                command.Parameters.AddWithValue("@Descripcion", pActivo.Descripcion);
                command.Parameters.AddWithValue("@TipoActivo", pActivo.TipoActivo);
                command.Parameters.AddWithValue("@Cantidad", pActivo.Cantidad);
                command.Parameters.AddWithValue("@Costo", pActivo.Costo);
                command.Parameters.AddWithValue("@Precio", pActivo.Precio);
                command.Parameters.AddWithValue("@InformacionAdicional", pActivo.InformacionAdicional);
                command.Parameters.AddWithValue("@Img", pActivo.Img);
                command.Parameters.AddWithValue("@Estado", pActivo.Estado);
                command.Parameters.AddWithValue("@IdActivo", pActivo.IdActivo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oActivo = GetActivoById(pActivo.IdActivo);

                return oActivo;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                msg.AppendFormat("SQL            {0}\n", command.CommandText);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }
    }
}
