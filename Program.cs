namespace palautusClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Red", "Nissan", 4);
            eCar eCar1 = new eCar("White", "Nissan", 4);
            Motorcycles motorcycle1 = new Motorcycles("Black", "Yamaha", 4);

            Cars car1 = new Cars("Black", "Ford", 4);


            // ohjelman olisi voinut laitta yhteen ikkunaan tai vaikka kahteen, mutta ajattelin olevan helpompi, jos jokainen alue olisi jaettu aina omaan palaan.
            // Pääluokan olisi voinut tosin merkita selkeämmin

            //car1.Drive();   //tuplakomennot, niin voin helposti poistaa vain ekan parin testejä varten samalla kun pidän kommentit.
            //eCar1.Drive();  //eCar luokalla on eri drive komento, käyttäen override

            //motorcycle1.PutHelmetOn();
            //motorcycle1.PutHelmetOn();   //toiminto tuplana niin näkee, että ohjelma tarkistaa onko kypärä jo päällä ja vaihtuuko teksti

            //motorcycle1.TakeHelmetOff(); //sama idea kuin yllä  
            //motorcycle1.TakeHelmetOff(); //Ohjelmassa voisi olla hyvä koittaa try ja catch komentoja, jos käyttäjä tekee esim. kirjoitusvirheen tai koittaa käyttää eri luokan komentoja
                                           //kuten openwindow() moottoripyörällä 
            //eCar1.OpenWindow();

        }
    }
}
