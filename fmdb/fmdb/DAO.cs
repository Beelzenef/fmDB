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
        string cadenaConexion = "Data Source=" + "filmdb.db" + ";Version=3;" + "FailMissing=true;";

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
    }
}
