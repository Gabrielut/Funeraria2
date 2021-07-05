using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public List<DireccionCompleta> GetAllDireccionCompleta()
        {
            throw new NotImplementedException();
        }

        public List<DireccionCompleta> GetDireccionCompletaByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public DireccionCompleta GetDireccionCompletaById(int pProovedor)
        {
            throw new NotImplementedException();
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
    }
}
