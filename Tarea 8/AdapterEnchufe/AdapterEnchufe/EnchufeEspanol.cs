using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEnchufe
{
    public class EnchufeEspanol : IEnchufeEuropeo
    {
        #region IEnchufeEuropeo Members
        public int[] Flujo220V()
        {
            int[] arrayFlujo = new int[100];
            Random r = new Random();
            for (int i = 0; i < arrayFlujo.Length; i++)
            {
                // Calculamos la fluctuacion del voltaje
                int fluctuacion = r.Next(100) > 50 ? 1 : -1;    // Positiva o negativa
                fluctuacion = fluctuacion * (r.Next(10) + 1);    // El valor fluctuara entre -0 y +10

                // Valor total entre 210 y 230V
                arrayFlujo[i] = fluctuacion + 220;
            }

            return arrayFlujo;
        }

        public int getNumeroBornes()
        {
            return 2;
        }
        #endregion
    }
}
