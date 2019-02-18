using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Modelo.Model
{
    class TextoCon
    {
        private readonly Func<string, string> _conversion;

        public TextoCon(Func<string, string> conversion)
        {
            _conversion = conversion;
        }

        public string ConvertText(string Texto)
        {
            return _conversion(Texto);
        }
    }
}

