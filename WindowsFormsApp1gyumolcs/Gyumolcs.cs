using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1gyumolcs
{
    internal class Gyumolcs
    {
        int db;
        string fajta;
        int meret;
        string szin;

        public Gyumolcs(int db, string fajta, int meret, string szin)
        {
            Db = db;
            Fajta = fajta;
            Meret = meret;
            Szin = szin;
        }

        public int Db { get => db; set => db = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public int Meret { get => meret; set => meret = value; }
        public string Szin { get => szin; set => szin = value; }
    }
}
