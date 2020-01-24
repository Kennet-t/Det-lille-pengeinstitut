using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; //Et ekstra bibliotek vi har tilføjet til at kunne lave vores Thread kommando, så der går x antal tid før næste kommando køres.


namespace Det_lille_pengeinstitut
{
    class Luk_programmet
    {
        public void Exit()
        {
            int e;
            Console.ForegroundColor = ConsoleColor.Red;
            //En for lykke som udskriver Exiting og tilføjer et "." hvert 100 ms. 
            Console.Write("Exiting"); 
            for (e = 1; e < 15; e++)
            {
                Thread.Sleep(100); //Venter 100 ms mens den skriver et "." 15 gange.
                Console.Write(".");
            }
            Thread.Sleep(100); //Venter 100 ms og derefter lukker den console
            Environment.Exit(-1);
        }
    }
}
