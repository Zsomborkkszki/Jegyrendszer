using Jegyrendszer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer
{
    internal class Program
    {
        static List<Jegy> napiUtazasok = new List<Jegy>();
        static void Main(string[] args)
        {
            napiUtazasok.Add(new Vonalbusz(450, 10));    
            napiUtazasok.Add(new MeteoVonat(450, 20));
            napiUtazasok.Add(new ElektromosRoller(5));

            double osszesBevetel = 0;

            foreach (var utazas in napiUtazasok)
            {
                osszesBevetel += utazas.arSzamitas();
            }

            Console.WriteLine($"A napi teljes befolyt bevétel: {osszesBevetel} Ft");
        }
    }
}
