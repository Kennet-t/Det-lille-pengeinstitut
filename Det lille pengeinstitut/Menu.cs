using System;
using System.Collections.Generic;
using System.Text;

namespace Det_lille_pengeinstitut
{
    class Menu
    {
        //==================================================================================================================================================
       // |                                                       UI til den viste Menu                                                                    |
      //  ==================================================================================================================================================

        public string TheMenu()
        {
            while (true) //Starter en while lykke som køre uendeligt, eller indtil den bliver brudt med en "break" eller ved at kalde en funktion
            {
                //En række tekst som er user interface for menuen
                Console.WriteLine("1 ) Opret kunde\n");
                Console.WriteLine("2 ) Opret konto\n");
                Console.WriteLine("3 ) Vis en kunde og deres konto/kontier\n");
                Console.WriteLine("4 ) Indsæt eller hæv penge på en specifik konto\n");
                Console.WriteLine("5 ) Slet kunde\n");
                Console.WriteLine("6 ) Slet konti\n");
                Console.WriteLine("7 ) C# samlet kapital for banken\n");
                Console.WriteLine("8 ) Luk programmet \n");
                Console.WriteLine("----------------------------------------------------\n");
                Console.Write("Indtast nummeret til den ønskede menu : ");
                string Indtastning = Console.ReadLine(); //Gemmer den indtastede værdi fra ovenstående menu i "Indtastning" 
                Console.Write("\n");

        //==================================================================================================================================================
       // |                                                      Indtastnings værdier til menu                                                             |
      //  ==================================================================================================================================================

                // Den if sætning køre hvis der indtastes 1-8 og returnere værdien "Indtastning"
                if (Indtastning == "1" || Indtastning == "2" || Indtastning == "3" || Indtastning == "4" || Indtastning == "5" || Indtastning == "6" || Indtastning == "7" || Indtastning == "8")
                {
                    return Indtastning;
                }
                else //Hvis der indtastes andet end 1-8 printes nedenstående tekst. Der brydes derved ikke ud af while lykken og den køre igen. 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du har indtastet et nummer som ikke er i menuen, prøv igen\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                }                    
            }
        }
    }
}
