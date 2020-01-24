using System;
using System.Collections.Generic;
using System.Text;

namespace Det_lille_pengeinstitut

        //==================================================================================================================================================
       // |                                                    Definition af de forskellige værdier                                                        |
      //  ==================================================================================================================================================
{
    class Opret_konti //Definere hvad de forskellige værdier skal angives som, f.eks. isld skal være en double, da der kan være komma numre i
    {
        public double isld;
        public string iknr, irgnr, iknn, ikundenum, ikontitype, irente;

        //==================================================================================================================================================
       // |                                                    Instans værdier til oprettelse                                                              |
      //  ==================================================================================================================================================
        public Opret_konti() //Værdierne bruges når man indtaster en værdi under konti oprettelse. = 0; angiver at det skal være et tal, =""; angiver at det er en string
        {
            this.isld = 0;
            this.iknr = "";
            this.irgnr = "";
            this.iknn = "";
            this.ikundenum = "";
            this.ikontitype = "";
            this.irente = "";
        }

        //==================================================================================================================================================
       // |                                                        Stored indtastede værdier                                                               |
      //  ==================================================================================================================================================

        public void Setsaldo(double Nytsaldo) //Tager det indtastede tal og ligger det i en double parameteren (Instans databasen = this.isld | Parameter = Nytsaldo) 
        {
            this.isld = Nytsaldo;
        }
        public void Setkontonr(string Nytkontonr) //This bruges til at tager fat i instanss databasen og ikke i parameteren (Instans databasen = public Kunde | Parameter = Nytkn 
        {
            this.iknr = Nytkontonr;
        }
        public void Setregnr(string Nytregnr) // ---||---
        {
            this.irgnr = Nytregnr;
        }
        public void Setkontonavn(string Nytkontonavn) 
        {
            this.iknn = Nytkontonavn;
        }
        public void Setkundenummer(string Nytkundenum)
        {
            this.ikundenum = Nytkundenum;
        }
        public void Setkontitype(string Nytkontitype) 
        {
            this.ikontitype = Nytkontitype;
        }
        public void Setrente(string Nytrente) 
        {
            this.irente = Nytrente;
        }

    }
}

