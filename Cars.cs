using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palautusClassInheritance
{
    internal class Cars : Vehicle
    {

        
        public void OpenWindow()
        {
            
            // Console.ForegroundColor = ConsoleColor.Cyan; jos tahdot antaa tekstille väriä, ConsoleColor komento muuttaa  väriä, esim cyan laittaa turkoosin.
            // Foreground muuttaa itse tekstin väriä. backgroundcolor muuttaa tekstin pohjan elikkä "tyhjän" ruudun tekstin takana.                                         
            Console.WriteLine("Opened car window");
            Console.WriteLine("Some fresh air will help");
            //Console.ResetColor(); //jos vaihdoit tekstin väriä, niin kannattaa resetoida se käytön jälkeen. 
        }
        public void CloseWindow()
        {
            Console.WriteLine("You close the window");
        }
        public void OpenRadio()
        {
            Console.WriteLine("Radio turned on");
            Console.WriteLine("Time for relaxing jazz");

        }
        public void CloseRadio()
        {
            Console.WriteLine("You close the radio");
        }
        public Cars(string aColor, string aManufacturer, int aGasLevel) : base(aColor, aManufacturer, aGasLevel)
        {
            //color = aColor;
            //manufacturer = aManufacturer;
            //gasLevel = aGasLevel;     muistutus itselleni.  esim aColor on lyhyt argumentColor, harjoitusvideossa käytettiin esim alaviivaa argumentin edessä
            //this.testi = testi;
        }

        
        
        }

        class eCar : Cars
    {
        public eCar(string aColor, string aManufacturer, int aGasLevel) : base(aColor, aManufacturer, aGasLevel)
        {


        }

        public override void Drive()  //override komennolla saadaan muutettua komentoa tätä luokkaa varten.
                                      // python esimerkissä opetusvideossa sähköautolle annettiin loputon virta poistamalla vähennys komento, jätin itse sen tähän ohjelmaan.
                                      // teksti on kuitenkin muutettu ja testattu vaihtuvan.
        
        {
            Console.WriteLine($"{color} {manufacturer}");
            if (gasLevel >= 1)
            {

                Console.WriteLine($"You drive and the engine goes ssshhhhhh!\nCurrent charge left = {gasLevel}");
                Console.WriteLine("Do you want to keep driving? Yes (y) No (Any other button)");
                gasLevel--;
                if (Console.ReadLine() == "y")
                {
                    Drive();
                }
                else
                {
                    Console.WriteLine("You stopped driving");
                }

            }
            else if (gasLevel == 0)
            {

                Console.WriteLine("You run out of charge and engine goes silent :(");
            }

        }
       
        
    }
    
    
}
    


        

