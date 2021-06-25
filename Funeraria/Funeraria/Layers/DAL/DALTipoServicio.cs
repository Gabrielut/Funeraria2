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
    class DALTipoServicio : IDALTipoServicio
    {
        Usuarios _Usuario = new Usuarios();
        public DALTipoServicio()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<TipoServicio> GetAllTipoServicio()
        {
            IDataReader reader = null;
            List<TipoServicio> lista = new List<TipoServicio>();
            SqlCommand command = new SqlCommand();

            string sql = @" select * from TipoServicio WITH (NOLOCK)";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {

                        TipoServicio oTipoServicio = new TipoServicio();
                        oTipoServicio.IdTipoServicio = int.Parse(reader["IdTipoServicio"].ToString());
                        oTipoServicio.Descripcion = reader["Descripcion"].ToString();
                        lista.Add(oTipoServicio);
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

