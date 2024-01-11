using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student:Osoba
    {
        public List<int> Ocjene { get; set; }
        public string Razred { get; set; }

        public Student(string ime, string prezime,string razred) : base(ime, prezime)
        {
            Ocjene = new List<int>();
            Razred = razred;
        }

        public void DodajOcjenu(int ocjena)
        {
            Ocjene.Add(ocjena);
        }

        public void PrikaziOcjene()
        {
            Console.WriteLine($"Ocjene studenta:{Ime} {Prezime}");
            
            foreach (var ocjena in Ocjene)
            {
                Console.WriteLine(ocjena);
            }
        }

    }
}
