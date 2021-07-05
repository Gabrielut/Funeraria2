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
    class DALBarrio : IDALBarrio
    {
        Usuarios _Usuario = new Usuarios();
        public DALBarrio()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        List<Barrio> IDALBarrio.GetBarrioById(int provincia, int canton, int distrito)
        {
            DataSet ds = null;
            List<Barrio> lista = new List<Barrio>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Barrio where codProvincia = @provincia and codCanton = @canton and codDistrito = @distrito";

                command.Parameters.AddWithValue("@provincia", provincia);
                command.Parameters.AddWithValue("@canton", canton);
                command.Parameters.AddWithValue("@distrito", distrito);
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
                        Barrio oBarrio = new Barrio();
                        oBarrio.codProvincia = int.Parse(dr["codProvincia"].ToString());
                        oBarrio.codCanton = int.Parse(dr["codCanton"].ToString());
                        oBarrio.codDistrito = int.Parse(dr["codDistrito"].ToString());
                        oBarrio.codBarrio = int.Parse(dr["codBarrio"].ToString());
                        oBarrio.dscBarrio = dr["dscBarrio"].ToString();
                        oBarrio.logActivo = int.Parse(dr["logActivo"].ToString());
                        lista.Add(oBarrio);
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
