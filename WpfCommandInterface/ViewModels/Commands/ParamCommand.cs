using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCommandInterface.ViewModels.Commands
{
    public class ParamCommand : Command
    {

        public ParamCommand(Action<object> action) : base (action)
        {

        }

    }
}
