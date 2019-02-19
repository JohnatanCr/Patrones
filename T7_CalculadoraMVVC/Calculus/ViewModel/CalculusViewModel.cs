using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Calculus.Model;

namespace Calculus.ViewModel
{
    class CalculusViewModel : ObservableObject
    {
        private MathCal Calc = new MathCal();
        public string calcText { get; set; }



        public ICommand _AddCalcText
        {
            get { return new DelegateCommand(AddCalcText); }
        }
    
        private void AddCalcText()
        {
            
            calcText = "ASDSADS";
            MessageBox.Show("succed");
        }
    }
}

