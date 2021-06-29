using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.Layers.DAL
{
    class DALRol : IDALRol
    {
        Usuarios _Usuario = new Usuarios();
        public DALRol()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<Rol> GetAllRol()
        {
            IDataReader reader = null;
            List<Rol> lista = new List<Rol>();
            SqlCommand command = new SqlCommand();

            string sql = @" select * from  Rol WITH (NOLOCK) where estado = 1 ";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {

                        Rol oRol = new Rol();
                        oRol.IDRol = int.Parse(reader["IDRol"].ToString());
                        oRol.Descripcion = reader["Descripcion"].ToString();
                        lista.Add(oRol);
                    }
                }


                return lista;
            }
            catch (Exception er)
            {

            }
            return lista;
        }

        public Rol GetRolById(int pId)
        {
            DataSet ds = null;
            Rol oRol = null;
            string sql = @"select * from Rol where IDRol = @filtro";
            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    oRol = new Rol()
                    {
                        IDRol = int.Parse(dr["IDRol"].ToString()),
                        Descripcion = (dr["Descripcion"].ToString()),
                        Estado = (bool)dr["Estado"],
                    };
                }
                return oRol;
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }
}
