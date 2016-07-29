using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace fmdb
{
    class NSVM : INotifyPropertyChanged
    {
        #region Campos e instancias

        private NS _pelicula;
        private DAO _dao;

        private string _mensajeInfo;

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

        public bool Conectado
        {
            get
            {
                if (_dao == null)
                    return false;
                else
                    return _dao.Conectado();
            }
        }

        public string ColorConexion
        {
            get
            {
                if (Conectado)
                    return "Green";
                else
                    return "Red";
            }
        }

        public string MensajeInfo
        {
            get { return _mensajeInfo; }
            set {
                if (_mensajeInfo != value)
                {
                    _mensajeInfo = value;
                    NotificarCambiosEnPropiedad("Mensaje");
                }
            }
        }

        #endregion

        #region Metodos

        public void Conectar()
        {
            _dao = null;
            try
            {
                _dao = new DAO();
                if (_dao.Conectar())
                    MensajeInfo = "Conexion exitosa";
            }
            catch (Exception e)
            {
                MensajeInfo = e.Message;
            }
            NotificarCambiosEnPropiedad("ColorConexion");
            NotificarCambiosEnPropiedad("MensajeInfo");
        }

        #endregion

        #region Comandos

        public ICommand btnConectar_Click
        {
            get
            {
                return new ComandoGenerico(o => Conectar(), o => true);
            }
        }

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
