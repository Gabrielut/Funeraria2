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
    class DALCotizacion : IDALCotizacion
    {
        Usuarios _Usuario = new Usuarios();

        public DALCotizacion()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<Cotizacion> GetAllCotizacion()
        {
            throw new NotImplementedException();
        }

        public int nextValue()
        {
            DataSet ds = null;
            int nextValue;
            string sql = @"select MAX(IdCotizacion) + 1 from Cotizacion";
            SqlCommand command = new SqlCommand();
            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }
                dt = ds.Tables[0];
                nextValue = int.Parse(dt.Rows[0][0].ToString());
                return nextValue;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public Cotizacion SaveCotizacion(Cotizacion pCotizacion)
        {
            Cotizacion oCotizacion = null;
            double rows = 0;
            string sql = @"INSERT INTO Cotizacion
                            ([IdCliente]
                            ,[IdPaquete]
                            ,[IdConvenio]
                            ,[IdProveedores]
                            ,[Comentarios])
                            VALUES
                            (@IdCliente,
                             @IdPaquete,
                             @IdConvenio,
                             @IdProveedores,
                             @Comentarios)";

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.AddWithValue("@IdCliente", pCotizacion.IdCliente);
                cmd.Parameters.AddWithValue("@IdPaquete", pCotizacion.IdPaquete);
                cmd.Parameters.AddWithValue("@IdConvenio", pCotizacion.IdConvenio);
                cmd.Parameters.AddWithValue("@IdProveedores", pCotizacion.IdProveedores);
                cmd.Parameters.AddWithValue("@Comentarios", pCotizacion.Comentarios);   

                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    rows = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

            }
            
            catch (Exception er)
            {

                throw;
            }


            return oCotizacion;
        }
    }
}
