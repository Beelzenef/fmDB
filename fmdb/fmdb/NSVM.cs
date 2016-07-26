using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmdb
{
    class NSVM : INotifyPropertyChanged
    {
        #region Campos e instancias

        private NS _pelicula;
        private DAO _dao;

        #endregion

        #region Constructor

        public NSVM()
        {
            _pelicula = new NS
            {
                Titulo = "???",
                Anio = "???",
                URL = "???"
            };
        }

        #endregion

        #region Propiedades

        public string Titulo
        {
            get { return _pelicula.Titulo; }
            set
            {
                if (_pelicula.Titulo != value)
                { _pelicula.Titulo = value;
                    NotificarCambiosEnPropiedad("Titulo");
                }
            }
        }

        public string Anio
        {
            get { return _pelicula.Anio; }
            set
            {
                if (_pelicula.Anio != value)
                {
                    _pelicula.Anio = value;
                    NotificarCambiosEnPropiedad("Titulo");
                }
            }
        }

        public string URL
        {
            get { return _pelicula.URL; }
            set
            {
                if (_pelicula.URL != value)
                {
                    if (value.EndsWith("wordpress.com"))
                    {
                        _pelicula.URL = value;
                        NotificarCambiosEnPropiedad("URL");
                    }
                }
            }
        }

        public int Reseniada
        {
            get { return _pelicula.Reseniada; }
            set
            {
                if (_pelicula.Reseniada != value)
                {
                    _pelicula.Reseniada = value;
                    NotificarCambiosEnPropiedad("Reseniada");
                }
            }
        }

        #endregion

        #region Metodos

        #endregion

        #region Comandos

        #endregion

        #region Manejador y metodo para notificacion de cambios en las propiedades

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotificarCambiosEnPropiedad(string propiead)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propiead));
        }

        #endregion

    }
}
