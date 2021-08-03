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
    class DALEncFactura : IDALEncFactura
    {
        Usuarios _Usuario = new Usuarios();

        public DALEncFactura()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<EncFactura> GetAllEncFactura()
        {
            throw new NotImplementedException();
        }

        public EncFactura GetEncFacturaById(int id)
        {
            DataSet ds = null;
            EncFactura oEncFactura = null;
            string sql = @" select * from EncFactura where IdFactura = @filtro";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", id);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow dr = ds.Tables[0].Rows[0];
                    oEncFactura = new EncFactura()
                    {
                        IdCliente = int.Parse(dr["IdCliente"].ToString()),
                        Fecha = DateTime.Parse(dr["Fecha"].ToString()),
                        IdCotizacion = int.Parse(dr["IdCotizacion"].ToString()),
                        IdConvenio = int.Parse(dr["IdConvenio"].ToString()),
                        Subtotal = float.Parse(dr["Subtotal"].ToString()),
                        IVA = float.Parse(dr["IVA"].ToString()),
                        Total = float.Parse(dr["Total"].ToString()),
                        Estado = (bool)dr["Estado"],

                    };


                }

                return oEncFactura;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public EncFactura SaveEncFactura(EncFactura pEncFactura)
        {
            EncFactura oEncFactura = null;
            double rows = 0;
            string sql = @"INSERT INTO EncFactura
           ([Fecha]
           ,[IdCliente]
           ,[IdConvenio]
           ,[Estado]
           ,[Subtotal]
           ,[IVA]
           ,[Total]
           ,[IdCotizacion])
     VALUES
           (@Fecha,
            @IdCliente,
            @IdConvenio,
            @Estado,
            @Subtotal,
            @IVA,
            @Total,
            @IdCotizacion)";

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.AddWithValue("@Fecha", pEncFactura.Fecha);
                cmd.Parameters.AddWithValue("@IdCliente", pEncFactura.IdCliente);
                cmd.Parameters.AddWithValue("@IdConvenio", pEncFactura.IdConvenio);
                cmd.Parameters.AddWithValue("@Estado", pEncFactura.Estado);
                cmd.Parameters.AddWithValue("@Subtotal", pEncFactura.Subtotal);
                cmd.Parameters.AddWithValue("@IVA", pEncFactura.IVA);
                cmd.Parameters.AddWithValue("@Total", pEncFactura.Total);
                cmd.Parameters.AddWithValue("@IdCotizacion", pEncFactura.IdCotizacion);

                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    rows = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

            }

            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                msg.AppendFormat("SQL            {0}\n", cmd.CommandText);

                throw;
            }


            return oEncFactura;
        }
    }
}
