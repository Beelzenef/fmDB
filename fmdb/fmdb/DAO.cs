using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace fmdb
{
    class DAO
    {
        public SQLiteConnection conn;
        string cadenaConexion = "Data Source=" + "filmdb.db" + ";Version=3;" + "FailIfMissing=true;";

        public bool Conectar()
        {
            try
            {
                conn = new SQLiteConnection(cadenaConexion);
                conn.Open();
                return true;
            }
            catch (SQLiteException e)
            {
                throw new Exception("Error de conexion: " + e.Data);
            }
        }

        public void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (SQLiteException)
            {
                throw;
            }
        }

        public bool Conectado()
        {
            if (conn != null)
                return conn.State == System.Data.ConnectionState.Open;
            else
                return false;
        }

        public int Insertar(NS unNS)
        {
            string comando;

            if (unNS != null)
            {
                comando = "insert into peliculas (titulo, anio, genero, reseniada, url, valoracion) values ('" +
                        unNS.Titulo + "', '" +
                        unNS.Anio + "', '" +
                        unNS.Genero + "', " +
                        unNS.Reseniada.ToString() + ", '" +
                        unNS.URL + "', " +
                        unNS.Valoracion.ToString() + ")";
                SQLiteCommand cmdEjecutando = new SQLiteCommand(comando, conn);
                return cmdEjecutando.ExecuteNonQuery();
            }
            else
                return 0;
        }
    }
}
