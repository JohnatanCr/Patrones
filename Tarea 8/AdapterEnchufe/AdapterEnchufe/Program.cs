using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEnchufe
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IEnchufeIngles enchufe = new EnchufeBritanico();
            //Taladro taladro = new Taladro(enchufe);

            //taladro.Encender();
            //Console.ReadLine();

            IEnchufeEuropeo enchufeEuropeo = new EnchufeEspanol();

            IEnchufeIngles adaptador = new AdapterInglesEuropeo(enchufeEuropeo);

            Taladro taladro = new Taladro(adaptador);

            taladro.Encender();
            

        }
    }
}
