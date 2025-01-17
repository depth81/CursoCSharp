﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class MetodosCRUDRuta
    {

        //Crear tipo comando INSERT
        public static SqlCommand CrearComandoProcAlmacInsert_ruta()
        {

            //Conectarse a la BD. Método estático. NO necesito instanciar la clase previamente para usarlo.
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addruta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }

        //Ejecutar el tipo de comando INSERT
        public static int EjecutarComandoProcAlmacInsert_ruta(SqlCommand comando)
        {

            try
            {

                comando.Connection.Open();

                return comando.ExecuteNonQuery();

            }
            catch
            {

                throw;

            }
            finally
            {

                comando.Connection.Dispose();

                comando.Connection.Close();

            }

        }

        //Crear tipo comando SELECT
        public static SqlCommand CrearComandoSelect_ruta()
        {

            //Conectarse a la BD. Método estático. NO necesito instanciar la clase previamente para usarlo.
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();

            _conexion.ConnectionString = _cadenaConexion;

            //Crear la instruccion SELECT
            SqlCommand _comando = new SqlCommand();

            //Tipo de comando que se debe crear
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;

            return _comando;

        }

        //Ejecutar el tipo de comando SELECT
        public static DataTable EjecutarComandoSelect_ruta(SqlCommand comando)
        {

            DataTable _table = new DataTable();

            try
            {

                comando.Connection.Open();

                //"Adaptador" es un comando que convierte los registros que vienen de la tabla a un formato visible en las vistas.
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = comando;

                //Llevar los datos a la tabla (_table)
                adapter.Fill(_table);


            }
            catch (Exception Ex) { throw Ex; }
            finally { comando.Connection.Close(); }

            return _table;

        }

        //Crear tipo comando UPDATE
        public static SqlCommand CrearComandoProcAlmacUpdate_ruta()
        {

            //Conectarse a la BD. Método estático. NO necesito instanciar la clase previamente para usarlo.
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateRuta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }

        //Ejecutar el tipo de comando UPDATE
        public static int EjecutarComandoProcAlmacUpdate_ruta(SqlCommand comando)
        {

            try
            {

                comando.Connection.Open();

                return comando.ExecuteNonQuery();

            }
            catch { throw; }

            finally
            {

                comando.Connection.Dispose();

                comando.Connection.Close();

            }

        }

        //Crear tipo comando DELETE
        public static SqlCommand CrearComandoProcAlmacDelete_ruta()
        {

            //Conectarse a la BD. Método estático. NO necesito instanciar la clase previamente para usarlo.
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteRuta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }

        //Ejecutar el tipo de comando DELETE
        public static int EjecutarComandoProcAlmacDelete_ruta(SqlCommand comando)
        {

            try
            {

                comando.Connection.Open();

                return comando.ExecuteNonQuery();

            }
            catch { throw; }

            finally
            {

                comando.Connection.Dispose();

                comando.Connection.Close();

            }

        }

    }
}
