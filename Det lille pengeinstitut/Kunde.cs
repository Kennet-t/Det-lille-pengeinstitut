using System;
using System.Collections.Generic;
using System.Text;

namespace Det_lille_pengeinstitut
{
        //==================================================================================================================================================
       // |                                 Værdierne der bruges når man opretter brugere                                                                  |
      //  ==================================================================================================================================================
    class Kunde
    {
        public string ikn, ifnavn, ienavn, iadr, itlf, icpr;

        //==================================================================================================================================================
       // |                                                    Instans værdier til oprettelse                                                              |
      //  ==================================================================================================================================================

        public Kunde() //Bruges til når man skal indtaste de forskellige værdier, ="" angiver at det skal indtastes som en string. Dette er instans værdierne.
        {
            this.ikn = "";
            this.ifnavn = "";
            this.ienavn = "";
            this.iadr = "";
            this.itlf = "";
            this.icpr = "";
        }


        //==================================================================================================================================================
       // |                                                        Stored indtastede værdier                                                               |
      //  ==================================================================================================================================================

        public void Setkn(string Nytkn) //Tager de indtastede værdier og ligger dem i string 
        {
            this.ikn = Nytkn;
        }
        public void Setfnavn(string Nytfnavn) //This bruges til at tage fat i instanss databasen og ikke i parameteren (Instans databasen = public Kunde | Parameter = Nytkn 
        {
            this.ifnavn = Nytfnavn;
        }
        public void Setenavn(string Nytenavn) // ----||----
        {
            this.ienavn = Nytenavn;
        }
        public void Setadr(string Nytadr)
        {
            this.iadr = Nytadr;
        }
        public void Settlf(string Nyttlf)
        {
            this.itlf = Nyttlf;
        }
        public void Setcpr(string Nytcpr)
        {
            this.icpr = Nytcpr;
        }
    }
}    