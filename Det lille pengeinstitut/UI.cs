using System;
using System.Collections.Generic;
using System.Text;

namespace Det_lille_pengeinstitut
{
    class UI
    {
        //==================================================================================================================================================
       // |                                                       UI VIL DU LUKKE PROGRAMMET                                                               |
      //  ==================================================================================================================================================

        public void Wannaexit()
        {
            //Ved indtastning af "y" køres class Exit. Ved tryk på n ledes du til menuen igen. Class menu. 
            Console.WriteLine("Vil du lukke programmet, eller tilbage til menuen? ");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("[ y ] = Luk programmet || [ n ] = Tilbage til menuen y/n : ");
            string s = Console.ReadLine();

            if (s == "Y" || s == "y")
            {
                Luk_programmet sluk = new Luk_programmet();
                sluk.Exit();
            }
            else
            { //Return to menu
                Console.Write("\n");
            }
        }

        //==================================================================================================================================================
       // |                                                         UI til Oprettelse af kunde                                                             |
      //  ==================================================================================================================================================

        public void Kundeoprettelse(Bank b)
        {
            string ifnavn, ienavn, iadr, itlf, icpr, ikn;

            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("Opret ny kunde: ");
            Console.WriteLine("----------------------------------------------------\n");

            while (true)
            {
                while (true)
                {
                    Console.Write("Indtast kundens kunde nummer 4 tal (xxxx) : ");
                    ikn = Console.ReadLine();

                    int knLength = ikn.Length;

                    if (knLength == 4)
                    {
                        Console.Write("\n");
                        break;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Det indtastede kundenummer er ugyldigt, prøv igen");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write("Indtast kundens fornavn : ");
                ifnavn = Console.ReadLine();
                Console.Write("Indtast kundens efternavn : ");
                ienavn = Console.ReadLine();
                Console.Write("Indtast kundens adresse : ");
                iadr = Console.ReadLine();
                while (true)
                {
                    Console.Write("Indtast kundens telefon nummer : ");
                    itlf = Console.ReadLine();

                    int tlfLength = itlf.Length;

                    if (tlfLength == 8)
                    {
                        Console.Write("\n");
                        break;
                    }
                    else
                        Console.WriteLine("Det indtastede telefonnummer er ugyldigt, prøv igen");
                }
                while (true)
                {
                    Console.Write("Indtast kundens cpr nummer (xxxxxx-xxxx) : ");
                    icpr = Console.ReadLine();

                    int cprLength = icpr.Length;

                    if (cprLength == 11
                        )
                    {
                        Console.Write("\n");
                        break;
                    }
                    else
                        Console.WriteLine("Det indtastede CPR nummer er ugyldigt, prøv igen");
                }



                b.AddKunde(ikn, ifnavn, ienavn, iadr, itlf, icpr);

                Console.WriteLine("Kunde oprettet");
                Console.WriteLine("----------------------------------------------------\n");
                Console.Write("Ønsker du at oprette en kunde mere? y/n : ");
                string nyk = Console.ReadLine();

                if (nyk == "N" || nyk == "n")
                {
                    Wannaexit(); //Køre wanna exit funktionen
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                }
            }
        }

       //==================================================================================================================================================
      // |                                                        UI til Oprettelse af konto                                                              |
     //  ==================================================================================================================================================

        public void Kontooprettelse(Bank b)
        {
            double isld;
            string iknr, irgnr, iknn, ikundenum, ikontitype, irente, uei;

            {

                Console.Clear();
                Console.Write("\n");
                Console.WriteLine("Opret ny konto: ");
                Console.WriteLine("----------------------------------------------------\n");

                while (true)
                {

                    Console.WriteLine("Hvilken type konto vil du oprette? Indlån eller Udlån");
                    Console.Write("Tryk [ I ] for Indlån eller [ U ] for udlån : \n");
                    uei = Console.ReadLine();

                    if (uei == "i" || uei == "I")
                    {
                        ikontitype = "Indlån";
                    }
                    else if (uei == "u" || uei == "U")
                    {
                        ikontitype = "Udlån";
                    }
                    else
                    {
                        ikontitype = "Ikke bestemt";
                    }

                    Console.Write("Indtast kundens nuværende saldo : ");
                    isld = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Indtast navnet til kontoen: ");
                    iknn = Console.ReadLine();
                    Console.Write("Indtast registreringsnummer til kontoen : ");
                    irgnr = Console.ReadLine();
                    while (true)
                    {
                        Console.Write("Indtast kontonummer til kontoen (xxxxxx)  : ");
                        iknr = Console.ReadLine();

                        int iknrLength = iknr.Length;

                        if (iknrLength == 6)
                        {
                            Console.Write("\n");
                            break;
                        }
                        else
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Det indtastede identificeringsnummeret er ugyldigt, prøv igen");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("Indtast kontohaverens kontonummer : ");
                    ikundenum = Console.ReadLine();
                    Console.Write("Indtast kontoens rentesats : ");
                    irente = Console.ReadLine();

                    b.AddKonti(isld, iknr, irgnr, iknn, ikundenum, ikontitype, irente);
                    
                    Console.WriteLine("Kontoen er oprettet.");
                    Console.WriteLine("----------------------------------------------------\n");
                    Console.Write("Ønsker du at oprette en konto mere? y/n : ");
                    string nko = Console.ReadLine();

                    if (nko == "N" || nko == "n")
                    {
                        Wannaexit(); //Køre wanna exit funktionen
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
        }

    }
}