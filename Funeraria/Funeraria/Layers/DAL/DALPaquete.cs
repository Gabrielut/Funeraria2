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
    class DALPaquete : IDALPaquete
    {
        Usuarios _Usuario = new Usuarios();
        public DALPaquete()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public bool DaletePaquete(int pId)
        {
            double rows = 0;
            string sql = @"DELETE FROM Paquete
                            WHERE IdPaquete = @filtro";
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

        public List<Paquete> GetAllPaquete()
        {
            DataSet ds = null;
            List<Paquete> lista = new List<Paquete>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Paquete";

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
                        Paquete oPaquete = new Paquete();
                        oPaquete.IdPaquete = int.Parse(dr["IdPaquete"].ToString());
                        oPaquete.Nombre = dr["Nombre"].ToString();
                        oPaquete.Descripcion = dr["Descripcion"].ToString();
                        oPaquete.Precio = (float.Parse(dr["Precio"].ToString()));
                        oPaquete.Cantidad = (int.Parse(dr["Cantidad"].ToString()));
                        oPaquete.IdTipoPaquete = (int.Parse(dr["IdTipoPaquete"].ToString()));
                        oPaquete.Estado = (bool)dr["Estado"];
                        lista.Add(oPaquete);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }

        public int GetNextNumeroActivo()
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroActivo;
            string sql = @"SELECT NEXT VALUE FOR SequenceNoPaquete";

            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroActivo = int.Parse(dt.Rows[0][0].ToString());
                return numeroActivo;
            }
            catch (Exception er)
            {

                throw;
            }
        }

        public List<Paquete> GetPaqueteByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public Paquete GetPaqueteById(int pPaquete)
        {
            DataSet ds = null;
            Paquete oPaquete = null;
            string sql = @"select * from Paquete where IdPaquete = @filtro";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", pPaquete);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow dr = ds.Tables[0].Rows[0];
                    oPaquete = new Paquete()
                    {
                        IdPaquete = int.Parse(dr["IdPaquete"].ToString()),
                        Nombre = (dr["Nombre"].ToString()),
                        Descripcion = dr["Descripcion"].ToString(),
                        Precio = float.Parse(dr["Precio"].ToString()),
                        Cantidad = int.Parse(dr["Cantidad"].ToString()),
                        IdTipoPaquete = int.Parse(dr["IdTipoPaquete"].ToString()),
                        Estado = (bool)(dr["Estado"])

                    };


                }

                return oPaquete;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public Paquete SavePaquete(Paquete pPaquete)
        {
            Paquete oPaquete = null;
            double rows = 0;
            string sql = @"INSERT INTO Paquete
           ([Nombre]
           ,[Descripcion]
           ,[Precio]
           ,[Cantidad]
           ,[IdTipoPaquete]
           ,[Estado])
     VALUES
           (@Nombre, 
           @Descripcion,
           @Precio,
           @Cantidad,
           @IdTipoPaquete,
           @Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Nombre", pPaquete.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", pPaquete.Descripcion);
            cmd.Parameters.AddWithValue("@Precio", pPaquete.Precio);
            cmd.Parameters.AddWithValue("@Cantidad", pPaquete.Cantidad);
            cmd.Parameters.AddWithValue("@IdTipoPaquete", pPaquete.IdTipoPaquete);
            cmd.Parameters.AddWithValue("@Estado", pPaquete.Estado);

            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }

            if (rows > 0)
            {
                oPaquete = GetPaqueteById(pPaquete.IdPaquete);
            }
            return pPaquete;
        }

        public Paquete UpdatePaquete(Paquete pPaquete)
        {
            Paquete oPaquete = null;
            string sql = @"UPDATE Paquete
                             SET [Nombre] = @Nombre
                            ,[Descripcion] = @Descripcion
                            ,[Precio] = @Precio
                            ,[Cantidad] = @Cantidad
                            ,[IdTipoPaquete] = @IdTipoPaquete
                            ,[Estado] = @Estado
                            WHERE IdPaquete = @IdPaquete";
            SqlCommand command = new SqlCommand();
            double rows = 0;
            try
            {
                command.Parameters.AddWithValue("@Nombre", pPaquete.Nombre);
                command.Parameters.AddWithValue("@Descripcion", pPaquete.Descripcion);
                command.Parameters.AddWithValue("@Precio", pPaquete.Precio);
                command.Parameters.AddWithValue("@Cantidad", pPaquete.Cantidad);
                command.Parameters.AddWithValue("@IdTipoPaquete", pPaquete.IdTipoPaquete);
                command.Parameters.AddWithValue("@Estado", pPaquete.Estado);
                command.Parameters.AddWithValue("@IdPaquete", pPaquete.IdPaquete);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oPaquete = GetPaqueteById(pPaquete.IdPaquete);

                return oPaquete;
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }
}
