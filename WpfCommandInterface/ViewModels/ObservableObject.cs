using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfCommandInterface.ViewModels
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Command : ICommand
	{
	    private readonly Action<object> _action;
	
	    public event EventHandler CanExecuteChanged { add { } remove { } }
	
	    public Command(Action<object> action)
	    {
	        _action = action;
	    }
	
	    public bool CanExecute(object parameter) => true;
	
	    public void Execute(object parameter)
	    {
	        _action?.Invoke(parameter);
	    }
    }

}
