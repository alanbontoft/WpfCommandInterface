using System;
using System.Windows.Input;

namespace WpfCommandInterface.ViewModels.Commands
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _action;
        readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> action, Predicate<object> canExecute)
        {
            if (action == null) throw new NullReferenceException("action");

            _action = action;
            _canExecute = canExecute;
        }

        public RelayCommand(Action<object> action) : this(action, null)
        {
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return (_canExecute == null) ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _action?.Invoke(parameter);
        }
    }
}
