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
    class DALCanton : IDALCanton
    {
        Usuarios _Usuario = new Usuarios();
        public DALCanton()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<Canton> GetCantonById(int provincia)
        {
            DataSet ds = null;
            List<Canton> lista = new List<Canton>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from canton where codProvincia = @filtro";

                command.Parameters.AddWithValue("@filtro", provincia);
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
                        Canton oCanton = new Canton();
                        oCanton.codProvincia = int.Parse(dr["codProvincia"].ToString());
                        oCanton.codCanton = int.Parse(dr["codCanton"].ToString());
                        oCanton.dscCanton = dr["dscCanton"].ToString();
                        oCanton.logActivo = int.Parse(dr["logActivo"].ToString());
                        lista.Add(oCanton);
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
