using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_voorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mens bram = new Mens("Bram", true, 69);
            Mens kevin = new Mens("Kevin", true, 68);

            kevin.sla(bram); // Jij bent het slachtoffer xD
            // Snap je dat jij het slachtoffer bent? Ik geef jou als argument mee

            // this is het object waar je nu in zit

            // Als je zo kijkt he

            kevin.loop(); // Wie denk je dat 'this' is?, this (nederlands = deze)
            // Als ik zeg kevin loop, en je zit in kevin. Wie is dan this? Idd
            
            // Maak nieuw object aan, naam wordt Pitje de kat, het is een vrouw en 1 jaar oud
            Object pietje = new Mens("Pietje de kat", false, 1);
            
            Object ikBenEenObject = new Object();

            // CLASS = BLAUWDRUK voor een object
            // en als jij dan een nieuw object maakt volgens EEN BLAWUDRUK, ja
            // Een object is een ding, een iets. Jij bent ook een object.
            // Een object is gewoon een iets. Das een functie oftewijl een. hoe neodme ik da nou
            // een uitvoerbaar iets, 

            // Dus als ik zeg
            // Class = een blawudruk. Object wordt gemaakt volgens een blauwdruk.
            // Als ik dan een nieuw Mens maak, (nieuw object volgens de blauwdruk Mens)

            // sure
            // hold on ik schrijf t op

            // Maak een stuiterbal aan
            Stuiterbal eenBal = new Stuiterbal();


            eenBal.stuiter(); // Dit kan nu, dit kan niet omdat hij het blauwdruk Object voor zich heeft
            // methode/functie (zelfde) IDD!, klopt

            // Je begint het te snappen bram
            // Als je dit snapt, dan ben je heel ver voor je klasgenoten.
            // als ik? Gl
            // xD
          
            // Maar wilt ge dingen doen?
            // met melle bvb
            // u don't?
            // Ja? vind je t echt leuk?
            // Werk moet leuk zijn, altijd. Anders moet je dr mee stoppen, zelfde geld voor je opleiding.
            // Maar je moet echt weten of je het niet leuk vindt. Niet als je een kut leraar hebt bvb
            // waar is da van
            // cool lijkt op PIETJE :O KappaRoss lijkt of dinges, ehm


            // Anyway, dus





            // xD gebruik je overal voor, dit C# is oop. Je gebruikt dit ALLEEN MAAR. Je gebruikt het nu zelfs. Maar dat doet het programma voor je.
            // Idd t is erg  gebruiksvriendlijk atm voor jou
            // xD sure


            // K maar snap je het nu een beetje?



            // Iets meer advanced
            // Als jij een object hebt aangemaakt en da zit in een variable
            // En jij zegt da die variable een Object is en niet een stuiterbal
            // Kijkt die naar de classe ( dus blauwdruk, van object )
            // Dus als jij

            eenBal.stuiter(); // De stuiterbal wilt laten stuiteren. Weet hij niet hoe die dat kan noet omdat de blauwdruk Object, niet de methode stuiter heeft

            // Idd, het is ook een stuiterbal. Maar je stop het in een variable Object.
            // En dan kijkt die naar de classe Object, en niet naar de classe Stuiterbal.

            Console.Write(eenBal);



            Console.ReadLine();

        }
    }
}
