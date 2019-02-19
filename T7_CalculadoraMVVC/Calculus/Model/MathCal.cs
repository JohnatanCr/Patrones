using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus.Model
{
    public class MathCal
    {
        private char var1;
        private char var2;

        public MathCal(char var1, char var2)
        {
            this.var1 = var1;
            this.var2 = var2;
        }
        public MathCal(): this('0', '0')
        { }
        
    }

}
