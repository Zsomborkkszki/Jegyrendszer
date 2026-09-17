using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal abstract class Jegy
    {
        public double Alapdij { get; set; }
        public double TavolsagKm { get; set; }

        public Jegy(double alapdij, double tavolsagKm)
        {
            Alapdij = alapdij;
            TavolsagKm = tavolsagKm;
        }

        public abstract double arSzamitas();
    }
}
