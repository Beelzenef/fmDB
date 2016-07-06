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

        #endregion

        #region Propiedades

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
