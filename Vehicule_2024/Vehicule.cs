using System;
using Usine_2024.Object;


public class MainUsine
{
    static void Main(string[] args)
    {
        Usine usine = new Usine();

        List<Vehicule> l = new List<Vehicule>();
        l.Add(usine.FabriquerVehicule(2));
        l.Add(usine.FabriquerVehicule(4));
        l.Add(usine.FabriquerVehicule(6));
        l.Add(usine.FabriquerVehicule(8));

        foreach (Vehicule v in l)
        {
            v.Accelerer();
            v.Freiner();
        }
        //moto.Accelerer();
        //moto.Freiner();

        //auto.Accelerer();
        //auto.Freiner();

        //pickup.Accelerer();
        //pickup.Freiner();

        //camion.Accelerer();
        //camion.Freiner();

    }
}

namespace Usine_2024.Object
{
    public class Vehicule
    {

        public Vehicule()
        {
            Console.WriteLine("Création d'un véhicule allééééééé");
            Console.WriteLine("-------------------");
        }

        public virtual void Freiner() // Changement de la méthode en virtual pour permettre l'override dans les classes dérivées
        {
            Console.WriteLine("Le véhicule freine.");
            //Console.WriteLine($"Le véhicule {Vehicule.GetType().Name} freine.");
        }

        public virtual void Accelerer() // Changement de la méthode en virtual pour permettre l'override dans les classes dérivées
        {
            Console.WriteLine("Le véhicule accélère.");
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