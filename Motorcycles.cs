using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palautusClassInheritance
{
    internal class Motorcycles : Vehicle
    {
        string safe = "";
        public void PutHelmetOn() //komento tarkistaa ensin onko kypärä päällä, jos on niin huomauttaa sen olevan jo päällä.
                                  // jos kypärä ei ole päällä, niin laittaa kypärän päälle ja muuttaa safe arvoa.
                                  // safe arvoa voisi käyttää vaikka, jos ohjelmassa olisi vaikka törmäys tapahtuma.
                                  // silloin tosin voisi laittaa 2 arvoa muuttumaan, jossa toinen on kypärä ja toinen safe
        {

            if (safe == "yes")  
            {
                Console.WriteLine("You already have a helmet on! You won't get anymore safe wearing several helmets on");
            }
            else
            {
                Console.WriteLine("You put your cool looking helmet on");
                safe = "yes";
            }
            

        }
        public void TakeHelmetOff()
        {
            
            if (safe == "yes")
            {
                Console.WriteLine("You take off your helmet");
                safe = "no";
            }
            else
            {
                Console.WriteLine("You can't take something off if you don't have it on yet!");
            }

        }

        public Motorcycles(string aColor, string aManufacturer, int aGasLevel) : base(aColor, aManufacturer, aGasLevel)
        {

        }
        

        
    }
}
