using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


public class DataBase : IDataBase ,IDisposable
{
    public IDbConnection _Conexion { get; set; } = new SqlConnection();

    public IDataReader ExecuteReader(IDbCommand pCommand)
    {

        IDataReader lector = null;
        try
        {
            pCommand.Connection = _Conexion;
            lector = pCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return lector;
        }
        catch (Exception)
        {
            
            throw;
        }


    }

    public DataSet ExecuteReader(IDbCommand pCommand, String pTabla)
    {

        DataSet dsTabla = new DataSet();
        try
        { 

            using (SqlDataAdapter adaptador = new SqlDataAdapter(pCommand as SqlCommand))
            {
                pCommand.Connection = _Conexion;
                dsTabla = new DataSet();
                adaptador.Fill(dsTabla, pTabla);
            }
            return dsTabla;
        }
        catch (Exception)
        {

            // lanzar excepción                     
            throw;
        }
        finally
        {

            if (dsTabla != null)
                dsTabla.Dispose(); 
        } 

    }

    public double ExecuteNonQuery(IDbCommand pCommand, IsolationLevel pIsolationLevel)
    {
        using (IDbTransaction transaccion =  _Conexion.BeginTransaction(pIsolationLevel))
        {
            double registrosafectados = 0;
            try
            {

                pCommand.Connection = _Conexion;
                pCommand.Transaction = transaccion;
                registrosafectados = pCommand.ExecuteNonQuery();

                // Commit a la transacción
                transaccion.Commit();

                return registrosafectados;
            }

            catch (Exception)
            {

                throw;
            }

        }

    }

    public double ExecuteNonQuery(IDbCommand pCommand)
    {

        double registrosafectados = 0;
        try
        {

            pCommand.Connection = _Conexion;

            registrosafectados = pCommand.ExecuteNonQuery();

            return registrosafectados;

        }
        catch (Exception)
        {

            throw;
        }
    }

    public double ExecuteScalar(IDbCommand pCommand)
    {
        double registrosafectados = 0;
        object respuesta = null;
        try
        {

            pCommand.Connection = _Conexion;

            respuesta = pCommand.ExecuteScalar();

            if (respuesta == null)
                registrosafectados = 0d;
            else
                double.TryParse(respuesta.ToString(), out registrosafectados);


            return registrosafectados;

        }
        catch (Exception)
        {

            throw;
        }


    }

    public int ExecuteNonQuery(ref IDbCommand pCommand, IsolationLevel pIsolationLevel)
    {
        int registrosafectados = 0;

        using (IDbTransaction transaccion = _Conexion.BeginTransaction(pIsolationLevel))
        {

            try
            {

                pCommand.Connection = _Conexion;
                pCommand.Transaction = transaccion;
                registrosafectados = pCommand.ExecuteNonQuery();

                // Commit a la transacción
                transaccion.Commit();

                return registrosafectados;
            } 
            catch (Exception error)
            {

                throw error;
            }

        }

    }
  
    public int  ExecuteNonQuery(List<IDbCommand> pCommands, IsolationLevel pIsolationLevel)
    {
        int registrosafectados = 0;
        try
        {
            using (IDbTransaction transaccion = _Conexion.BeginTransaction(pIsolationLevel))
            {
                foreach (IDbCommand command in pCommands)
                {
                    command.Connection = (_Conexion as SqlConnection);
                    command.Transaction = transaccion;               
                    registrosafectados = command.ExecuteNonQuery();
                }
                // Commit a la transacción
                transaccion.Commit();
            }
            return registrosafectados;
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
        }

    }
         
    public void Dispose()
    {
        if (_Conexion != null)
            _Conexion.Close();
    }

     
}

