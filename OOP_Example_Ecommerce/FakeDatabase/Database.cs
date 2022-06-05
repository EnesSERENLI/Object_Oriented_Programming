using OOP_Example_Ecommerce.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_Ecommerce.FakeDatabase
{
    public class Database
    {
        //Ekrankartı
        public static List<EkranKarti> ekranKartiListesi = new List<EkranKarti>() 
        { 
            new EkranKarti("GForce RTX 3060", 12000), 
            new EkranKarti("GForce RTX 3060 Ti", 12500), 
            new EkranKarti("GForce RTX 3080", 15000),
            new EkranKarti("GForce RTX 3080 Ti", 15000)
        };

        //Bilgisayar
        public static List<Computer> computerList = new List<Computer>() 
        { 
            new Computer("Monster", "Abra", 14000), 
            new Computer("Monster", "Tulpar", 20000), 
            new Computer("Monster", "Semruk", 50000),
            new Computer("MSI", "Modern", 11000),
            new Computer("MSI", "Bravo", 14500), 
            new Computer("MSI", "Katana", 26000), 
            new Computer("Asus", "Vivobook", 20000), 
            new Computer("Asus", "TUF", 14000),
            new Computer("Asus", "ROG Zephyrus", 19200), };

        //RAM
        public static List<RAM> ramListesi = new List<RAM>() 
        { 
            new RAM("4 GB", 500),
            new RAM("6 GB", 1000), 
            new RAM("8 GB", 2000)
        };

        //ErkekGiyim
        public static List<Giyim> erkekGiyimListesi = new List<Giyim>() 
        { 
            new Giyim("Tişört", "Mavi", 30),
            new Giyim("Tişört", "Koton", 20), 
            new Giyim("Tişört", "Nike", 70),
            new Giyim("Gömlek", "AltınYıldız", 120),
            new Giyim("Gömlek", "Mavi", 100),
            new Giyim("Gömlek", "Pierre Cardin", 150), 
            new Giyim("Gömlek", "US Polo Assn", 105),
            new Giyim("Pantolon", "Colin's", 110),
            new Giyim("Pantolon", "LC Waikiki", 70), 
            new Giyim("Pantolon", "Hummel", 100), 
            new Giyim("Mont", "Avva", 400), 
            new Giyim("Mont", "LTB", 350), 
            new Giyim("Mont", "Adidas", 750), 
            new Giyim("Kazak", "Kiğılı", 250), 
            new Giyim("Kazak", "Loft", 125), 
            new Giyim("Kazak", "Süvari", 200)
        };

        //Kadın Giyim
        public static List<Giyim> kadinGiyimListesi = new List<Giyim>() 
        { 
            new Giyim("Elbise", "Mango", 120), 
            new Giyim("Elbise", "Eyyo", 150),
            new Giyim("Elbise", "Lafaba", 100),
            new Giyim("Elbise", "Armine", 250),
            new Giyim("Bluz", "Erliva", 88),
            new Giyim("Bluz", "Olalook", 140),
            new Giyim("Bluz", "Stealla Pulvis", 105),
            new Giyim("Pantolon", "Big Love", 170), 
            new Giyim("Pantolon", "SHEISMONO", 165),
            new Giyim("Pantolon", "Dilvin", 234), 
            new Giyim("Etek", "Soyo", 138), 
            new Giyim("Etek", "Fulvia", 212), 
            new Giyim("Etek", "Societa", 125),
            new Giyim("Mont", "Rouge", 3000),
            new Giyim("Mont", "Barbour", 4500),
            new Giyim("Mont", "Network", 7000) };
    }
}
