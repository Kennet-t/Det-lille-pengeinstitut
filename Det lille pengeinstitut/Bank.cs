using System;
using System.Collections.Generic;
using System.Text;

namespace Det_lille_pengeinstitut
{
    class Bank
    {
        public Kunde[] kunderne = new Kunde[100];  //Opretter Array til kunder med 100 tabeller i sig
        public Opret_konti[] konti = new Opret_konti[100]; //Opretter Array til Konti med 100 tabeller i sig

        UI Returnhome = new UI(); //Objekt til at kunne kalde "Returnhome" som gør at vi kan gå tilbage til UI

        public Bank() //Bank constructor 
        {
        }

         //==================================================================================================================================================
        // |                                 UI til vores vil du lukke programmet eller tilbage til menuen                                                  |
       //  ==================================================================================================================================================

        public void AddKunde(string ikn, string ifnavn, string ienavn, string iadr, string itlf, string icpr)
        {
            Kunde kun = new Kunde(); //Oprettet nyt objekt til konto, her bliver værdierne sat
            kun.Setkn(ikn);
            kun.Setfnavn(ifnavn);
            kun.Setenavn(ienavn);
            kun.Setadr(iadr);
            kun.Settlf(itlf);
            kun.Setcpr(icpr);

            int p = FindEmpty(); // Indsætte værdierne fra "kun" på i det tomme felt fundet med "find empty"
            if (p != 999)
            {
                this.kunderne[p] = kun; 
            }
        }
        private int FindEmpty() //Finder det næste tomme felt i arrayet 
        {
            for (int a = 0; a < 100; a++)
            {
                if (kunderne[a] == null)
                    return a; //Det tomme felt gemmes i "a"
            }
            return 999;
        }

        //==================================================================================================================================================
       // |                                              Kode der bruges når man opretter en ny konti, sætter de indtastede værdier                        |
      //  ==================================================================================================================================================

        public void AddKonti(double isld, string iknr, string irgnr, string iknn, string ikundenum, string ikontitype, string irente)
        {
            Opret_konti kon = new Opret_konti(); //Oprettet nyt objekt til konti, bliver der værdierne sat
            kon.Setsaldo(isld);
            kon.Setkontonr(iknr);
            kon.Setregnr(irgnr);
            kon.Setkontonavn(iknn);
            kon.Setkundenummer(ikundenum);
            kon.Setkontitype(ikontitype);
            kon.Setrente(irente);

            int p = FindEmptyKonti(); //p bruges til at finde en tom plads i Arrayen Konti, hvis p ikke er det samme som 999
            if (p != 999)
            {
                this.konti[p] = kon;
                //Console.WriteLine("Dette er værdien p {0} ", p);
            }
        }
        private int FindEmptyKonti() //Sætter værdierne ind på Arrayen konti på den næste ledige plads
        {
            for (int a = 0; a < 100; a++)
            {
                if (konti[a] == null)
                    return a;
            }
            return 999;
        }


        //==================================================================================================================================================
       //|                                                   vis en brugers konto ud fra deres kundenummer                                                 |
      // ==================================================================================================================================================

