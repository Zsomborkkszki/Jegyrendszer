using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal class ElektromosRoller : Jegy
    {
            public ElektromosRoller(double tavolsagKm)
                : base(0, tavolsagKm) { }

            public override double arSzamitas()
            {
                return TavolsagKm * 120;
            }
        
    }
}
