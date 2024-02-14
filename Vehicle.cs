using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palautusClassInheritance
{
    internal class Vehicle
    {

        public string color { get; set; }
        public string manufacturer { get; set; }
        public int gasLevel { get; set; }
        
        
        //public string color;
        //public string manufacturer;  
        //public int gasLevel;

        public Vehicle()   //Tyhjä, joten perivillä luokilla voi olla eri määrä ominaisuuksia.
        {

        }

        public Vehicle(string aColor, string aManufacturer, int aGasLevel) // harjoituksen olennainen kohta, tämä on pääluokka, josta tulevat luokat kopioi.
        {
            color = aColor;
            manufacturer = aManufacturer;       // argumentit ohjelmalle. 
            gasLevel = aGasLevel;
        }
        public virtual void Drive()  //virtual, että pystyy käyttämään override komentoa eri luokissa
        {

            Console.WriteLine($"{color} {manufacturer}");  //kirjoittaa ensin ajoneuvon värin ja valmistajan
            if (gasLevel >= 1)                             // ohjelma ensin tarkistaa onko tarpeeksi polttoainetta, sitten kirjoittaa tekstin ja vähentää polttoaineen määrää yhdellä
            { 
                
                Console.WriteLine($"You drive and the engine goes VROOOOM!\nCurrent gas level is {gasLevel}");
                Console.WriteLine("Do you want to keep driving? Yes (y) No (Any other button)");
                gasLevel--;
                if (Console.ReadLine() == "y")     // yksinkertainen tarkistus, jos kirjoittaa y niin toistaa komennon, muussa tapauksessa kirjoittaa "You stopped driving"
                {
                    Drive();
                } 
                else
                {
                    Console.WriteLine("You stopped driving");
                }

            }
            else if (gasLevel == 0) // jos gaslevel == 0 aloittaessa, tai kun ajaa tarpeeksi niin ilmoittaa polttoaineen loppuneen. 
            {

                Console.WriteLine("You are out of gas and engine sputters :(");
            }
            
        
        }
    }
}
