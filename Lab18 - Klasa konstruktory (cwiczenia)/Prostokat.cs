using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18___Klasa_konstruktory__cwiczenia_
{
    class Prostokat
    {
        Punkt lewyDolny;
        public int wysokosc;
        public int szerokosc;

        public Prostokat(Punkt lewyDolnyRog, int wysokosc, int szerokosc)
        {
            this.lewyDolny = lewyDolnyRog;
            this.wysokosc = wysokosc;
            this.szerokosc = szerokosc;
        }

        public void ObliczProstokat()
        {//Punkt lewyDolnyRog, int wysokosc, int szerokosc
            string nl;
            nl = Environment.NewLine;
            int x, y;
            x = this.lewyDolny.x;
            y = this.lewyDolny.y;
            Punkt prawyDolny = new Punkt (x + szerokosc, y);
            Punkt prawyGorny = new Punkt(x + szerokosc, y + wysokosc);
            Punkt lewyGorny = new Punkt(x, y + wysokosc);
            Console.WriteLine($"Prostokąt dla podanego lewego dolnego punktu: {lewyDolny.x}, {lewyDolny.y}, wysokości: {wysokosc} i szerokości: {szerokosc}{nl}Prawy dolny: {prawyDolny.x}, {prawyDolny.y}{nl}Prawy górny: {prawyGorny.x}, {prawyGorny.y}{nl}Lewy górny: {lewyGorny.x}, {lewyGorny.y}");
            //return $"Nazwa zwierzaka: {nazwa}{nl}Ilość oczu: {iloscOczu}{nl}Ilość nóg: {iloscNog}";
        }
    }
}
