using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXY
{

    class SphereEvolution
    {
        public static int idCounter = 0;
        public int populationSize = 10;
        public int geneSize = 10;
        public double mutationProbability = 0;
        public double crossoverProbability = 0;
        double rangeUp = 0;
        double rangeDown = 0;
        public int generationSize = 0;
        List<int> rndselectionlistStatic = new List<int>();
        public List<Thing> population;
        Random rnd;
        public SphereEvolution(int popopulationSize, double crossoverProbability, double rangeUp, double rangeDown, int generationSize)
        {
            this.populationSize = popopulationSize;
            this.mutationProbability = 1 / (double)this.geneSize;
            this.crossoverProbability = crossoverProbability;
            this.rangeUp = rangeUp;
            this.rangeDown = rangeDown;
            this.generationSize = generationSize;
            rnd = new Random();
            population = new List<Thing>();

            rndselectionlistStatic = new List<int>();
            for (int i = 0; i < populationSize; i++)
            {
                rndselectionlistStatic.Add(i);
            }

            this.PaleozoicEra();



        }
        //generate first primitive generation
        public void PaleozoicEra()
        {
            for (int i = 0; i < this.populationSize; i++)
            {
                Thing nthing = new Thing();
                for (int j = 0; j < nthing.chromosome.Length; j++)
                {
                    // we don't want to generate same gen in the chromosome 
                    double randomgen;
                    do
                    {
                        randomgen = rnd.NextDouble() * (this.rangeUp - this.rangeDown) + this.rangeDown;
                    } while (nthing.chromosome.Contains(randomgen));

                    nthing.chromosome[j] = randomgen; //random number may be added a range

                }
                nthing.Evaulate();
                this.population.Add(nthing);
            }
            this.SortList(ref this.population);
        }




        public List<Thing> GenerateNextGeneration()
        {
            List<int> rndselectionlist = new List<int>(rndselectionlistStatic);
            int getrnd = 0;
            List<Thing> nextGeneration = new List<Thing>();
            Thing xthing = null;
            Thing ything = null;
            while (rndselectionlist.Count > 0)
            {
                double rndcrossover = rnd.Next(10) + 1;
                getrnd = rnd.Next(rndselectionlist.Count);
                if ((rndcrossover / 10) <= this.crossoverProbability)
                {
                    if (xthing == null)
                    {
                        xthing = this.population[rndselectionlist[getrnd]];
                        rndselectionlist.RemoveAt(getrnd);
                    }
                    else if (ything == null)
                    {
                        ything = this.population[rndselectionlist[getrnd]];
                        rndselectionlist.RemoveAt(getrnd);
                    }
                }
                else
                {
                    rndselectionlist.RemoveAt(getrnd);
                }
                if (xthing != null && ything != null)
                {
                    Tuple<Thing, Thing> childs = this.OnePointCrossover(xthing, ything);
                    childs.Item1.Evaulate();
                    childs.Item2.Evaulate();
                    //Tuple<Thing, Thing> childs = this.UniformCrossover(xthing, ything);
                    nextGeneration.Add(childs.Item1);
                    nextGeneration.Add(childs.Item2);
                    xthing = null;
                    ything = null;
                }

            }
            this.SortList(ref nextGeneration);
            return nextGeneration;

        }

        public void GenerationGap(List<Thing> nextGeneration)
        {
           

            for (int j = 0; j < this.population.Count;)
            {
                for (int i = 0; i < nextGeneration.Count; )
                {
                    if (this.population[j].fitnessValue > nextGeneration[i].fitnessValue)
                    {
                        this.population[j] = nextGeneration[i];
                        i++;
                        j++;
                        if (j >= this.population.Count)
                            break;
                    }
                    else
                    {
                        break;
                    }
                }
                j++;

            }

            this.SortList(ref this.population);

        }

        public List<Thing> MutatePopulationBinary(ref List<Thing> list)
        {
            int rndMutationCount = 0;
            for (int i = 0; i < list.Count; i++)
            {
                double rndmutation = rnd.Next(10) + 1;
                if (rndmutation / 10 <= mutationProbability)
                {
                    rndMutationCount = rnd.Next(list[i].chromosome.Length);

                    for (int j = 0; j < rndMutationCount; j++)
                    {
                        int whichGen = rnd.Next(list[i].chromosome.Length);
                        String bitGen = MyMath.doubleToBitString(list[i].chromosome[whichGen]);
                        int whichBitGen = rnd.Next(bitGen.Length);
                        char c = bitGen[whichBitGen];
                        MyMath.ReplaceAt(ref bitGen, whichBitGen, (bitGen[whichBitGen] == '1') ? '0' : '1');
                        double mutatedGen = MyMath.bitStringToDouble(bitGen);
                        list[i].chromosome[whichGen] = mutatedGen;
                    }
                    list[i].Evaulate();
                }
            }
            this.SortList(ref list);
            return list;
        }
       


        public void SortList(ref List<Thing> list)
        {
            list = list.OrderBy(o => o.fitnessValue).ToList();
        }

        public Tuple<Thing, Thing> OnePointCrossover(Thing xthing, Thing ything)
        {
            Thing nthing1 = new Thing();
            Thing nthing2 = new Thing();
            int point = rnd.Next(xthing.chromosome.Length);
            int il = 0;
            while (il <= point)
            {
                nthing1.chromosome[il] = xthing.chromosome[il];
                il++;
            }
            il = 0;
            while (il <= point)
            {
                nthing2.chromosome[il] = ything.chromosome[il];
                il++;
            }
            int ih = xthing.chromosome.Length - 1;

            while (ih > point)
            {
                nthing1.chromosome[ih] = xthing.chromosome[ih];
                ih--;
            }
            ih = xthing.chromosome.Length - 1;
            while (ih > point)
            {
                nthing2.chromosome[ih] = ything.chromosome[ih];
                ih--;
            }
            Tuple<Thing, Thing> tuple = new Tuple<Thing, Thing>(nthing1, nthing2);
            return tuple;
        }


        public Tuple<Thing, Thing> UniformCrossover(Thing xthing, Thing ything)
        {
            List<int> xrndlist = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> yrndlist = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Thing nthing1 = new Thing();
            Thing nthing2 = new Thing();

            int i1 = 0;
            while (xrndlist.Count > 5)
            {
                int getrnd = rnd.Next(xrndlist.Count);
                double sgen = ything.chromosome[xrndlist[getrnd]];
                xrndlist.Remove(getrnd);
                nthing1.chromosome[i1] = sgen;
                i1++;
            }
            while (yrndlist.Count > 5)
            {
                int getrnd = rnd.Next(yrndlist.Count);
                double sgen = ything.chromosome[yrndlist[getrnd]];
                yrndlist.Remove(getrnd);
                nthing1.chromosome[i1] = sgen;
                i1++;
            }

            int i2 = 0;
            while (xrndlist.Count > 0)
            {
                int getrnd = rnd.Next(xrndlist.Count);
                double sgen = ything.chromosome[xrndlist[getrnd]];
                xrndlist.Remove(getrnd);
                nthing2.chromosome[i2] = sgen;
                i2++;
            }
            while (yrndlist.Count > 0)
            {
                int getrnd = rnd.Next(yrndlist.Count);
                double sgen = ything.chromosome[yrndlist[getrnd]];
                yrndlist.Remove(getrnd);
                nthing2.chromosome[i2] = sgen;
                i2++;
            }

            Tuple<Thing, Thing> tuple = new Tuple<Thing, Thing>(nthing1, nthing2);
            return tuple;
        }


    }
}
