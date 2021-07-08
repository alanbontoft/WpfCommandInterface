using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCommandInterface.ViewModels.Commands
{
    public class SimpleCommand : Command
    {

        public SimpleCommand(Action<object> action) : base(action)
        {

        }

    }
}
