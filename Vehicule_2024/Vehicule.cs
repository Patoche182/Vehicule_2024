using System;
using Usine_2024.Object;

namespace Vehicule_2024
{
    public class Vehicule
    {
        static void Main(string[] args)
        {
            Usine usine = new Usine();
            Vehicule moto = usine.FabriquerVehicule(2);
            Vehicule auto = usine.FabriquerVehicule(4);
            Vehicule pickup = usine.FabriquerVehicule(6);
            Vehicule camion = usine.FabriquerVehicule(8);

            moto.Accelerer();
            moto.Freiner();

            auto.Accelerer();
            auto.Freiner();

            pickup.Accelerer();
            pickup.Freiner();

            camion.Accelerer();
            camion.Freiner();
        }

        public virtual void Freiner() // Changement de la méthode en virtual pour permettre l'override dans les classes dérivées
        {
            Console.WriteLine("Le véhicule freine.");
            //Console.WriteLine($"Le véhicule {Vehicule.GetType().Name} freine.");
        }

        public virtual void Accelerer() // Changement de la méthode en virtual pour permettre l'override dans les classes dérivées
        {
            Console.WriteLine("Le véhicule accélère."); ;
        }
    }

    public class Usine
    {
        public Vehicule FabriquerVehicule(int nombreRoues)
        {
            switch (nombreRoues)
            {
                case 2:
                    return new Moto();
                case 4:
                    return new Auto();
                case 6:
                    return new PickUp();
                case 8:
                    return new Camion();
                default:
                    throw new ArgumentException("Vehicule inconnu.");
            }
        }
    }
}