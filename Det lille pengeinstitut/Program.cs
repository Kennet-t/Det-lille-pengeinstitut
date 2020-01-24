using System;

namespace Det_lille_pengeinstitut
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green; //Ændre tekstfarve til grøn

            Bank DLP = new Bank(); //Laver nye object fra classen bank ved navnet DLP

            DLP.AddKunde("1337", "Admin", "Adminsen", "Odense", "69696969", "123456-1234"); //Fylder informationerne ind i kunderne arrayet via funktionen AddKunde i objectet DLP
            DLP.AddKunde("1338", "Anders", "Hansen", "Åparken 1. 1, 5800 Nyborg", "42912068", "03119416-1111");
            DLP.AddKunde("1339", "Kennet", "Thorsen", "Heliosvænget 30", "30618850", "01041993-2222");

            DLP.AddKonti(6000000.82, "1", "1", "Banken", "1337", "Indlån", "0%"); //Fylder informationerne ind i konti arrayet via funktionen AddKonti i objectet DLP
            DLP.AddKonti(25000, "111111", "5500", "Løn konto","1337","Indlån", "0,3%");
            DLP.AddKonti(35610.50, "222222", "6500", "Budget konto", "1338", "Indlån", "0,6%");
            DLP.AddKonti(-57441, "444444", "6501", "Bil lån", "1338", "Udlån", "1,3%");
            DLP.AddKonti(25000, "333333", "5500", "Løn konto", "1339","Indlån", "0,2%");

            Console.WriteLine("Velkommen til Det Lille Pengeinstitut!");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Hvad vil du foretage dig? :\n");         

            Menu menu = new Menu(); //Laver nye object fra classen Menu ved navnet menu
            UI funk = new UI(); //Laver nye object fra classen UI ved navnet funk

            while (true) //Starter en while lykke som køre uendeligt, eller indtil den bliver brudt med en "break" eller ved at kalde en funktion
            {
                string Indtastning = menu.TheMenu(); //Henter indtastning fra Menu classes

                if (Indtastning == "1")
                { //Opret kunde
                    funk.Kundeoprettelse(DLP); //Kalder funktionen "Kundeoprettelse" ved indtastning af 1. (DLP) Gør at informationerne gemt i objectet DLP trækkes med over
                }
                else if (Indtastning == "2")
                { //Opret konti
                    funk.Kontooprettelse(DLP); //Kalder funktionen "Kundeoprettelse" ved indtastning af 2. (DLP) Gør at informationerne gemt i objectet DLP trækkes med over
                }
                else if (Indtastning == "3")
                { //Vis en kunde og deres kontier
                    DLP.Kundevis2(); //Kalder funktionen "Kundevis2" ved indtastning af 3
                }
                else if (Indtastning == "4")
                { //Indsæt eller hæv penge på en specifik konto
                    DLP.Indsætpenge(); //Kalder funktionen "Indsætpenge" ved indtastning af 4
                }
                else if (Indtastning == "5")
                { //Slet kunde
                    DLP.Sletkunde(); //Kalder funktionen "Sletkunde" ved indtastning af 5
                }
                else if (Indtastning == "6")
                { //Slet konti
                    DLP.Sletkonto(); //Kalder funktionen "Sletkonto" ved indtastning af 6
                }
                else if (Indtastning == "7")
                { //Samlet kapital
                    DLP.Samletkapital(); //Kalder funktionen "Samletkapital" ved indtastning af 7
                }
                else if (Indtastning == "8")
                { //Luk programmet
                    Luk_programmet k8 = new Luk_programmet(); //Kalder "Exit" funktionen som bruges til at lukke programmet, ved indtastning af 8
                    k8.Exit();
                }
            }
        }
    }
}