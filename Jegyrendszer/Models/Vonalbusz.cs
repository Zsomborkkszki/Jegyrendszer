using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal class Vonalbusz : Jegy
    {
        public Vonalbusz(double alapdij, double tavolsagKm): base(alapdij, tavolsagKm) 
        { 
        }

        public override double arSzamitas()
        {
            return Alapdij + (TavolsagKm * 30);
        }
}}
