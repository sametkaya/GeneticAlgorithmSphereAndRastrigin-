using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectXY
{
    public partial class Form1 : Form
    {
        SphereEvolution sEvolution;
        RastringEvolution rEvolution;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            int populationSize =  Int32.Parse(this.txt_populationSize.Text);
            int generationSize = Int32.Parse(this.txt_generationSize.Text);
            double rangeUp = Double.Parse(this.txt_rangeUp.Text);
            double rangeDown = Double.Parse(this.txt_rangeDown.Text);
          
            Double crossoverPorbobility = Double.Parse(this.txt_crossoverPorbobility.Text);
            this.sEvolution = new SphereEvolution(populationSize, crossoverPorbobility, rangeUp, rangeDown, generationSize);
            chrt_populationBeforeLoad(this.sEvolution.population);
            
        }

        private void btn_nextGeneration_Click(object sender, EventArgs e)
        {
            chrt_populationBeforeLoad(this.sEvolution.population);
            List<Thing> nGeneration= this.sEvolution.GenerateNextGeneration();
           // chrt_populationAfterLoad(nGeneration);
            this.sEvolution.GenerationGap(nGeneration);
            chrt_populationAfterLoad(this.sEvolution.population);
            

        }
        private void chrt_populationBeforeLoad(List<Thing> population)
        {
            this.chrt_populationBefore.Series["Fitness"].Points.Clear();
            int i = 0;
            foreach (Thing athing in population)
            {
                this.chrt_populationBefore.Series["Fitness"].Points.AddXY(i,athing.fitnessValue);
                i++;

            }
        }

        private void chrt_populationAfterLoad(List<Thing> population)
        {
            this.chrt_populationAfter.Series["Fitness"].Points.Clear();
            int i = 0;
            foreach (Thing athing in population)
            {
                this.chrt_populationAfter.Series["Fitness"].Points.AddXY(i, athing.fitnessValue);
                i++;

            }
        }

        private void btn_mutatePopulation_Click(object sender, EventArgs e)
        {
            // this.sEvolution.population=this.sEvolution.MutatePopulationRandom(ref this.sEvolution.population);
            this.sEvolution.population = this.sEvolution.MutatePopulationBinary(ref this.sEvolution.population);
            chrt_populationBeforeLoad(this.sEvolution.population);
            load_label();
        }

        private void btn_mutateAndNextGeneration_Click(object sender, EventArgs e)
        {
            chrt_populationBeforeLoad(this.sEvolution.population);
            List<Thing> nGeneration = this.sEvolution.GenerateNextGeneration();

            //nGeneration = this.sEvolution.MutatePopulationRandom(ref nGeneration);
            nGeneration = this.sEvolution.MutatePopulationBinary(ref nGeneration);
            // chrt_populationAfterLoad(nGeneration);
            this.sEvolution.GenerationGap(nGeneration);
            chrt_populationAfterLoad(this.sEvolution.population);
            load_label();



        }

        private void load_label()
        {
            lbl_mean.Text = MyMath.mean(this.sEvolution.population) + "";
            lbl_median.Text = MyMath.median(this.sEvolution.population) + "";
            lbl_best.Text = this.sEvolution.population[0].fitnessValue + "";
        }

        /**********************************************/
        /**********************************************/
        /**********************************************/
        /**********************************************/

        private void btn_generateRastring_Click(object sender, EventArgs e)
        {
            int populationSize = Int32.Parse(this.txt_populationSizeRast.Text);
            int generationSize = Int32.Parse(this.txt_generationSizeRast.Text);
            double rangeUp = Double.Parse(this.txt_rangeUpRast.Text);
            double rangeDown = Double.Parse(this.txt_rangeDownRast.Text);
            Double crossoverPorbobility = Double.Parse(this.txt_crossoverProboblityRast.Text);
            this.rEvolution = new RastringEvolution(populationSize, crossoverPorbobility, rangeUp,rangeDown, generationSize);
            chrt_populationBeforeLoadRast(this.rEvolution.population);
        }

        private void btn_nextGenerationRast_Click(object sender, EventArgs e)
        {
            this.chrt_populationBeforeLoadRast(this.rEvolution.population);
            List<Thing> nGeneration = this.rEvolution.GenerateNextGeneration();
            // chrt_populationAfterLoad(nGeneration);
            this.rEvolution.GenerationGap(nGeneration);
            this.chrt_populationAfterLoadRast(this.rEvolution.population);
        }

        private void btn_mutatePopulationRast_Click(object sender, EventArgs e)
        {
            this.rEvolution.population = this.rEvolution.MutatePopulationGaussian(ref this.rEvolution.population);
            chrt_populationBeforeLoadRast(this.rEvolution.population);
            load_labelRast();
        }

        private void btn_mutateAndNextRast_Click(object sender, EventArgs e)
        {
            chrt_populationBeforeLoadRast(this.rEvolution.population);
            List<Thing> nGeneration = this.rEvolution.GenerateNextGeneration();
            nGeneration = this.rEvolution.MutatePopulationGaussian(ref nGeneration);
            // chrt_populationAfterLoad(nGeneration);
            this.rEvolution.GenerationGap(nGeneration);
            chrt_populationAfterLoadRast(this.rEvolution.population);
            load_labelRast();
        }

     


        private void chrt_populationBeforeLoadRast(List<Thing> population)
        {
            this.chrt_populationBeforeRast.Series["Fitness"].Points.Clear();
            int i = 0;
            foreach (Thing athing in population)
            {
                this.chrt_populationBeforeRast.Series["Fitness"].Points.AddXY(i, athing.fitnessValue);
                i++;

            }
        }

        private void chrt_populationAfterLoadRast(List<Thing> population)
        {
            this.chrt_populationAfterRast.Series["Fitness"].Points.Clear();
            int i = 0;
            foreach (Thing athing in population)
            {
                this.chrt_populationAfterRast.Series["Fitness"].Points.AddXY(i, athing.fitnessValue);
                i++;

            }
        }

        private void load_labelRast()
        {
            lbl_meanRast.Text = MyMath.mean(this.rEvolution.population) + "";
            lbl_medianRast.Text = MyMath.median(this.rEvolution.population) + "";
            lbl_bestRast.Text = this.rEvolution.population[0].fitnessValue + "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
