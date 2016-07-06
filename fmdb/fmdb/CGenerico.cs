using System.Windows.Input;
using System;

namespace WPF_Canciones
{
    class ComandoGenerico : ICommand
    {

        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public ComandoGenerico(Action<object> execute, Func<object, bool> canExecute)
        {
            this._canExecute = canExecute;
            this._execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
