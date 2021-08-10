using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;
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
        public List<Cotizacion> GetCotizacionById(int id)
        {
            DataSet ds = null;
            List<Cotizacion> lista = new List<Cotizacion>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Cotizacion where IdCotizacion = @IdCotizacion";

                command.Parameters.AddWithValue("@IdCotizacion", id);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Cotizacion oCotizacion = new Cotizacion();
                        oCotizacion.IdCotizacion = int.Parse(dr["IdCotizacion"].ToString());
                        oCotizacion.IdCliente = int.Parse(dr["IdCliente"].ToString());
                        oCotizacion.IdPaquete = int.Parse(dr["IdPaquete"].ToString());
                        oCotizacion.IdConvenio = int.Parse(dr["IdConvenio"].ToString());
                        oCotizacion.IdProveedores = int.Parse(dr["IdProveedores"].ToString());
                        oCotizacion.IdActivo = int.Parse(dr["IdActivo"].ToString());
                        oCotizacion.Comentarios = dr["Comentarios"].ToString();

                        lista.Add(oCotizacion);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
                MessageBox.Show("error");
            }
            return lista;
        }

        public List<CotizacionDTO> GetCotizacionByIdDTO(int id)
        {
            DataSet ds = null;
            List<CotizacionDTO> lista = new List<CotizacionDTO>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Cotizacion where IdCotizacion = @IdCotizacion";

                command.Parameters.AddWithValue("@IdCotizacion", id);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        CotizacionDTO oCotizacion = new CotizacionDTO();
                        //oCotizacion.IdCotizacion = int.Parse(dr["IdCotizacion"].ToString());
                        //oCotizacion.IdCliente = int.Parse(dr["IdCliente"].ToString());
                        //oCotizacion.IdPaquete = int.Parse(dr["IdPaquete"].ToString());
                        //oCotizacion.IdConvenio = int.Parse(dr["IdConvenio"].ToString());
                        //oCotizacion.IdProveedores = int.Parse(dr["IdProveedores"].ToString());
                        //oCotizacion.Comentarios = dr["Comentarios"].ToString();

                        lista.Add(oCotizacion);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
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
                            ([IdCotizacion]
                            ,[IdCliente]
                            ,[IdPaquete]
                            ,[IdConvenio]
                            ,[IdProveedores]
                            ,[IdActivo]
                            ,[Comentarios])
                            VALUES
                            (@IdCotizacion,
                             @IdCliente,
                             @IdPaquete,
                             @IdConvenio,
                             @IdProveedores,
                             @IdActivo,
                             @Comentarios)";

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.AddWithValue("@IdCotizacion", pCotizacion.IdCotizacion);
                cmd.Parameters.AddWithValue("@IdCliente", pCotizacion.IdCliente);
                cmd.Parameters.AddWithValue("@IdPaquete", pCotizacion.IdPaquete);
                cmd.Parameters.AddWithValue("@IdConvenio", pCotizacion.IdConvenio);
                cmd.Parameters.AddWithValue("@IdProveedores", pCotizacion.IdProveedores);
                cmd.Parameters.AddWithValue("@IdActivo", pCotizacion.IdActivo);
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
