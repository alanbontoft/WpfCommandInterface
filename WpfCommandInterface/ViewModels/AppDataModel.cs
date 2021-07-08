using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfCommandInterface.ViewModels.Commands;

namespace WpfCommandInterface.ViewModels
{
    public class AppDataModel : ObservableObject
    {

        private string _editText;

        public RelayCommand SimpleCommand { get; private set; }
        public RelayCommand ParamCommand { get; private set; }

        public AppDataModel()
        {
            LabelText = "Test";

            SimpleCommand = new RelayCommand(ChangeLabelText);

            ParamCommand = new RelayCommand(ChangeLabelTextWithParam, CanParamCommandExecute);
        }

        public string LabelText { get; set; }

        public string EditText
        {
            get { return _editText; }

            set
            {
                if (value != _editText)
                {
                    _editText = value;
                    OnPropertyChanged("EditText");
                }
            }
        }

        public bool CanParamCommandExecute(object obj)
        {
            if (obj == null) return false;

            var s = obj as string;

            if (string.IsNullOrEmpty(s)) return false;

            return true;
        }

        public void ChangeLabelText(object obj)
        {
            LabelText = EditText;
            OnPropertyChanged("LabelText");
        }

        public void ChangeLabelTextWithParam(object obj)
        {
            LabelText = obj as string;
            OnPropertyChanged("LabelText");
        }
    }
}
