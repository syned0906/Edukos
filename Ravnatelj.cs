using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ravnatelj : Osoba
    {
        public List<Ucitelj> Ucitelji { get; set; }
        public List<Student> Studenti { get; set; }

        public Ravnatelj(string ime, string prezime) : base(ime, prezime)
        {
            Ucitelji = new List<Ucitelj>();
            Studenti = new List<Student>();
        }



        public void DodajUcitelja(Ucitelj ucitelj)
        {
            Ucitelji.Add(ucitelj);
        }


        public void DodajStudenta(Student student)
        {
            Studenti.Add(student);
        }


        public void UkloniUcitelja(Ucitelj ucitelj)
        {
            Ucitelji.Remove(ucitelj);
        }
        

        public void UkloniStudenta(Student student)
        {
            Studenti.Remove(student);
        }

        public void PregledOpcihOcjenaSkole()
        {
            foreach (var student in Studenti)
            {
                student.PrikaziOcjene();
            }
        }
    }
}
