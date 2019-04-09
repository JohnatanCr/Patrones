using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEnchufe
{
    public class Taladro
    {
        private IEnchufeIngles enchufe;

        public Taladro(IEnchufeIngles enchufeTaladro)
        {
            this.enchufe = enchufeTaladro;
        } 

        public void Encender()
        {
            int[] voltaje100ms = enchufe.Flujo110V();

            for (int i = 0; i < voltaje100ms.Length; i++)
                Console.WriteLine("El taladro esta funcionando con voltaje de " + voltaje100ms[i] + " Voltios");
        }
    }

    
}
