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
    class DALTipoActivo : IDALTipoActivo
    {

        Usuarios _Usuario = new Usuarios();
        public DALTipoActivo()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<TipoActivo> GetAllTipoActivo()
        {
            IDataReader reader = null;
            List<TipoActivo> lista = new List<TipoActivo>();
            SqlCommand command = new SqlCommand();

            string sql = @" select * from  TipoActivo WITH (NOLOCK)";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {

                        TipoActivo oTipoActivo = new TipoActivo();
                        oTipoActivo.IdTipoActivo = int.Parse(reader["IdTipoActivo"].ToString());
                        oTipoActivo.Descripcion = reader["Descripcion"].ToString();
                        lista.Add(oTipoActivo);
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
