using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ID;

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
            ID = new Random().Next();
        }
    }
}
