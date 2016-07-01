using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvArv
{
    class Lastbil : Fordon
    {
        int last { get; set; }// GLOBAL VARIABEL
        public Lastbil(int hästkrafter, string färg, bool tutar) : base(hästkrafter, färg, tutar)// SKICKAR TILLBAKA VARIABLERNA 
        {
            hästkrafter = 150;// SÄTTER VÄRDET PÅ HÄSTKRAFTER TILL 150, FÖR ATT KUNNA HA ETT START VÄRDE

        }

        public override int maxhastighet(int maxhastighet) //HAR EN INPARAMETER FÖR ATT KUNNA RÖRA RUNDOR MED VÄRDET I METODEN ENBART. ÄVEN FÖR ATT HÅLLA VÄRDET TILL 150 ANNARS HADE VÄRDET GÅTT UNDER 0 ÄVEN, DEN SAMMA IFALL JAG HADE SATTIT MAXHASTIGHET = MAXHASTIGHET - LAST; OVANFÖR IF SATSEN
        {
            Console.WriteLine("Lastbilen har " + maxhastighet + " hästkrafter innan beräkning.");
            Console.WriteLine("Hur mycket last har lastbilen? Så att kalkuleringen kring hur snabbt den kan köra kan börja.");
            int last = int.Parse(Console.ReadLine());// ANVÄNDARENS INTRYCKNING
            Console.Clear();
            if (last >= 150)
            {
                maxhastighet = maxhastighet - last;// DETTA ÄR IFALL ATT ANVÄNDARENS LAST ÄR ÖVER 150, DÄRFÖR SÄGA TILL ANVÄNDAREN ATT DET INTE GÅR ATT KÖRA DEN EFTERSOM ATT LASTEN TAR UT SNABBHETEN
                Console.WriteLine("Hästkrafter efter beräkning: " + maxhastighet + " hästkrafter." + "Lasten väger: " + last + "kg." + " Lastbilens vikt är mindre än hastigheten den kan köra i och därför kommer den inte kunna röra sig. " + "Kalkulerad maxhastighet: " + maxhastighet);
            }
            else
            {
                maxhastighet = maxhastighet - last; //KOLLAR LASTEN SEN SÄGER HUR SNABBT DEN KOMMER KÖRA
                Console.WriteLine("Hästkrafter: " + maxhastighet + "mph" + " med en vikt på " + last + "kg.");
            }
            return maxhastighet;
        }
        public override bool tutar(bool tutar)
        {
            Console.Clear();//RENSAR CONSOLEN FÖR ATT DET SKA BLI TYDLIGARE/SNYGGARE
            if (tutar == true)//KOLLAR TUTNINGEN OM DEN KAN ELLER INTE HAR SATTIT ATT DEN INTE KAN I ALLA LÄGEN
            {
                Console.WriteLine("Den kan tuta.");
            }

            else
            {
                Console.WriteLine("Den kan inte tuta.");
            }
            return tutar;
        }

    }
}
