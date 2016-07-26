using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmdb
{
    class NS
    {
        // Campos

        string _titulo;
        string _anio;
        int _id;
        int _reseniada;
        string _url;

        // Propiedades

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Anio
        {
            get { return _anio; }
            set
            {
                if (value.Length == 4)
                    _anio = value;
            }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Reseniada
        {
            get { return _reseniada; }
            set { _reseniada = value; }
        }

        public string URL
        {
            get { return _url; }
            set { _url = value; }
        }

    }
}
