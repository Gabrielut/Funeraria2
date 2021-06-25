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
    class DALCliente : IDALCliente
    {
        Usuarios _Usuario = new Usuarios();

        public DALCliente()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }

        public Cliente SaveCliente(Cliente pCliente)
        {
            Cliente oCliente = null;
            double rows = 0;
            string sql = @"INSERT INTO [dbo].[Cliente]
           ([IdCliente]
           ,[Nombre]
           ,[PrimerApellido]
           ,[SegundoApellido]
           ,[Correo]
           ,[Telefono]
           ,[Sexo]
           ,[Direccion])
     VALUES
           (@IdCliente
           ,@Nombre
           ,@PrimerApellido
           ,@SegundoApellido
           ,@Correo
           ,@Telefono
           ,@Sexo
           ,@Direccion)";

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.AddWithValue("@IdCliente", pCliente.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", pCliente.PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", pCliente.SegundoApellido);
                cmd.Parameters.AddWithValue("@Correo", pCliente.Correo);
                cmd.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                cmd.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                cmd.Parameters.AddWithValue("@Direccion", pCliente.Direccion);

                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    rows = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                {
                    oCliente = GetClienteById(pCliente.IdCliente);
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
                msg.AppendFormat("SQL            {0}\n", cmd.CommandText);
                
                throw;
            }
            
                      
            return oCliente;
        }

        public Cliente GetClienteById(int pCliente)
        {
            DataSet ds = null;
            Cliente oCliente = null;
            string sql = @" SELECT * FROM [Cliente] WHERE (IdCliente = @IdCliente)";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@IdCliente", pCliente);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow dr = ds.Tables[0].Rows[0];
                    oCliente = new Cliente()
                    {
                        IdCliente = int.Parse(dr["IdCliente"].ToString()),
                        Nombre = (dr["Nombre"].ToString()),
                        PrimerApellido = dr["PrimerApellido"].ToString(),
                        SegundoApellido = dr["SegundoApellido"].ToString(),
                        Sexo = (bool)dr["Sexo"],
                        Correo = dr["Correo"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Direccion = dr["Direccion"].ToString(),

                    };


                }

                return oCliente;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public bool DeleteCliente(int pId)
        {
            double rows = 0;
            string sql = @"DELETE FROM Cliente
                           WHERE IdCliente = @idCliente";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idCliente", pId);
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

        public List<Cliente> GetAllClientes()
        {
            DataSet ds = null;
            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Cliente";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Cliente oCliente = new Cliente();
                        oCliente.IdCliente = (int)dr["IdCliente"];
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.PrimerApellido = dr["PrimerApellido"].ToString();
                        oCliente.SegundoApellido = dr["SegundoApellido"].ToString();
                        oCliente.Correo = dr["Correo"].ToString();
                        oCliente.Telefono = dr["Telefono"].ToString();
                        oCliente.Sexo = (bool)dr["Sexo"];
                        oCliente.Direccion = dr["Direccion"].ToString();            
                        lista.Add(oCliente);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }

        public Cliente UpdateCliente(Cliente pCliente)
        {
            Cliente oCliente = null;
            string sql = @" UPDATE Cliente
                        SET
                        [IdCliente] = @IdCliente
                        ,[Nombre] = @Nombre
                         ,[PrimerApellido] = @PrimerApellido
                         ,[SegundoApellido] = @SegundoApellido
                         ,[Correo] = @Correo
                         ,[Telefono] = @Telefono
                         ,[Sexo] = @Sexo
                         ,[Direccion] = @Direccion
                        WHERE IdCliente = @IdCliente";

            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                // Pasar parámetros
                command.Parameters.AddWithValue("@IdCliente", pCliente.IdCliente);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@PrimerApellido", pCliente.PrimerApellido);
                command.Parameters.AddWithValue("@SegundoApellido", pCliente.SegundoApellido);
                command.Parameters.AddWithValue("@Correo", pCliente.Correo);
                command.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oCliente = GetClienteById(pCliente.IdCliente);

                return oCliente;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public List<Cliente> GetAllCliente()
        {
            DataSet ds = null;
            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Cliente  WITH (NOLOCK)  ";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Cliente oCliente = new Cliente();
                        oCliente.IdCliente = (int)dr["IdCliente"];
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.PrimerApellido = dr["PrimerApellido"].ToString();
                        oCliente.SegundoApellido = dr["SegundoApellido"].ToString();
                        oCliente.Correo = dr["Correo"].ToString();
                        oCliente.Telefono = dr["Telefono"].ToString();
                        oCliente.Sexo = (bool)dr["Sexo"];
                        oCliente.Direccion = dr["Direccion"].ToString();
                        lista.Add(oCliente);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }

        public List<Cliente> GetClienteByFilter(string pCorreo)
        {
            throw new NotImplementedException();
        }

        public int GetNextNumeroCliente()
        {
            throw new NotImplementedException();
        }
    }
}
