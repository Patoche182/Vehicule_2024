using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine_2024.Object
{
    public class Moto : Vehicule
    {
        public Moto()
        {
            Console.WriteLine("Création d'une moto");
            Console.WriteLine("-------------------");
        }

        public override void Accelerer()
        {
            Console.WriteLine("La moto accélère.");
        }
    }
}
