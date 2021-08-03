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
    class DALDetFactura : IDALDetFactura
    {
        Usuarios _Usuario = new Usuarios();

        public DALDetFactura()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<DetFactura> GetAllDetFactura()
        {
            throw new NotImplementedException();
        }

        public int GetNumeroFactura()
        {
            DataSet ds = null;
            int nextValue;
            string sql = @"select max(IdFactura) from EncFactura";
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

        public bool SaveDetFactura(DetFactura pDetFactura)
        {
            DetFactura oDetFactura = null;
            double rows = 0;
            bool estado = false;
            string sql = @"INSERT INTO DetFactura
           ([IdFactura]
           ,[IdPaquete]
           ,[IdConvenio]
           ,[IdActivo]
           ,[IdProveedores]
           ,[Precio]
           ,[Cantidad])
     VALUES
           (@IdFactura,
            @IdPaquete,
            @IdConvenio,
            @IdActivo,
            @IdProveedores,
            @Precio,
            @Cantidad)";

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.AddWithValue("@IdFactura", pDetFactura.IdFactura);
                cmd.Parameters.AddWithValue("@IdPaquete", pDetFactura.IdPaquete);
                cmd.Parameters.AddWithValue("@IdConvenio", pDetFactura.IdConvenio);
                cmd.Parameters.AddWithValue("@IdActivo", pDetFactura.IdActivo);
                cmd.Parameters.AddWithValue("@IdProveedores", pDetFactura.IdProveedores);
                cmd.Parameters.AddWithValue("@Precio", pDetFactura.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", pDetFactura.Cantidad);
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    rows = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }
                if (rows > 0)
                {
                    estado = true;
                }
            }

            catch (Exception er)
            {

                throw;
            }

            return estado;
        }
    }
}
