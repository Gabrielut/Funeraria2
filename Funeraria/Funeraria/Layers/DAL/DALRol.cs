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
    }
}
