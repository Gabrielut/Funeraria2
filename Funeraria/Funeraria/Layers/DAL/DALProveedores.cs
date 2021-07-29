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
    class DALProveedores : IDALProveedores
    {
        Usuarios _Usuario = new Usuarios();
        public DALProveedores()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public bool DaleteProveedor(int pId)
        {
            double rows = 0;
            string sql = @"DELETE FROM Proveedores
                           WHERE IdProveedor = @filtro";
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

        public List<ProveedorDTO> GetAllProveedor()
        {
            DataSet ds = null;
            List<ProveedorDTO> lista = new List<ProveedorDTO>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT Proveedores.IdProveedor, Proveedores.NomProveedor, Proveedores.Propietario, Proveedores.TelCelular, Proveedores.TelProveedor, Proveedores.TelFax, Proveedores.Correo, Proveedores.Precio, Proveedores.CantUni, 
                             Proveedores.Estado, Provincia.dscProvincia AS Provincia, Canton.dscCanton AS Canton, Distrito.dscDistrito AS Distrito, Barrio.dscBarrio AS Barrio, DireccionCompleta.otrasSennas, TipoServicio.Descripcion AS Servicio
FROM                         DireccionCompleta INNER JOIN
                             Proveedores ON DireccionCompleta.IdDireccion = Proveedores.IdProveedor INNER JOIN
                             Barrio ON DireccionCompleta.Provincia = Barrio.codProvincia AND DireccionCompleta.Canton = Barrio.codCanton AND DireccionCompleta.Distrito = Barrio.codDistrito AND 
                             DireccionCompleta.Barrio = Barrio.codBarrio INNER JOIN
                             Canton ON Barrio.codProvincia = Canton.codProvincia INNER JOIN
                             Distrito ON Barrio.codProvincia = Distrito.codProvincia AND Barrio.codCanton = Distrito.codCanton AND Barrio.codDistrito = Distrito.codDistrito AND Canton.codProvincia = Distrito.codProvincia AND 
                             Canton.codCanton = Distrito.codCanton INNER JOIN
                             Provincia ON Canton.codProvincia = Provincia.codProvincia INNER JOIN
                             TipoServicio ON Proveedores.IdTipoServicio = TipoServicio.IdTipoServicio";

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
                        ProveedorDTO oProveedorDTO = new ProveedorDTO();
                        oProveedorDTO.IdProveedor = int.Parse(dr["IdProveedor"].ToString());
                        oProveedorDTO.NomProveedor = dr["NomProveedor"].ToString();
                        oProveedorDTO.Propietario = dr["Propietario"].ToString();
                        oProveedorDTO.TelCelular = dr["TelCelular"].ToString();
                        oProveedorDTO.TelProveedor = (dr["TelProveedor"].ToString());
                        oProveedorDTO.TelFax = (dr["TelFax"].ToString());
                        oProveedorDTO.Correo = (dr["Correo"].ToString());
                        oProveedorDTO.Precio = (dr["Precio"].ToString());
                        oProveedorDTO.CantUni = int.Parse(dr["CantUni"].ToString());
                        oProveedorDTO.IdTipoServicio = (dr["Servicio"].ToString());
                        if ((bool)(dr["Estado"]))
                        {
                            oProveedorDTO.Estado = "Activo";
                        }
                        else
                        {
                            oProveedorDTO.Estado = "Desabilitado";
                        }
                        oProveedorDTO.Provincia = (dr["Provincia"].ToString());
                        oProveedorDTO.Canton = (dr["Canton"].ToString());
                        oProveedorDTO.Distrito = (dr["Distrito"].ToString());
                        oProveedorDTO.Barrio = (dr["Barrio"].ToString());
                        oProveedorDTO.otrasSennas = (dr["otrasSennas"].ToString());
                        lista.Add(oProveedorDTO);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }

        public int GetNextNumeroActivo()
        {
            //DataSet ds = null;
            //IDbCommand command = new SqlCommand();
            //int numeroActivo;
            //string sql = @"SELECT NEXT VALUE FOR SequenceNoProveedor";

            //DataTable dt = null;
            //try
            //{
            //    command.CommandText = sql;
            //    command.CommandType = CommandType.Text;

            //    using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            //    {

            //        ds = db.ExecuteReader(command, "query");
            //    }

            //     Extraer la tabla 
            //    dt = ds.Tables[0];
            //    Extraer el valor que viene en el DataTable 
            //    numeroActivo = int.Parse(dt.Rows[0][0].ToString());
            //    return numeroActivo;
            //}
            //catch (Exception er)
            //{

            //    throw;
            //}
            throw new NotImplementedException();
        }

        public List<ProveedorDTO> GetProveedorByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<ProveedorDTO> lista = new List<ProveedorDTO>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT Proveedores.IdProveedor, Proveedores.NomProveedor, Proveedores.Propietario,
                               Proveedores.TelCelular, Proveedores.TelProveedor, Proveedores.TelFax, Proveedores.Correo,
                               Proveedores.Precio, Proveedores.CantUni, Proveedores.Estado, TipoServicio.Descripcion AS IdTipoServicio, 
                               Provincia.dscProvincia AS Provincia, Canton.dscCanton AS Canton, 
                               Distrito.dscDistrito AS Distrito, Barrio.dscBarrio AS Barrio, DireccionCompleta.otrasSennas
                               FROM Barrio INNER JOIN
                               Canton ON Barrio.codProvincia = Canton.codProvincia INNER JOIN
                               DireccionCompleta ON Barrio.codProvincia = DireccionCompleta.Provincia AND 
                               Barrio.codCanton = DireccionCompleta.Canton AND Barrio.codDistrito = DireccionCompleta.Distrito AND 
                               Barrio.codBarrio = DireccionCompleta.Barrio INNER JOIN
                               Distrito ON Barrio.codProvincia = Distrito.codProvincia AND Barrio.codCanton = Distrito.codCanton AND 
                               Barrio.codDistrito = Distrito.codDistrito AND Canton.codProvincia = Distrito.codProvincia AND 
                               Canton.codCanton = Distrito.codCanton INNER JOIN
                               Proveedores ON DireccionCompleta.IdDireccion = Proveedores.IdProveedor INNER JOIN
                               Provincia ON Canton.codProvincia = Provincia.codProvincia INNER JOIN
                               TipoServicio ON Proveedores.IdTipoServicio = TipoServicio.IdTipoServicio
						       Where NomProveedor+Propietario+TipoServicio.Descripcion+Provincia.dscProvincia+Canton.dscCanton+
                               Distrito.dscDistrito+Barrio.dscBarrio+DireccionCompleta.otrasSennas like @filtro";

                command.Parameters.AddWithValue("@filtro", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ProveedorDTO oProveedorDTO = new ProveedorDTO();
                        oProveedorDTO.IdProveedor = int.Parse(dr["IdProveedor"].ToString());
                        oProveedorDTO.NomProveedor = dr["NomProveedor"].ToString();
                        oProveedorDTO.Propietario = dr["Propietario"].ToString();
                        oProveedorDTO.TelCelular = dr["TelCelular"].ToString();
                        oProveedorDTO.TelProveedor = (dr["TelProveedor"].ToString());
                        oProveedorDTO.TelFax = (dr["TelFax"].ToString());
                        oProveedorDTO.Correo = (dr["Correo"].ToString());
                        oProveedorDTO.Precio = (dr["Precio"].ToString());
                        oProveedorDTO.CantUni = int.Parse(dr["CantUni"].ToString());
                        oProveedorDTO.IdTipoServicio = (dr["IdTipoServicio"].ToString());
                        if ((bool)(dr["Estado"]))
                        {
                            oProveedorDTO.Estado = "Activo";
                        }
                        else
                        {
                            oProveedorDTO.Estado = "Desabilitado";
                        }
                        oProveedorDTO.Provincia = (dr["Provincia"].ToString());
                        oProveedorDTO.Canton = (dr["Canton"].ToString());
                        oProveedorDTO.Distrito = (dr["Distrito"].ToString());
                        oProveedorDTO.Barrio = (dr["Barrio"].ToString());
                        oProveedorDTO.otrasSennas = (dr["otrasSennas"].ToString());
                        lista.Add(oProveedorDTO);
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return lista;
        }

        public Proveedor GetProveedorById(int pProveedor)
        {
            DataSet ds = null;
            Proveedor oProveedor = null;
            string sql = @"select * from Proveedores where IdProveedor = @filtro";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@filtro", pProveedor);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow dr = ds.Tables[0].Rows[0];
                    oProveedor = new Proveedor()
                    {
                        IdProveedor = int.Parse(dr["IdProveedor"].ToString()),
                        NomProveedor = (dr["NomProveedor"].ToString()),
                        Propietario = dr["Propietario"].ToString(),
                        TelCelular = dr["TelCelular"].ToString(),
                        TelProveedor = (dr["TelProveedor"].ToString()),
                        TelFax = (dr["TelFax"].ToString()),
                        Correo = (dr["Correo"].ToString()),
                        Precio = (float.Parse(dr["Precio"].ToString())),
                        CantUni = int.Parse(dr["CantUni"].ToString()),
                        IdTipoServicio = int.Parse(dr["IdTipoServicio"].ToString()),
                        Estado = (bool)dr["Estado"],
                    };


                }

                return oProveedor;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public Proveedor SaveProveedor(Proveedor pProveedor)
        {
            Proveedor oProveedor = null;
            double rows = 0;
            string sql = @"INSERT INTO Proveedores
           ([IdProveedor]
           ,[NomProveedor]
           ,[Propietario]
           ,[TelCelular]
           ,[TelProveedor]
           ,[TelFax]
           ,[Correo]
           ,[Precio]
           ,[CantUni]
           ,[IdTipoServicio]
           ,[Estado])
     VALUES
           (@IdProveedor
           ,@NomProveedor
           ,@Propietario
           ,@TelCelular
           ,@TelProveedor
           ,@TelFax
           ,@Correo
           ,@Precio
           ,@CantUni
           ,@IdTipoServicio
           ,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProveedor", pProveedor.IdProveedor);
            cmd.Parameters.AddWithValue("@NomProveedor", pProveedor.NomProveedor);
            cmd.Parameters.AddWithValue("@Propietario", pProveedor.Propietario);
            cmd.Parameters.AddWithValue("@TelCelular", pProveedor.TelCelular);
            cmd.Parameters.AddWithValue("@TelProveedor", pProveedor.TelProveedor);
            cmd.Parameters.AddWithValue("@TelFax", pProveedor.TelFax);
            cmd.Parameters.AddWithValue("@Correo", pProveedor.Correo);
            cmd.Parameters.AddWithValue("@Precio", pProveedor.Precio);
            cmd.Parameters.AddWithValue("@CantUni", pProveedor.CantUni);
            cmd.Parameters.AddWithValue("@IdTipoServicio", pProveedor.IdTipoServicio);
            cmd.Parameters.AddWithValue("@Estado", pProveedor.Estado);
            cmd.CommandText = sql;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
            {
                rows = db.ExecuteNonQuery(cmd);
            }

            if (rows > 0)
            {
                oProveedor = GetProveedorById(pProveedor.IdProveedor);
            }
            return pProveedor;
        }

        public Proveedor UpdateProveedor(Proveedor pProveedor)
        {
            Proveedor oProveedor = null;
            string sql = @"UPDATE Proveedores
                            SET 
                             [NomProveedor] = @NomProveedor
                            ,[Propietario] = @Propietario
                            ,[TelCelular] = @TelCelular
                            ,[TelProveedor] = @TelProveedor
                            ,[TelFax] = @TelFax
                            ,[Correo] = @Correo
                            ,[Precio] = @Precio
                            ,[CantUni] = @CantUni
                            ,[IdTipoServicio] = @IdTipoServicio
                            ,[Estado] = @Estado
                            WHERE 
                            IdProveedor = @IdProveedor";
            SqlCommand command = new SqlCommand();
            double rows = 0;
            try
            {
                command.Parameters.AddWithValue("@IdProveedor", pProveedor.IdProveedor);
                command.Parameters.AddWithValue("@NomProveedor", pProveedor.NomProveedor);
                command.Parameters.AddWithValue("@Propietario", pProveedor.Propietario);
                command.Parameters.AddWithValue("@TelCelular", pProveedor.TelCelular);
                command.Parameters.AddWithValue("@TelProveedor", pProveedor.TelProveedor);
                command.Parameters.AddWithValue("@TelFax", pProveedor.TelFax);
                command.Parameters.AddWithValue("@Correo", pProveedor.Correo);
                command.Parameters.AddWithValue("@Precio", pProveedor.Precio);
                command.Parameters.AddWithValue("@CantUni", pProveedor.CantUni);
                command.Parameters.AddWithValue("@IdTipoServicio", pProveedor.IdTipoServicio);
                command.Parameters.AddWithValue("@Estado", pProveedor.Estado);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (rows > 0)
                    oProveedor = GetProveedorById(pProveedor.IdProveedor);

                return oProveedor;
            }
            catch (Exception er)
            {
                throw;
            }
        }
    }
}
