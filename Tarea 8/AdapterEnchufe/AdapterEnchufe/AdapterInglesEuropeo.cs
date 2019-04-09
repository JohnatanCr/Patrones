using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEnchufe
{
    public class AdapterInglesEuropeo : IEnchufeIngles
    {
        private IEnchufeEuropeo enchufe;

        public AdapterInglesEuropeo(IEnchufeEuropeo enchufe)
        {
            this.enchufe = enchufe;
        }

        #region IEnchufeIngles Members

        public int[] Flujo110V()
        {
            // Invocamos el método de la interfaz incompatible
            int[] voltajes220 = enchufe.Flujo220V();

            // Realizamos la adaptacion
            int[] voltajes110 = new int[voltajes220.Length];

            for (int i = 0; i < voltajes220.Length; i++)
                voltajes110[i] = (int)(voltajes220[i] / 2);

            // Devolvemos el resultado adaptado, que es el que espera el cliente
            return voltajes110;
        }

        public int getNumeroBornes()
        {
            return enchufe.getNumeroBornes() - 1;
        }
        #endregion
    }
}
