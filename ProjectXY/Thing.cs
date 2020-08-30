using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXY
{
    class Thing
    {
   
        public const int chromosomeSize = 10;
        public int id = 0;
        public double[] chromosome;
        public int generation =0;
        public double fitnessValue =0;

        public Thing()
        {
            this.id = SphereEvolution.idCounter;
            SphereEvolution.idCounter++;
            this.chromosome = new double[chromosomeSize];
           
        }

        public void Evaulate()
        {
            double sum = 0;
            foreach (double gen in this.chromosome)
            {
                sum += Math.Pow(gen, 2);
            }
            this.fitnessValue = sum;//sum is fitness value

        }

        public void Evaulate2()
        {
            double sum = 0;
            foreach (double gen in this.chromosome)
            {
                sum += (Math.Pow(gen, 2) - (10 * Math.Cos(2 * Math.PI * gen)));
            }
            this.fitnessValue = (10 * this.chromosome.Length) + sum;//sum is fitness value

        }
    }
}
