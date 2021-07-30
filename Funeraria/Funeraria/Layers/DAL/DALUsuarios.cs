using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.Layers.DAL
{
    public class DALUsuarios : IDALUsuarios
    {
        Usuarios _Usuario = new Usuarios();
        public DALUsuarios()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }

        public bool DeleteUsuarios(string pId)
        {
            double rows = 0;
            string sql = @"Delete from  Usuarios 
                           Where (@IdUsuario = IdUsuario) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdUsuario", pId);
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

        public List<Usuarios> GetAllUsuarios()
        {
            DataSet ds = null;
            List<Usuarios> lista = new List<Usuarios>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Usuarios WITH (NOLOCK)";

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
                        Usuarios oUsarios = new Usuarios();
                        oUsarios.IDUsuario = dr["IDUsuario"].ToString();
                        oUsarios.Nombre = dr["Nombre"].ToString();
                        oUsarios.PrimerApellido = dr["PrimerApellido"].ToString();
                        oUsarios.SegundoApellido = dr["SegundoApellido"].ToString();
                        oUsarios.Correo = dr["Correo"].ToString();
                        oUsarios.Telefono = dr["Telefono"].ToString();
                        oUsarios.IdRol = (int)dr["IDRol"];
                        oUsarios.Contrasenna = dr["Contrasenna"].ToString();
                        oUsarios.Estado = (bool)dr["Estado"];
                        oUsarios.Sexo = (int)dr["Sexo"];
                        oUsarios.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oUsarios.Direccion = dr["Direccion"].ToString();
                        oUsarios.Token = dr["Token"].ToString();
                        lista.Add(oUsarios);
                    }
                } 
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }

        public Usuarios GetUsuariosByCorreo(string pCorreo)
        {
            DataSet ds = null;
            Usuarios oUsuarios = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from Usuarios where Correo =  @Correo";
                command.Parameters.AddWithValue("@Correo", pCorreo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                //command.CommandText = "usp_SELECT_Cliente_ByID";
                //command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oUsuarios = new Usuarios();
                        oUsuarios.IDUsuario = dr["IDUsuario"].ToString();
                        oUsuarios.Nombre = dr["Nombre"].ToString();
                        oUsuarios.PrimerApellido = dr["PrimerApellido"].ToString();
                        oUsuarios.SegundoApellido = dr["SegundoApellido"].ToString();
                        oUsuarios.Correo = dr["Correo"].ToString();
                        oUsuarios.Telefono = dr["Telefono"].ToString();
                        oUsuarios.Direccion = dr["Direccion"].ToString();
                        oUsuarios.IdRol = (int)dr["IDRol"];
                        oUsuarios.Contrasenna = dr["Contrasenna"].ToString();
                        oUsuarios.Estado = (bool)dr["Estado"];
                        oUsuarios.Sexo = (int)dr["Sexo"];
                        oUsuarios.Token = dr["Token"].ToString();
                        oUsuarios.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                    }
                }
            }
            catch (Exception er)
            {

            }
            return oUsuarios;
        }

        public List<Usuarios> GetUsuariosByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Usuarios> lista = new List<Usuarios>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Usuarios WITH (NOLOCK) Where Nombre+PrimerApellido+SegundoApellido like '%'+ @filtro + '%'";
                command.Parameters.AddWithValue("@filtro", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Usuarios oUsarios = new Usuarios();
                        oUsarios.IDUsuario = dr["IDUsuario"].ToString();
                        oUsarios.Nombre = dr["Nombre"].ToString();
                        oUsarios.PrimerApellido = dr["PrimerApellido"].ToString();
                        oUsarios.SegundoApellido = dr["SegundoApellido"].ToString();
                        oUsarios.Correo = dr["Correo"].ToString();
                        oUsarios.Telefono = dr["Telefono"].ToString();
                        oUsarios.IdRol = (int)dr["IDRol"];
                        oUsarios.Contrasenna = dr["Contrasenna"].ToString();
                        oUsarios.Estado = (bool)dr["Estado"];
                        oUsarios.Sexo = (int)dr["Sexo"];
                        oUsarios.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());

                        lista.Add(oUsarios);
                    }
                }

                return lista;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public Usuarios GetUsuariosById(string pId)
        {
            DataSet ds = null;
            Usuarios oUsuarios = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Usuarios Where IDUsuario = @IDUsuario ";
                command.Parameters.AddWithValue("@IDUsuario", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                //command.CommandText = "usp_SELECT_Cliente_ByID";
                //command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oUsuarios = new Usuarios();
                        oUsuarios.IDUsuario = dr["IDUsuario"].ToString();
                        oUsuarios.Nombre = dr["Nombre"].ToString();
                        oUsuarios.PrimerApellido = dr["PrimerApellido"].ToString();
                        oUsuarios.SegundoApellido = dr["SegundoApellido"].ToString();
                        oUsuarios.Correo = dr["Correo"].ToString();
                        oUsuarios.Telefono = dr["Telefono"].ToString();
                        oUsuarios.IdRol = (int)dr["IDRol"];
                        oUsuarios.Contrasenna = dr["Contrasenna"].ToString();
                        oUsuarios.Estado = (bool)dr["Estado"];
                        oUsuarios.Sexo = (int)dr["Sexo"];
                        oUsuarios.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                    }
                }
            }
            catch (Exception er)
            {

            }
            return oUsuarios;
        }

        public Usuarios LoginUsuarios(string pCorreo)
        {
            DataSet ds = null;
            Usuarios oUsuarios = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Usuarios Where Correo = @Correo ";
                command.Parameters.AddWithValue("@Correo", pCorreo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                //command.CommandText = "usp_SELECT_Cliente_ByID";
                //command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oUsuarios = new Usuarios();
                        oUsuarios.IDUsuario = dr["IDUsuario"].ToString();
                        oUsuarios.Nombre = dr["Nombre"].ToString();
                        oUsuarios.PrimerApellido = dr["PrimerApellido"].ToString();
                        oUsuarios.SegundoApellido = dr["SegundoApellido"].ToString();
                        oUsuarios.Correo = dr["Correo"].ToString();
                        oUsuarios.Telefono = dr["Telefono"].ToString();
                        oUsuarios.IdRol = (int)dr["IDRol"];
                        oUsuarios.Contrasenna = dr["Contrasenna"].ToString();
                        oUsuarios.Estado = (bool)dr["Estado"];
                        oUsuarios.Sexo = (int)dr["Sexo"];
                        oUsuarios.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                    }
                }
            }
            catch (Exception er)
            {

            }
            return oUsuarios;
        }

        public Usuarios SaveUsuarios(Usuarios pUsuarios)
        {
            Usuarios oUsuarios = null;
            double rows = 0;
            // Insert
            string sql = @"Insert into Usuarios
(IDUsuario,Nombre,PrimerApellido,SegundoApellido,Correo,Contrasenna,Telefono,IDRol,Sexo,FechaNacimiento,Estado,Direccion,Token) 
values (@IDUsuario,@Nombre,@PrimerApellido,@SegundoApellido,@Correo,@Contrasenna,@Telefono,@IDRol,@Sexo,@FechaNacimiento,@Estado,@Direccion,@Token)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IDUsuario", pUsuarios.IDUsuario);
            cmd.Parameters.AddWithValue("@Nombre", pUsuarios.Nombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", pUsuarios.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", pUsuarios.SegundoApellido);
            cmd.Parameters.AddWithValue("@Correo", pUsuarios.Correo);
            cmd.Parameters.AddWithValue("@Contrasenna", pUsuarios.Contrasenna);
            cmd.Parameters.AddWithValue("@Telefono", pUsuarios.Telefono);
            cmd.Parameters.AddWithValue("@IdRol", pUsuarios.IdRol);
            cmd.Parameters.AddWithValue("@Sexo", pUsuarios.Sexo);
            cmd.Parameters.AddWithValue("@FechaNacimiento", pUsuarios.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Estado", pUsuarios.Estado);
            cmd.Parameters.AddWithValue("@Direccion", pUsuarios.Direccion);
            cmd.Parameters.AddWithValue("@Token", pUsuarios.Token);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }

            //if (rows > 0)
            //{
            //    oUsuarios = GetClienteById(pCliente.IdCliente);
            //}
            return oUsuarios;
        }

        public Usuarios UpdateUsuarios(Usuarios pUsuarios)
        {
            Usuarios oUsuarios = null;
            string sql = @" 
                            UPDATE [dbo].[Usuarios]
                            SET [Correo] = @Correo
                                  ,[Contrasenna] = @Contrasenna
                                  ,[IDUsuario] = @IDUsuario
                                  ,[Nombre] = @Nombre
                                  ,[PrimerApellido] = @PrimerApellido
                                  ,[SegundoApellido] = @SegundoApellido
                                  ,[Sexo] = @Sexo
                                  ,[Telefono] = @Telefono
                                  ,[IDRol] = @IDRol
                                  ,[FechaNacimiento] = @FechaNacimiento
                                  ,[Direccion] = @Direccion
                                  ,[Estado] = @Estado
                                  ,[Token] = @Token
                             WHERE [IDUsuario] = @IDUsuario  ";

            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                // Pasar parámetros
                command.Parameters.AddWithValue("@Correo", pUsuarios.Correo);
                command.Parameters.AddWithValue("@Contrasenna", pUsuarios.Contrasenna);
                command.Parameters.AddWithValue("@IDUsuario", pUsuarios.IDUsuario);
                command.Parameters.AddWithValue("@Nombre", pUsuarios.Nombre);
                command.Parameters.AddWithValue("@PrimerApellido", pUsuarios.PrimerApellido);
                command.Parameters.AddWithValue("@SegundoApellido", pUsuarios.SegundoApellido);
                command.Parameters.AddWithValue("@Sexo", pUsuarios.Sexo);
                command.Parameters.AddWithValue("@Telefono", pUsuarios.Telefono);
                command.Parameters.AddWithValue("@IDRol", pUsuarios.IdRol);
                command.Parameters.AddWithValue("@FechaNacimiento", pUsuarios.FechaNacimiento);
                command.Parameters.AddWithValue("@Direccion", pUsuarios.Direccion);
                command.Parameters.AddWithValue("@Estado", pUsuarios.Estado);
                command.Parameters.AddWithValue("@Token", pUsuarios.Token);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oUsuarios = GetUsuariosById(pUsuarios.IDUsuario);

                return oUsuarios;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public Usuarios updatePassword(Usuarios pUsuarios)
        {
            Usuarios oUsuarios = null;
            string sql = @" 
                          UPDATE [dbo].[Usuarios]
                          SET Contrasenna = @password
                          WHERE Correo = @filtro";

            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                command.Parameters.AddWithValue("@password", pUsuarios.Correo);
                command.Parameters.AddWithValue("@filtro", pUsuarios.Contrasenna);
                
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oUsuarios = GetUsuariosById(pUsuarios.IDUsuario);

                return oUsuarios;
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }

}


