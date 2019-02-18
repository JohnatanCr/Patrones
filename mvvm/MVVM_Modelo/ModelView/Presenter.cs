using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Modelo.Model;

namespace MVVM_Modelo.ModelView
{
    public class Presenter : MasterVM
    {
        private readonly TextoCon _textoCon = new TextoCon( text=>text.ToUpper() );

        private string _inputText;

        private readonly ObservableCollection<string> _historial = new ObservableCollection<string>();

        public string InputText
        {
            get { return _inputText; }
            set
            {
                _inputText = value;
                RaisePropertyChangedEvent("InputText");
            }
        }

        public IEnumerable<string> Historial
        {
            get { return _historial; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        private void ConvertText()
        {
            if (string.IsNullOrWhiteSpace(InputText)) return;
            AddToHistory(_textoCon.ConvertText(InputText));
            InputText = string.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!_historial.Contains(item))
                _historial.Add(item);
        }
    }
}