        public void Kundevis2()
        {
            int j, f;
            string id;

            Console.Write("Indtast kundenummeret på den ønskede kundeprofil : ");
            id = Console.ReadLine(); //Der indtastes et kundenummer, som gemmes i variablen "id"

            for (j = 0; j < 100; j++) //En for lykke der køre 100 gange. Vores array er af størelsen 100
            {
                if (kunderne[j] != null && kunderne[j].ikn == id) // En if nestet if sætning som tjekker id op mod felterne i arrayet. Da denne sætning er nestet køres denne test 100 gange.
                { //Når der findes en værdi der passer med "id" printes nedenstående tekst
                    Console.Write("\n----------------------------------------------------\n");
                    Console.WriteLine("=====================================================");
                    Console.Write("Kundenummer : {0} \n", kunderne[j].ikn);
                    Console.Write("Fornavn : {0} \n", kunderne[j].ifnavn);
                    Console.Write("Efternavn : {0} \n", kunderne[j].ienavn);
                    Console.Write("Adresse : {0} \n", kunderne[j].iadr);
                    Console.Write("Telefonnummer : {0} \n", kunderne[j].itlf);
                    Console.Write("CPR nummer : {0} \n", kunderne[j].icpr);
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("\n----------------------------------------------------\n");
                    Console.WriteLine("{0} med kundenummer {1} har følgende konto/kontier : \n", kunderne[j].ifnavn, kunderne[j].ikn);

                    for (f = 0; f < 100; f++) //En nestet for lykke som køre 100 gange. 
                    {
                        if (konti[f] != null && konti[f].ikundenum == id) //Tjekker i arrayet til kunder efter id. Alle kontier er linket til en kunde med det uniqe kundenummer(id)
                        { //Når kontien findes ud fra "id" printes nedenstående tekst
                            Console.WriteLine("=====================================================");
                            Console.Write("Kundenummer : {0}\n", konti[f].ikundenum);
                            Console.WriteLine("Kontonavn : {0}", konti[f].iknn);
                            Console.WriteLine("Kontotype : {0}", konti[f].ikontitype);
                            Console.WriteLine("Saldo : {0}", konti[f].isld);
                            Console.WriteLine("Rentesats : {0}", konti[f].irente);
                            Console.WriteLine("Kontonummer : {0}", konti[f].iknr);
                            Console.WriteLine("Reg. nummer : {0}", konti[f].irgnr);
                            Console.WriteLine("=====================================================");
                            Console.WriteLine("----------------------------------------------------\n");
                        }                       
                    }
                    Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen
                }
            } 
            if (j >= 100) //Hvis "j" som er coutneren til ovenstående for lykke er større end eller lig med 100 vil den udskrive at der ikke kunne findes en kunde. 
            { // Dette er fordi for lykken har kørt 100 gange uden at finde et match på "id"
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen kunde fundet. Prøv igen\n\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen
            }
        }


        //==================================================================================================================================================
       // |                                                                    Samlet kapital                                                              |
      //  ==================================================================================================================================================

        public double samletkapital; //Det samlede kapital gemmes i denne variabel

        public void Samletkapital() //Objekt til at printe samlet kapital for banken
        {
            int j;

            for (j = 0; konti[j] != null; j++) //En for lykke der skal køre indtil der findes et "null" felt i konti arrayet
            {
                samletkapital += konti[j].isld; //Hver gang der køres skal isld (saldo) lægges til eller trækkes fra double variablen "samletkapital". 
            }
            Console.Clear();
            Console.Write("\n");
            Console.Write("==============================================================\n");
            Console.Write(" Bankens samlede kapital er : {0} DKK \n", samletkapital);               //Printer det samlede kapital for banken
            Console.Write("==============================================================\n");
            Console.Write("\n");
            Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen

        }


        //==================================================================================================================================================
       // |                                                                    Indsæt/hæv penge på konto                                                   |
      //  ==================================================================================================================================================

        public void Indsætpenge() //Objekt der bruges til at indsætte eller hæve penge på en konti
        {
            int j = 0, f;
            string id;
            double y;

            Console.Write("Indtast kontonummer på den ønskede konto du vil indsætte penge på : ");
            id = Console.ReadLine(); //Der indtastes et kontonummer til den konto der ønskes at ændre noget ved. Det gemmes i variablen "id"

            for (f = 0; f < 100; f++) //En for lykke der køre 100 gange. Vores array er af størelsen 100
            {
                if (konti[f] != null && konti[f].iknr == id)// En if nestet if sætning som tjekker id op mod felterne i arrayet. Da denne sætning er nestet køres denne test 100 gange.
                { //Når der findes en værdi der passer med "id" printes nedenstående tekst
                    Console.WriteLine("Dette er kundens nuværende saldo ");
                    Console.WriteLine("Kontonavn : {0}", konti[f].iknn); 
                    Console.WriteLine("Saldo : {0} DKK", konti[f].isld);
                    Console.WriteLine("----------------------------------------------------\n");
                    Console.Write("Hvilket beløb vil du ændre saldoen med? ");
                    y = Convert.ToInt32(Console.ReadLine()); //Gemmer hvilket beløb kontoen skal ændres med i "y"

                    konti[f].isld += y; //Finder feltet isld (saldo) i konti arrayet og + eller - værdien fra "y"

                    Console.Write("\n");
                    Console.WriteLine("Beløb er blevet ændret med [{0}] DKK \n", y); //Bekræfter og printer hvad beløb er ændret med 
                    Console.WriteLine("Den nye saldo er : {0}", konti[f].isld); //Printer den nye saldo fra feltet isld (saldo) i arrayet

                    break; //Bryder ud af lykken
                }
            }
            Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen
        }

