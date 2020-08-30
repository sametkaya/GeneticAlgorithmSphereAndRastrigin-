using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXY
{

    class RastringEvolution
    {
        public static int idCounter = 0;
        public int populationSize = 10;
        public int geneSize = 10;
        public double mutationProbability = 0;
        public double crossoverProbability = 0;

        public int generationSize = 0;
        List<int> rndselectionlistStatic = new List<int>();
        public List<Thing> population;
        double rangeUp = 0;
        double rangeDown = 0;
        Random rnd;
        public RastringEvolution(int popopulationSize, double crossoverProbability, double rangeUp, double rangeDown, int generationSize)
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
                nthing.Evaulate2();
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
                    Tuple<Thing, Thing> childs = this.AritmeticRecombinationCrossover(xthing, ything);
                    childs.Item1.Evaulate2();
                    childs.Item2.Evaulate2();
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
                for (int i = 0; i < nextGeneration.Count;)
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

 
        public List<Thing> MutatePopulationGaussian(ref List<Thing> list)
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
                        double gaus = MyMath.GenerateGaussian();
                        int whichGen = rnd.Next(list[i].chromosome.Length);
                        //mutate gaussian
                        double mutatedGen = MyMath.GenerateGaussian() + list[i].chromosome[whichGen];
                        //mirroring
                        while (this.rangeUp <mutatedGen || mutatedGen< this.rangeDown)
                        {
                            if (this.rangeUp < mutatedGen)
                            {
                                mutatedGen= this.rangeUp-Math.Abs(mutatedGen - this.rangeUp);
                            }
                            else if(mutatedGen < this.rangeDown)
                            {
                                mutatedGen = this.rangeDown + Math.Abs( this.rangeDown - mutatedGen);
                            }
                        }
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
        

        public Tuple<Thing, Thing> AritmeticRecombinationCrossover(Thing xthing, Thing ything)
        {
            double a = 0.5;
            Thing nthing1 = new Thing();
            Thing nthing2 = new Thing();
            for (int i = 0; i < xthing.chromosome.Length; i++)
            {
                nthing1.chromosome[i] = (a * xthing.chromosome[i]) + ((1-a) * ything.chromosome[i]);
                nthing2.chromosome[i] = (a * xthing.chromosome[i]) + ((1 - a) * ything.chromosome[i]);

            }
            nthing1.Evaulate2();
            nthing2.Evaulate2();
            Tuple<Thing, Thing> tuple = new Tuple<Thing, Thing>(nthing1, nthing2);
            return tuple;
        }


    }
}
