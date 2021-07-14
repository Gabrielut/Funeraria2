using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.Layers.DAL
{
    class DALConvenios : IDALConvenios
    {
        Usuarios _Usuario = new Usuarios();
        public DALConvenios()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public bool DaleteConvenios(int pId)
        {
            double rows = 0;
            string sql = @"DELETE FROM Convenios
                            WHERE IdConvenio = @filtro";
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

        public List<ConveniosDTO> GetAllConvenios()
        {
            DataSet ds = null;
            List<ConveniosDTO> lista = new List<ConveniosDTO>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT Convenios.IdConvenio, Convenios.NomEmpresa, 
                               Convenios.Ubicacion, Convenios.TelCelular, Convenios.TelEmpresa,
                               Convenios.TelFax, Convenios.Descuento, Convenios.Estado, 
                               Convenios.Comentarios, 
                               TipoServicio.Descripcion AS 'TipoServicio'
                               FROM Convenios INNER JOIN
                               TipoServicio ON Convenios.TipoServicio = TipoServicio.IdTipoServicio";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ConveniosDTO oConveniosDTO = new ConveniosDTO();
                        oConveniosDTO.IdConvenio = int.Parse(dr["IdConvenio"].ToString());
                        oConveniosDTO.NomEmpresa = dr["NomEmpresa"].ToString();
                        oConveniosDTO.ubicacion = dr["Ubicacion"].ToString();
                        oConveniosDTO.TelCelular = dr["TelCelular"].ToString();
                        oConveniosDTO.TelEmpresa = dr["TelEmpresa"].ToString();
                        oConveniosDTO.TelFax = dr["TelFax"].ToString();
                        oConveniosDTO.TipoServicio = dr["TipoServicio"].ToString();
                        oConveniosDTO.Descuento = int.Parse(dr["Descuento"].ToString());
                        if (bool.Parse(dr["Estado"].ToString()))
                        {
                            oConveniosDTO.Estado = "Activo";
                        }
                        else
                        {
                            oConveniosDTO.Estado = "Inactivo";
                        }

                        oConveniosDTO.Comentarios = dr["Comentarios"].ToString();
                        lista.Add(oConveniosDTO);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }

        public Convenios GetConvenioById(int pConvenios)
        {
            DataSet ds = null;
            Convenios oConvenios = null;
            string sql = @"select * from Convenios where IdConvenio = @filtro";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", pConvenios);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow dr = ds.Tables[0].Rows[0];
                    oConvenios = new Convenios()
                    {
   
                    IdConvenio = int.Parse(dr["IdConvenio"].ToString()),
                    NomEmpresa = dr["NomEmpresa"].ToString(),
                    ubicacion = dr["Ubicacion"].ToString(),
                    TelCelular = dr["TelCelular"].ToString(),
                    TelEmpresa = dr["TelEmpresa"].ToString(),
                    TelFax = dr["TelFax"].ToString(),
                    TipoServicio = int.Parse(dr["TipoServicio"].ToString()),
                    Descuento = int.Parse(dr["Descuento"].ToString()),
                    Estado = bool.Parse(dr["Estado"].ToString()),
                    Comentarios = dr["Comentarios"].ToString()     
                };
                }
                return oConvenios;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public List<Convenios> GetConveniosByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public Convenios SaveConvenios(Convenios pConvenios)
        {
            Convenios oConvenios = null;
            double rows = 0;
            string sql = @"INSERT INTO Convenios
           ([IdConvenio]
           ,[NomEmpresa]
           ,[Ubicacion]
           ,[TelCelular]
           ,[TelEmpresa]
           ,[TelFax]
           ,[TipoServicio]
           ,[Descuento]
           ,[Estado]
           ,[Comentarios])
     VALUES
           (@IdConvenio
           ,@NomEmpresa
           ,@Ubicacion
           ,@TelCelular
           ,@TelEmpresa
           ,@TelFax
           ,@TipoServicio
           ,@Descuento
           ,@Estado
           ,@Comentarios)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdConvenio", pConvenios.IdConvenio);
            cmd.Parameters.AddWithValue("@NomEmpresa", pConvenios.NomEmpresa);
            cmd.Parameters.AddWithValue("@Ubicacion", pConvenios.ubicacion);
            cmd.Parameters.AddWithValue("@TelCelular", pConvenios.TelCelular);
            cmd.Parameters.AddWithValue("@TelEmpresa", pConvenios.TelEmpresa);
            cmd.Parameters.AddWithValue("@TelFax", pConvenios.TelFax);
            cmd.Parameters.AddWithValue("@TipoServicio", pConvenios.TipoServicio);
            cmd.Parameters.AddWithValue("@Descuento", pConvenios.Descuento);
            cmd.Parameters.AddWithValue("@Estado", pConvenios.Estado);
            cmd.Parameters.AddWithValue("@Comentarios", pConvenios.Comentarios);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }

            if (rows > 0)
            {
                oConvenios = GetConvenioById(pConvenios.IdConvenio);
            }
            return oConvenios;
        }

        public Convenios UpdateConvenios(Convenios pConvenios)
        {
            Convenios oConvenios = null;
            string sql = @" UPDATE Convenios
                            SET [NomEmpresa] = @NomEmpresa
                                  ,[Ubicacion] = @Ubicacion
                                  ,[TelCelular] = @TelCelular
                                  ,[TelEmpresa] = @TelEmpresa
                                  ,[TelFax] = @TelFax
                                  ,[TipoServicio] = @TipoServicio
                                  ,[Descuento] = @Descuento
                                  ,[Estado] = @Estado
                                  ,[Comentarios] = @Comentarios
                             WHERE IdConvenio = @filtro";

            SqlCommand command = new SqlCommand();
            double rows = 0;
            try
            {
                command.Parameters.AddWithValue("@NomEmpresa", pConvenios.NomEmpresa);
                command.Parameters.AddWithValue("@Ubicacion", pConvenios.ubicacion);
                command.Parameters.AddWithValue("@TelCelular", pConvenios.TelCelular);
                command.Parameters.AddWithValue("@TelEmpresa", pConvenios.TelEmpresa);
                command.Parameters.AddWithValue("@TelFax", pConvenios.TelFax);
                command.Parameters.AddWithValue("@TipoServicio", pConvenios.TipoServicio);
                command.Parameters.AddWithValue("@Descuento", pConvenios.Descuento);
                command.Parameters.AddWithValue("@Estado", pConvenios.Estado);
                command.Parameters.AddWithValue("@Comentarios", pConvenios.Comentarios);
                command.Parameters.AddWithValue("@filtro", pConvenios.IdConvenio);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oConvenios = GetConvenioById(pConvenios.IdConvenio);

                return oConvenios;
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }
}
