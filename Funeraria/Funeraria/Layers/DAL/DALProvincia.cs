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
    class DALProvincia : IDALProvincia
    {
        Usuarios _Usuario = new Usuarios();
        public DALProvincia()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<Provincia> GetAllProvincia()
        {
            DataSet ds = null;
            List<Provincia> lista = new List<Provincia>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Provincia";

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
                        Provincia oProvincia = new Provincia();
                        oProvincia.codProvincia = int.Parse(dr["codProvincia"].ToString());
                        oProvincia.dscCortaProvincia = dr["dscCortaProvincia"].ToString();
                        oProvincia.dscProvincia = dr["dscProvincia"].ToString();
                        oProvincia.logActivo = int.Parse(dr["logActivo"].ToString());

                        lista.Add(oProvincia);
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
