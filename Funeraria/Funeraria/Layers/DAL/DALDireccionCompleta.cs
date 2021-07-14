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
    class DALDireccionCompleta : IDALDireccionCompleta
    {
        Usuarios _Usuario = new Usuarios();
        public DALDireccionCompleta()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public bool DaleteDireccionCompleta(int pId)
        {
            double rows = 0;
            string sql = @"DELETE FROM DireccionCompleta
                           WHERE IdDireccion = @filtro";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@filtro", pId);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<DireccionCompleta> GetAllDireccionCompleta()
        {
            throw new NotImplementedException();
        }

        public List<DireccionCompleta> GetDireccionCompletaByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public DireccionCompleta GetDireccionCompletaById(int pDireccion)
        {
            DataSet ds = null;
            DireccionCompleta oDireccionCompleta = null;
            string sql = @"select * from DireccionCompleta where IdDireccion = @filtro";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", pDireccion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow dr = ds.Tables[0].Rows[0];
                    oDireccionCompleta = new DireccionCompleta()
                    {
                        IdDireccion = int.Parse(dr["IdDireccion"].ToString()),
                        Provincia = int.Parse(dr["Provincia"].ToString()),
                        Canton = int.Parse(dr["Canton"].ToString()),
                        Distrito = int.Parse(dr["Distrito"].ToString()),
                        Barrio = int.Parse(dr["Barrio"].ToString()),                       
                        OtrasSennas = dr["OtrasSennas"].ToString(),
                       
                    };


                }

                return oDireccionCompleta;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public DireccionCompleta SaveDireccionCompleta(DireccionCompleta pDireccionCompleta)
        {
            DireccionCompleta oDireccionCompleta = null;
            double rows = 0;
            string sql = @"INSERT INTO DireccionCompleta
           ([IdDireccion]
           ,[Provincia]
           ,[Canton]
           ,[Distrito]
           ,[Barrio]
           ,[otrasSennas])
     VALUES
           (@IdDireccion
            ,@Provincia
            ,@Canton
            ,@Distrito
            ,@Barrio
            ,@otrasSennas)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdDireccion", pDireccionCompleta.IdDireccion);
            cmd.Parameters.AddWithValue("@Provincia", pDireccionCompleta.Provincia);
            cmd.Parameters.AddWithValue("@Canton", pDireccionCompleta.Canton);
            cmd.Parameters.AddWithValue("@Distrito", pDireccionCompleta.Distrito);
            cmd.Parameters.AddWithValue("@Barrio", pDireccionCompleta.Barrio);
            cmd.Parameters.AddWithValue("@otrasSennas", pDireccionCompleta.OtrasSennas);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }

            //if (rows > 0)
            //{
            //    oDireccionCompleta = GetActivoById(pActivo.IdActivo);
            //}
            return oDireccionCompleta;
        }

        public DireccionCompleta UpdateDireccionCompleta(DireccionCompleta pDireccionCompleta)
        {
            DireccionCompleta oDireccionCompleta = null;
            string sql = @"UPDATE DireccionCompleta
                             SET [Provincia] = @Provincia
                            ,[Canton] = @Canton
                         ,[Distrito] = @Distrito
                         ,[Barrio] = @Barrio
                        ,[otrasSennas] = @otrasSennas
                        WHERE IdDireccion = @filtro";

            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {               
                command.Parameters.AddWithValue("@Provincia", pDireccionCompleta.Provincia);
                command.Parameters.AddWithValue("@Canton", pDireccionCompleta.Canton);
                command.Parameters.AddWithValue("@Distrito", pDireccionCompleta.Distrito);
                command.Parameters.AddWithValue("@Barrio", pDireccionCompleta.Barrio);
                command.Parameters.AddWithValue("@otrasSennas", pDireccionCompleta.OtrasSennas);
                command.Parameters.AddWithValue("@filtro", pDireccionCompleta.IdDireccion);
        
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oDireccionCompleta = GetDireccionCompletaById(pDireccionCompleta.IdDireccion);

                return oDireccionCompleta;
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }
}
