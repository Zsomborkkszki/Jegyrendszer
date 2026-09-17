using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal class MeteoVonat:Jegy
    {
        public MeteoVonat(double alapdij, double tavolsagKm) : base(alapdij, tavolsagKm)
        {
        }
        public override double arSzamitas()
        {
            return (Alapdij*2) + (TavolsagKm * 50);
        }
    }
}
