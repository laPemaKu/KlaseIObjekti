using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_objekti
{
    internal class Program
    {
        class Zrakoplov
        {
            string naziv;
            double snaga_motora;
            int doseg_leta;

            public Zrakoplov()
            {

            }
            public Zrakoplov(string naziv, double snaga_motora, int doseg_leta)
            {
                this.naziv = naziv;
                this.snaga_motora = snaga_motora;
                this.doseg_leta = doseg_leta;
            }
            public string GetNaziv()
            {
                return this.naziv;
            }
            public double GetSnagaMotora()
            {
                return this.snaga_motora;
            }
            public int GetDosegLeta()
            {
                return this.doseg_leta;
            }

        }
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov c162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC_21 = new Zrakoplov("Pilatus", 1200, 1333);
            Console.WriteLine(x380.GetNaziv() + ", " + x380.GetSnagaMotora() + " kW, " + x380.GetDosegLeta() + " km");
            Console.WriteLine(c162.GetNaziv() + ", " + c162.GetSnagaMotora() + " kW, " + c162.GetDosegLeta() + " km");
            Console.WriteLine(PC_21.GetNaziv() + ", " + PC_21.GetSnagaMotora() + " kW, " + PC_21.GetDosegLeta() + " km");
            Console.ReadKey();
        }
    }
}