        //==================================================================================================================================================
       // |                                                                    Slet kunde                                                                  |
      //  ==================================================================================================================================================

        public void Sletkunde() //Bruges til at slette en kunde
        {
            int j;
            string id;

            Console.Write("Indtast kundenummeret på den kunde du vil slette : ");
            id = Console.ReadLine(); //Der indtastes et kundenummer, som gemmes i variablen "id"

            for (j = 0; j < 100; j++) //En for lykke der køre 100 gange. Vores array er af størelsen 100
            {
                if (kunderne[j] != null && kunderne[j].ikn == id)//Tjekker i arrayet til kunder efter id. Alle kontier er linket til en kunde med det uniqe kundenummer(id)
                { //Når kontien findes ud fra "id" køres nedenstående
                    kunderne[j].ikn = null; //Findes feltet ikn (kundenummer) i arrayet kunderne, matchet med "id" og sætter det til "NULL"
                    kunderne[j].ifnavn = null; // ---- || ----
                    kunderne[j].ienavn = null;
                    kunderne[j].iadr = null;
                    kunderne[j].itlf = null;
                    kunderne[j].icpr = null;

                    Console.WriteLine("Kundens er nu slettet\n");

                    Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen
                }
            }
            if (j > 100)//Hvis "j" som er coutneren til ovenstående for lykke er større end eller lig med 100 vil den udskrive at der ikke kunne findes en kunde. 
            { // Dette er fordi for lykken har kørt 100 gange uden at finde et match på "id"
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen kunde fundet. Prøv igen\n\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen
            }
        }

        //==================================================================================================================================================
       // |                                                                    Slet konto                                                                  |
      //  ==================================================================================================================================================

        public void Sletkonto()
        {
            int j;
            string id;

            Console.Write("Indtast kontonummeret på den kunde du vil slette : ");
            id = Console.ReadLine();//Der indtastes et kontonummer, som gemmes i variablen "id"

            for (j = 0; j < 100; j++) //En for lykke der køre 100 gange. Vores array er af størelsen 100
            {
                if (kunderne[j] != null && kunderne[j].ikn == id)//Tjekker i arrayet til kunder efter id. Alle kontier er linket til en kunde med det uniqe kundenummer(id)
                { //Når kontien findes ud fra "id" printes nedenstående tekst
                    konti[j].isld = Convert.ToInt32(null); //Findes feltet isld (saldo) i arrayet kontier, og converter den til int, og efterfølgende sætter den til "NULL" 
                    konti[j].iknr = null; //Findes feltet iknr (kontonummer) i arrayet kontier, matchet med "id" og sætter det til "NULL"
                    konti[j].irgnr = null; // ---- || ----
                    konti[j].iknn = null;
                    konti[j].ikundenum = null;
                    konti[j].irente = null;
                    konti[j].ikontitype = null;

                    Console.WriteLine("Kontoen er nu slettet\n"); 

                    Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen
                }
            }
            if (j > 100) //Hvis "j" som er coutneren til ovenstående for lykke er større end eller lig med 100 vil den udskrive at der ikke kunne findes en kunde. 
            { // Dette er fordi for lykken har kørt 100 gange uden at finde et match på "id"
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen konto fundet. Prøv igen\n\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Returnhome.Wannaexit(); //Kalder wanna exit, som giver dig valget mellem at lukke programmet eller vende tilbage til menuen
            }
        }
    }
}