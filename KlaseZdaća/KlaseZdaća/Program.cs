using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseZdaća
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov X380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cesna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);
            Console.WriteLine(X380.Ispis());
            Console.WriteLine(C162.Ispis());
            Console.WriteLine(PC21.Ispis());
            Console.ReadKey();
        }
    }

    class Zrakoplov
    {
        string naziv;
        int snagaMotora, dosegLeta;

        //set
        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public void setSnaga(int snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public void setDoseg(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }

        //get
        public string GetNaziv()
        {
            return this.naziv;
        }
        public int GetSnaga()
        {
            return this.snagaMotora;
        }
        public int GetDoseg()
        {
            return this.dosegLeta;
        }

        public string Ispis()
        {
            string ispis = " Naziv : " + this.GetNaziv() + " \r\n Snaga motora: " + this.GetSnaga() + "kW  \r\n Doseg leta: " + this.GetDoseg()+ "km.";

            return ispis;
        }

        public Zrakoplov()
        {

        }

        public Zrakoplov(string naziv, int snagaMotora, int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }
    }
}
