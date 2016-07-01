using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvArv
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastbil = new Lastbil(150, "blue", false);//SKAPAR EN INSTANSIERING AV OBJEKTET LASTBIL, INPARAMETRAR SOM FINNS I RESPEKTIVE KLASS, I DETTA FALL I LASTBILS KLASSEN
            var fordon = new Fordon(200, "red", true);// SKAPAR EN INSTANSIERING AV OBJEKTET FORDON MED INPARAMETRAR SOM FINNS I RESPKETIVE KLASS, HÄR ALLTSÅ I FORDON KLASSEN
            Console.WriteLine("What kind of vehicale do you have? ");
            string choice = Console.ReadLine();// ANVÄNDARENS INTRYCKNINGAR FÖR ATT GÅ VIDARE
            if (choice == "lastbil" || choice == "Lastbil")// EN IF SATS FÖR ATT KOLLA IFALL PERSONEN SKRIVER ANTIGEN MED ETT STORT L I LASTBIL ELLER LITET, IFALL DET ÄR STORT SÅ SKA DEN GÖRA SAMMASAK, DETTA ÄR BARA FÖR ATT HÅLLA KOLL PÅ ATT DET INTE BLIR NÅGRA FEL.
            {
                lastbil.tutar(false);//KALLAR PÅ EN BOOLEANSK TUT VARIABEL I LASTBIL, FÖR ATT KOLLA IFALL DEN TUTAR FÖRTILLFÄLLET SÅ GÖR DEN INTE DET, EFTERSOM JAG LA DEN TILL FALSE
                lastbil.maxhastighet(150);
            }
            else if (choice == "fordon" || choice == "Fordon")
            {
                fordon.tutar(true);//KALLAR PÅ EN BOOLEANSK TUT VARIABEL I FORDON, FÖR ATT KOLLA IFALL DEN TUTAR FÖRTILLFÄLLET SÅ GÖR DEN DET, EFTERSOM JAG LA DEN TILL TRUE
                fordon.maxhastighet(200);//KOLLAR MAX HASTIGHETEN, SOM JAG LA TILL 200, EFTERSOM ATT I FORDONET SÅ SKA INTE DEN REGLERAS MED VIKT
            }
            Console.ReadKey();

        }
    }
}
