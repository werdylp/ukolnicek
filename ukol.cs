using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukolnicek
{
    public class ukol
    {
        string nazev;
        DateTime? termin;

        byte prubeh;

        public string Nazev { get => nazev; /* set => nazev = value;*/ }
        public string Termin { get => termin != null ? ((DateTime)termin).ToString("dd.MM.yyyy") : ""; }//otazdnik povoli hodnotu null



        public string Prubeh
        {
            get
            {
                switch (prubeh) 
                {
                    case 0:
                        return "zadano";
                    case 1:
                        return "rozpracovano";
                    case 3:
                        return "splněno";

                    default:
                        return "";
                }
            }
        }

        public ukol(string nazev,DateTime termin,byte prubeh) { 
        
            this.nazev = nazev;
            this.termin = termin;
            this.prubeh = prubeh;

        }
    }
}
