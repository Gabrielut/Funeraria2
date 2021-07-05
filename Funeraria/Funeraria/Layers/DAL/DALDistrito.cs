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
    class DALDistrito : IDALDistrito
    {
        Usuarios _Usuario = new Usuarios();
        public DALDistrito()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }

        public List<Distrito> GetDistritoById(int provincia, int canton)
        {
            DataSet ds = null;
            List<Distrito> lista = new List<Distrito>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Distrito where codProvincia = @provincia and codCanton = @canton";

                command.Parameters.AddWithValue("@provincia", provincia);
                command.Parameters.AddWithValue("@canton", canton);
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
                        Distrito oDistrito = new Distrito();
                        oDistrito.codProvincia = int.Parse(dr["codProvincia"].ToString());
                        oDistrito.codCanton = int.Parse(dr["codCanton"].ToString());
                        oDistrito.codDistrito = int.Parse(dr["codDistrito"].ToString());
                        oDistrito.dscDistrito = dr["dscDistrito"].ToString();
                        oDistrito.logActivo = int.Parse(dr["logActivo"].ToString());
                        lista.Add(oDistrito);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }
    }
}
