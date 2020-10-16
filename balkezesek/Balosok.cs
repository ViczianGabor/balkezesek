using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    class Balosok
    {
        public string Nev { get;private set; }

        public string ElsoDatum { get;private set; }

        public string UtolsoDatum { get; private set; }

        public int Suly { get; private set; }

        public double Magassag { get; private set; }



        public Balosok(string szoveg)
        {
            int i = 0;
            string[] a = szoveg.Split(';');
            Nev = a[0];
            ElsoDatum = a[1];
            UtolsoDatum = a[2];
            Suly = int.Parse(a[3]);
            Magassag = Convert.ToDouble(a[4]);
            


        }








    }
}
