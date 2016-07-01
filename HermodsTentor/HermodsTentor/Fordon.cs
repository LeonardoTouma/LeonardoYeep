using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvArv
{
    class Fordon
    {
        public int hästkrafter { get; set; }// GLOBAL VARIABEL/FÄLT VARIABEL
        string färg { get; set; }// GLOBAL VARIABEL/FÄLT VARIABEL


        public Fordon(int hästkrafter, string färg, bool tutar) : base()// KONSTRUKTOR FÖR ATT KUNNA SKICKA SAKER TILL KLASSER SOM ÄRVER IFRÅN DENNA KLASS. I DETTA FALL HÄSTKRAFTER,FÄRG OCH TUTAR VARIABLERNA
        {

        }

        public virtual bool tutar(bool tutar)// KOLLAR IFALL DEN KAN TUTA
        {
            Console.Clear();
            if (true)
                Console.WriteLine("Den kan tuta.");

            else
                Console.WriteLine("Den kan inte tuta.");

            return tutar;
        }
        public virtual int maxhastighet(int maxhastighet)// KOLLAR MAXHASTIGHETEN
        {
            Console.WriteLine("Fordonet har " + maxhastighet + " hästkrafter");

            maxhastighet = hästkrafter;//GÖR SÅ ATT MAXHASTIGHETEN ÄR DEN SAMMA SOM ANTALET HÄSTKRAFTER SOM FORDONET HAR.
            return maxhastighet;// RETURNERAR VÄRDET IDETTA FALL 200
        }
    }
}
