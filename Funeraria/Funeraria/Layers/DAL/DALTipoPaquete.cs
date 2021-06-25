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
    class DALTipoPaquete : IDALTipoPaquete
    {
        Usuarios _Usuario = new Usuarios();
        public DALTipoPaquete()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }

        public List<TipoPaquete> GetAllTipoPaquete()
        {

            IDataReader reader = null;
            List<TipoPaquete> lista = new List<TipoPaquete>();
            SqlCommand command = new SqlCommand();

            string sql = @" select * from TipoPaquete WITH (NOLOCK)";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {

                        TipoPaquete oTipoPaquete = new TipoPaquete();
                        oTipoPaquete.IdTipoPaquete = int.Parse(reader["IdTipoPaquete"].ToString());
                        oTipoPaquete.Descripcion = reader["Descripcion"].ToString();
                        lista.Add(oTipoPaquete);
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
