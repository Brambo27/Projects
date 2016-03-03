using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_voorbeeld
{
    public class Mens
    {

        public static Mens[] mensenGrabbelTon;

        public string naam;
        public bool geslacht;
        public int leeftijd;

        public Mens(string naam, bool geslacht, int leeftijd)
        {

            int arrayLength = mensenGrabbelTon.Length;

            Mens[] newArray = new Mens[arrayLength + 1];
            for (int i=0; i<arrayLength; i++)
            {
                newArray[i] = mensenGrabbelTon[i];
            }
            newArray[arrayLength + 1] = this;
            mensenGrabbelTon = newArray;

            // grabbelton kan je zo benaderen:
            var a = Mens.mensenGrabbelTon;



            Object b = new Mens("", false, 1);

            // we weten dat b een object is dus kan niet slaan.

            b = (Mens)b; // Nu zeg ik, b is een Mens

            // We weten nu dat b een Mens is dus kan slaan
            
            b = (Object)b;


            // Dit snap je, eh nee
            // je maakt een nieuw mens aan, en stop je in de variable b dat het type Mens is
            // Kijk als jij het systeem verteld dat b een Mens is.
            // Dan weet het systeem van, ow ik kan b alles laten doen wat een Mens kan.
            // Als jij verteld dat b een object is. dan denkt die
            // Ow ik kan b alles laten doen wat een Object kan. IDD omdat een mens een object is
            // Dus als jij t systeem verteld dat b een Object is.
            // Kan die dan nog slaan?
            // (eigenlijk is het wel een mens) maar je zegt dat het een object is.
            // Je houdt het systeem als ware voor de gek.
            // NEE, want hij kan alleen de blauwdruk van Object gebruiken.
            // Het object zelf, het dingetje zelf is wel een Mens.
            // Maar je ZEGT/HOUD HET YSSTEEM VOOR DE GEK dat het een Object is
            // Je ZEGT het systeem dat het een Object is.

            // Als ik jou ALLEEN vertel dat ik op een 'Object' heb gezeten.
            // Waar heb ik dan volgens jou op gezeten? KLOPT
            // Maar ik weet dat ik op een stoel heb gezeten. En een stoel is ook een Object.

            // k ehm, xD

            // Overnieuw

            // Als ik jou zeg dat ik vandaag in een auto gereden heb.
            // Klopt dus auto.rij() bestaad

            // Als ik jou nu zeg dat ik in een schakelauto heb gereden.
            // Kan de dan schakelen?
            // Dus auto.schakel() bestaad. // een variable ja new SchakelAuto()

            // Als ik jou nu zeg, ik heb in een automaat gereden.
            // Kan een automaat schakelen? (als een automaat niet kon schakelen) (ff doen alsof een automaat niet kan schakelen)
            // Dus auto.schakel() bestaad niet.


            Mens c = new Mens("", false, 1);

            // Kan c slaan?
            // k

            //c = (Object)c; // Je weet hoe classe (ongeveer) werken, en hoe je kan casten?




            this.naam = naam;
            this.geslacht = geslacht;
            this.leeftijd = leeftijd;
        }

        public void loop()
        {
            Console.Write("Ik " + naam + " loop.");
        }

        public void sla(Mens slachtoffer)
        {
            Console.Write("Ik " + naam + " sla " + slachtoffer.naam + ".");
        }

        // Write alle mensen in de grabbelton naar console
        public static void dumpGrabbelton()
        {
            for (int i = 0; i < mensenGrabbelTon.Length; i++)
            {
                Console.Write(mensenGrabbelTon[i]);
            }
        }

    }

}
