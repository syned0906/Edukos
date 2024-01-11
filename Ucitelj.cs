using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ucitelj : Osoba
    {
        public List<string> Predmeti { get; set; }

        public Ucitelj(string ime, string prezime,List<string> predmeti):base(ime,prezime)
        {
            Predmeti = predmeti;
        }

        public void DodajOcjenuStudentu(Student student,int ocjena)
        {
            student.DodajOcjenu(ocjena);
        }

        public void PregledOcjenaUcenika(Student student)
        {
            student.PrikaziOcjene();
        }

        public void PregledOcjenaRazreda(Razred razred)
        {
            razred.PrikaziOcjeneRazreda();
        }
    }
}
