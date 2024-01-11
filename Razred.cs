using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Razred
    {
        public string NazivRazreda { get;set; }
        public List<Student> Studenti { get;set; }

        public Razred(string nazivRazreda)
        {
            NazivRazreda = nazivRazreda;
            Studenti = new List<Student>();
        }

        public void DodajStudenta(Student student)
        {
            Studenti.Add(student);
        }

        public void UkloniStudenta(Student student)
        {
            Studenti.Remove(student);
        }

        public void PrikaziOcjeneRazreda()
        {
            foreach (var student in Studenti)
            {
                student.PrikaziOcjene();
            }
        }
    }
}
