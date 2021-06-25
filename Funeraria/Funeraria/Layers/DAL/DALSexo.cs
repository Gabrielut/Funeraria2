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
    class DALSexo : IDALSexo
    {


        Usuarios _Usuario = new Usuarios();
        public DALSexo()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<Sexo> GetAllSexo()
        {
            IDataReader reader = null;
            List<Sexo> lista = new List<Sexo>();
            SqlCommand command = new SqlCommand();

            string sql = @" select * from  Sexo WITH (NOLOCK) where estado = 1  ";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {

                        Sexo oSexo = new Sexo();
                        oSexo.IdSexo = int.Parse(reader["IdSexo"].ToString());
                        oSexo.Descripcion = reader["Descripcion"].ToString();
                        lista.Add(oSexo);
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
