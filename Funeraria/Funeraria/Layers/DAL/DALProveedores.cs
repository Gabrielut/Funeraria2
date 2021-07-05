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
    class DALProveedores : IDALProveedores
    {
        Usuarios _Usuario = new Usuarios();
        public DALProveedores()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public bool DaleteProveedor(int pId)
        {
            double rows = 0;
            string sql = @"DELETE FROM Proveedores
                           WHERE IdProveedor = @filtro";
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

        public List<Proveedor> GetAllProveedor()
        {
            DataSet ds = null;
            List<Proveedor> lista = new List<Proveedor>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"Select * from Proveedores";

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
                        Proveedor oProveedor = new Proveedor();
                        oProveedor.IdProveedor = int.Parse(dr["IdProveedor"].ToString());
                        oProveedor.NomProveedor = dr["NomProveedor"].ToString();
                        oProveedor.Propietario = dr["Propietario"].ToString();
                        oProveedor.TelCelular = dr["TelCelular"].ToString();
                        oProveedor.TelProveedor = (dr["TelProveedor"].ToString());
                        oProveedor.TelFax = (dr["TelFax"].ToString());
                        oProveedor.Correo = (dr["Correo"].ToString());
                        oProveedor.Precio = int.Parse(dr["Precio"].ToString());
                        oProveedor.CantUni = int.Parse(dr["CantUni"].ToString());
                        oProveedor.IdTipoServicio = int.Parse(dr["IdTipoServicio"].ToString());
                        oProveedor.Estado = (bool)(dr["Estado"]);
                       

                        lista.Add(oProveedor);
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
            //DataSet ds = null;
            //IDbCommand command = new SqlCommand();
            //int numeroActivo;
            //string sql = @"SELECT NEXT VALUE FOR SequenceNoProveedor";

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
            //    numeroActivo = int.Parse(dt.Rows[0][0].ToString());
            //    return numeroActivo;
            //}
            //catch (Exception er)
            //{

            //    throw;
            //}
            throw new NotImplementedException();
        }

        public List<Proveedor> GetProveedorByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public Proveedor GetProveedorById(int pProveedor)
        {
            DataSet ds = null;
            Proveedor oProveedor = null;
            string sql = @"select * from Proveedores where IdProveedor = @filtro";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", pProveedor);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow dr = ds.Tables[0].Rows[0];
                    oProveedor = new Proveedor()
                    {
                        IdProveedor = int.Parse(dr["IdProveedor"].ToString()),
                        NomProveedor = (dr["NomProveedor"].ToString()),
                        Propietario = dr["Propietario"].ToString(),
                        TelCelular = dr["TelCelular"].ToString(),
                        TelProveedor = (dr["TelProveedor"].ToString()),
                        TelFax = (dr["TelFax"].ToString()),
                        Correo = (dr["Correo"].ToString()),
                        Precio = (float.Parse(dr["Precio"].ToString())),
                        CantUni = int.Parse(dr["CantUni"].ToString()),
                        IdTipoServicio = int.Parse(dr["IdTipoServicio"].ToString()),
                        Estado = (bool)dr["Estado"],
                    };


                }

                return oProveedor;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public Proveedor SaveProveedor(Proveedor pProveedor)
        {
            Proveedor oProveedor = null;
            double rows = 0;
            string sql = @"INSERT INTO Proveedores
           ([IdProveedor]
           ,[NomProveedor]
           ,[Propietario]
           ,[TelCelular]
           ,[TelProveedor]
           ,[TelFax]
           ,[Correo]
           ,[Precio]
           ,[CantUni]
           ,[IdTipoServicio]
           ,[Estado])
     VALUES
           (@IdProveedor
           ,@NomProveedor
           ,@Propietario
           ,@TelCelular
           ,@TelProveedor
           ,@TelFax
           ,@Correo
           ,@Precio
           ,@CantUni
           ,@IdTipoServicio
           ,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProveedor", pProveedor.IdProveedor);
            cmd.Parameters.AddWithValue("@NomProveedor", pProveedor.NomProveedor);
            cmd.Parameters.AddWithValue("@Propietario", pProveedor.Propietario);
            cmd.Parameters.AddWithValue("@TelCelular", pProveedor.TelCelular);
            cmd.Parameters.AddWithValue("@TelProveedor", pProveedor.TelProveedor);
            cmd.Parameters.AddWithValue("@TelFax", pProveedor.TelFax);
            cmd.Parameters.AddWithValue("@Correo", pProveedor.Correo);
            cmd.Parameters.AddWithValue("@Precio", pProveedor.Precio);
            cmd.Parameters.AddWithValue("@CantUni", pProveedor.CantUni);
            cmd.Parameters.AddWithValue("@IdTipoServicio", pProveedor.IdTipoServicio);
            cmd.Parameters.AddWithValue("@Estado", pProveedor.Estado);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }

            if (rows > 0)
            {
                oProveedor = GetProveedorById(pProveedor.IdProveedor);
            }
            return pProveedor;
        }

        public Proveedor UpdateProveedor(Proveedor pProveedor)
        {
            Proveedor oProveedor = null;
            string sql = @"UPDATE Proveedores
                            SET 
                             [NomProveedor] = @NomProveedor
                            ,[Propietario] = @Propietario
                            ,[TelCelular] = @TelCelular
                            ,[TelProveedor] = @TelProveedor
                            ,[TelFax] = @TelFax
                            ,[Correo] = @Correo
                            ,[Precio] = @Precio
                            ,[CantUni] = @CantUni
                            ,[IdTipoServicio] = @IdTipoServicio
                            ,[Estado] = @Estado
                            WHERE 
                            IdProveedor = @IdProveedor";
            SqlCommand command = new SqlCommand();
            double rows = 0;
            try
            {
                command.Parameters.AddWithValue("@IdProveedor", pProveedor.IdProveedor);
                command.Parameters.AddWithValue("@NomProveedor", pProveedor.NomProveedor);
                command.Parameters.AddWithValue("@Propietario", pProveedor.Propietario);
                command.Parameters.AddWithValue("@TelCelular", pProveedor.TelCelular);
                command.Parameters.AddWithValue("@TelProveedor", pProveedor.TelProveedor);
                command.Parameters.AddWithValue("@TelFax", pProveedor.TelFax);
                command.Parameters.AddWithValue("@Correo", pProveedor.Correo);
                command.Parameters.AddWithValue("@Precio", pProveedor.Precio);
                command.Parameters.AddWithValue("@CantUni", pProveedor.CantUni);
                command.Parameters.AddWithValue("@IdTipoServicio", pProveedor.IdTipoServicio);
                command.Parameters.AddWithValue("@Estado", pProveedor.Estado);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oProveedor = GetProveedorById(pProveedor.IdProveedor);

                return oProveedor;
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }
}
