namespace ProjectXY
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_best = new System.Windows.Forms.Label();
            this.lbl_median = new System.Windows.Forms.Label();
            this.lbl_mean = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_mutateAndNextGeneration = new System.Windows.Forms.Button();
            this.btn_mutatePopulation = new System.Windows.Forms.Button();
            this.btn_nextGeneration = new System.Windows.Forms.Button();
            this.chrt_populationBefore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_populationAfter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_generationSize = new System.Windows.Forms.TextBox();
            this.txt_crossoverPorbobility = new System.Windows.Forms.TextBox();
            this.txt_populationSize = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chrt_populationBeforeRast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_mutateAndNextRast = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chrt_populationAfterRast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_nextGenerationRast = new System.Windows.Forms.Button();
            this.txt_generationSizeRast = new System.Windows.Forms.TextBox();
            this.btn_mutatePopulationRast = new System.Windows.Forms.Button();
            this.txt_rangeUpRast = new System.Windows.Forms.TextBox();
            this.btn_generateRastring = new System.Windows.Forms.Button();
            this.txt_crossoverProboblityRast = new System.Windows.Forms.TextBox();
            this.txt_populationSizeRast = new System.Windows.Forms.TextBox();
            this.lbl_bestRast = new System.Windows.Forms.Label();
            this.lbl_medianRast = new System.Windows.Forms.Label();
            this.lbl_meanRast = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_rangeDownRast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rangeDown = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_rangeUp = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationAfter)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationBeforeRast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationAfterRast)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1408, 777);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1400, 719);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_rangeDown);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_rangeUp);
            this.panel1.Controls.Add(this.lbl_best);
            this.panel1.Controls.Add(this.lbl_median);
            this.panel1.Controls.Add(this.lbl_mean);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_mutateAndNextGeneration);
            this.panel1.Controls.Add(this.btn_mutatePopulation);
            this.panel1.Controls.Add(this.btn_nextGeneration);
            this.panel1.Controls.Add(this.chrt_populationBefore);
            this.panel1.Controls.Add(this.chrt_populationAfter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_generationSize);
            this.panel1.Controls.Add(this.txt_crossoverPorbobility);
            this.panel1.Controls.Add(this.txt_populationSize);
            this.panel1.Controls.Add(this.btn_run);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 715);
            this.panel1.TabIndex = 28;
            // 
            // lbl_best
            // 
            this.lbl_best.AutoSize = true;
            this.lbl_best.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_best.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_best.Location = new System.Drawing.Point(1166, 73);
            this.lbl_best.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_best.Name = "lbl_best";
            this.lbl_best.Size = new System.Drawing.Size(60, 20);
            this.lbl_best.TabIndex = 47;
            this.lbl_best.Text = "label12";
            // 
            // lbl_median
            // 
            this.lbl_median.AutoSize = true;
            this.lbl_median.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_median.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_median.Location = new System.Drawing.Point(1166, 41);
            this.lbl_median.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_median.Name = "lbl_median";
            this.lbl_median.Size = new System.Drawing.Size(60, 20);
            this.lbl_median.TabIndex = 46;
            this.lbl_median.Text = "label13";
            // 
            // lbl_mean
            // 
            this.lbl_mean.AutoSize = true;
            this.lbl_mean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_mean.Location = new System.Drawing.Point(1166, 11);
            this.lbl_mean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mean.Name = "lbl_mean";
            this.lbl_mean.Size = new System.Drawing.Size(60, 20);
            this.lbl_mean.TabIndex = 45;
            this.lbl_mean.Text = "label14";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(1096, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Best";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1094, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Median";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1092, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Mean";
            // 
            // btn_mutateAndNextGeneration
            // 
            this.btn_mutateAndNextGeneration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_mutateAndNextGeneration.Location = new System.Drawing.Point(665, 66);
            this.btn_mutateAndNextGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mutateAndNextGeneration.Name = "btn_mutateAndNextGeneration";
            this.btn_mutateAndNextGeneration.Size = new System.Drawing.Size(344, 39);
            this.btn_mutateAndNextGeneration.TabIndex = 41;
            this.btn_mutateAndNextGeneration.Text = "Mutate Population AND NextGeneration";
            this.btn_mutateAndNextGeneration.UseVisualStyleBackColor = true;
            this.btn_mutateAndNextGeneration.Click += new System.EventHandler(this.btn_mutateAndNextGeneration_Click);
            // 
            // btn_mutatePopulation
            // 
            this.btn_mutatePopulation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_mutatePopulation.Location = new System.Drawing.Point(443, 67);
            this.btn_mutatePopulation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mutatePopulation.Name = "btn_mutatePopulation";
            this.btn_mutatePopulation.Size = new System.Drawing.Size(97, 39);
            this.btn_mutatePopulation.TabIndex = 40;
            this.btn_mutatePopulation.Text = "Mutate Population";
            this.btn_mutatePopulation.UseVisualStyleBackColor = true;
            this.btn_mutatePopulation.Click += new System.EventHandler(this.btn_mutatePopulation_Click);
            // 
            // btn_nextGeneration
            // 
            this.btn_nextGeneration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_nextGeneration.Location = new System.Drawing.Point(311, 66);
            this.btn_nextGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nextGeneration.Name = "btn_nextGeneration";
            this.btn_nextGeneration.Size = new System.Drawing.Size(97, 39);
            this.btn_nextGeneration.TabIndex = 39;
            this.btn_nextGeneration.Text = "NextGeneration";
            this.btn_nextGeneration.UseVisualStyleBackColor = true;
            this.btn_nextGeneration.Click += new System.EventHandler(this.btn_nextGeneration_Click);
            // 
            // chrt_populationBefore
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_populationBefore.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_populationBefore.Legends.Add(legend1);
            this.chrt_populationBefore.Location = new System.Drawing.Point(15, 110);
            this.chrt_populationBefore.Margin = new System.Windows.Forms.Padding(2);
            this.chrt_populationBefore.Name = "chrt_populationBefore";
            this.chrt_populationBefore.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelAngle = 90;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Fitness";
            this.chrt_populationBefore.Series.Add(series1);
            this.chrt_populationBefore.Size = new System.Drawing.Size(1379, 294);
            this.chrt_populationBefore.TabIndex = 38;
            this.chrt_populationBefore.Text = "chart1";
            // 
            // chrt_populationAfter
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_populationAfter.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_populationAfter.Legends.Add(legend2);
            this.chrt_populationAfter.Location = new System.Drawing.Point(15, 408);
            this.chrt_populationAfter.Margin = new System.Windows.Forms.Padding(2);
            this.chrt_populationAfter.Name = "chrt_populationAfter";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Fitness";
            this.chrt_populationAfter.Series.Add(series2);
            this.chrt_populationAfter.Size = new System.Drawing.Size(1379, 294);
            this.chrt_populationAfter.TabIndex = 37;
            this.chrt_populationAfter.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(758, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "generationSize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(451, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "crossoverPorbobility";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(332, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "populationSize";
            // 
            // txt_generationSize
            // 
            this.txt_generationSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_generationSize.Location = new System.Drawing.Point(760, 36);
            this.txt_generationSize.Margin = new System.Windows.Forms.Padding(2);
            this.txt_generationSize.Name = "txt_generationSize";
            this.txt_generationSize.Size = new System.Drawing.Size(76, 20);
            this.txt_generationSize.TabIndex = 32;
            this.txt_generationSize.Text = "1000";
            // 
            // txt_crossoverPorbobility
            // 
            this.txt_crossoverPorbobility.Location = new System.Drawing.Point(464, 36);
            this.txt_crossoverPorbobility.Margin = new System.Windows.Forms.Padding(2);
            this.txt_crossoverPorbobility.Name = "txt_crossoverPorbobility";
            this.txt_crossoverPorbobility.Size = new System.Drawing.Size(76, 20);
            this.txt_crossoverPorbobility.TabIndex = 30;
            this.txt_crossoverPorbobility.Text = "0.9";
            // 
            // txt_populationSize
            // 
            this.txt_populationSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_populationSize.Location = new System.Drawing.Point(332, 36);
            this.txt_populationSize.Margin = new System.Windows.Forms.Padding(2);
            this.txt_populationSize.Name = "txt_populationSize";
            this.txt_populationSize.Size = new System.Drawing.Size(76, 20);
            this.txt_populationSize.TabIndex = 29;
            this.txt_populationSize.Text = "100";
            // 
            // btn_run
            // 
            this.btn_run.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_run.Location = new System.Drawing.Point(870, 11);
            this.btn_run.Margin = new System.Windows.Forms.Padding(2);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(126, 42);
            this.btn_run.TabIndex = 28;
            this.btn_run.Text = "Generate Sphere Colony";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1400, 719);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_rangeDownRast);
            this.panel2.Controls.Add(this.lbl_bestRast);
            this.panel2.Controls.Add(this.lbl_medianRast);
            this.panel2.Controls.Add(this.lbl_meanRast);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.chrt_populationBeforeRast);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_mutateAndNextRast);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.chrt_populationAfterRast);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_nextGenerationRast);
            this.panel2.Controls.Add(this.txt_generationSizeRast);
            this.panel2.Controls.Add(this.btn_mutatePopulationRast);
            this.panel2.Controls.Add(this.txt_rangeUpRast);
            this.panel2.Controls.Add(this.btn_generateRastring);
            this.panel2.Controls.Add(this.txt_crossoverProboblityRast);
            this.panel2.Controls.Add(this.txt_populationSizeRast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1396, 715);
            this.panel2.TabIndex = 42;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "generationSize";
            // 
            // chrt_populationBeforeRast
            // 
            chartArea3.Name = "ChartArea1";
            this.chrt_populationBeforeRast.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrt_populationBeforeRast.Legends.Add(legend3);
            this.chrt_populationBeforeRast.Location = new System.Drawing.Point(-20, 106);
            this.chrt_populationBeforeRast.Margin = new System.Windows.Forms.Padding(2);
            this.chrt_populationBeforeRast.Name = "chrt_populationBeforeRast";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.MarkerSize = 1;
            series3.Name = "Fitness";
            this.chrt_populationBeforeRast.Series.Add(series3);
            this.chrt_populationBeforeRast.Size = new System.Drawing.Size(1415, 294);
            this.chrt_populationBeforeRast.TabIndex = 38;
            this.chrt_populationBeforeRast.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Range Up";
            // 
            // btn_mutateAndNextRast
            // 
            this.btn_mutateAndNextRast.Location = new System.Drawing.Point(588, 64);
            this.btn_mutateAndNextRast.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mutateAndNextRast.Name = "btn_mutateAndNextRast";
            this.btn_mutateAndNextRast.Size = new System.Drawing.Size(235, 33);
            this.btn_mutateAndNextRast.TabIndex = 41;
            this.btn_mutateAndNextRast.Text = "Mutate Population AND NextGeneration";
            this.btn_mutateAndNextRast.UseVisualStyleBackColor = true;
            this.btn_mutateAndNextRast.Click += new System.EventHandler(this.btn_mutateAndNextRast_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "crossoverPorbobility";
            // 
            // chrt_populationAfterRast
            // 
            chartArea4.Name = "ChartArea1";
            this.chrt_populationAfterRast.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrt_populationAfterRast.Legends.Add(legend4);
            this.chrt_populationAfterRast.Location = new System.Drawing.Point(-20, 412);
            this.chrt_populationAfterRast.Margin = new System.Windows.Forms.Padding(2);
            this.chrt_populationAfterRast.Name = "chrt_populationAfterRast";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Fitness";
            this.chrt_populationAfterRast.Series.Add(series4);
            this.chrt_populationAfterRast.Size = new System.Drawing.Size(1418, 294);
            this.chrt_populationAfterRast.TabIndex = 37;
            this.chrt_populationAfterRast.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "populationSize";
            // 
            // btn_nextGenerationRast
            // 
            this.btn_nextGenerationRast.Location = new System.Drawing.Point(381, 64);
            this.btn_nextGenerationRast.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nextGenerationRast.Name = "btn_nextGenerationRast";
            this.btn_nextGenerationRast.Size = new System.Drawing.Size(153, 33);
            this.btn_nextGenerationRast.TabIndex = 39;
            this.btn_nextGenerationRast.Text = "NextGeneration";
            this.btn_nextGenerationRast.UseVisualStyleBackColor = true;
            this.btn_nextGenerationRast.Click += new System.EventHandler(this.btn_nextGenerationRast_Click);
            // 
            // txt_generationSizeRast
            // 
            this.txt_generationSizeRast.Location = new System.Drawing.Point(588, 29);
            this.txt_generationSizeRast.Margin = new System.Windows.Forms.Padding(2);
            this.txt_generationSizeRast.Name = "txt_generationSizeRast";
            this.txt_generationSizeRast.Size = new System.Drawing.Size(76, 20);
            this.txt_generationSizeRast.TabIndex = 32;
            this.txt_generationSizeRast.Text = "10000";
            // 
            // btn_mutatePopulationRast
            // 
            this.btn_mutatePopulationRast.Location = new System.Drawing.Point(203, 64);
            this.btn_mutatePopulationRast.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mutatePopulationRast.Name = "btn_mutatePopulationRast";
            this.btn_mutatePopulationRast.Size = new System.Drawing.Size(145, 33);
            this.btn_mutatePopulationRast.TabIndex = 40;
            this.btn_mutatePopulationRast.Text = "Mutate Population";
            this.btn_mutatePopulationRast.UseVisualStyleBackColor = true;
            this.btn_mutatePopulationRast.Click += new System.EventHandler(this.btn_mutatePopulationRast_Click);
            // 
            // txt_rangeUpRast
            // 
            this.txt_rangeUpRast.Location = new System.Drawing.Point(397, 29);
            this.txt_rangeUpRast.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rangeUpRast.Name = "txt_rangeUpRast";
            this.txt_rangeUpRast.Size = new System.Drawing.Size(76, 20);
            this.txt_rangeUpRast.TabIndex = 31;
            this.txt_rangeUpRast.Text = "5.12";
            // 
            // btn_generateRastring
            // 
            this.btn_generateRastring.Location = new System.Drawing.Point(690, 10);
            this.btn_generateRastring.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generateRastring.Name = "btn_generateRastring";
            this.btn_generateRastring.Size = new System.Drawing.Size(126, 37);
            this.btn_generateRastring.TabIndex = 28;
            this.btn_generateRastring.Text = "Generate Rastring Colony";
            this.btn_generateRastring.UseVisualStyleBackColor = true;
            this.btn_generateRastring.Click += new System.EventHandler(this.btn_generateRastring_Click);
            // 
            // txt_crossoverProboblityRast
            // 
            this.txt_crossoverProboblityRast.Location = new System.Drawing.Point(294, 29);
            this.txt_crossoverProboblityRast.Margin = new System.Windows.Forms.Padding(2);
            this.txt_crossoverProboblityRast.Name = "txt_crossoverProboblityRast";
            this.txt_crossoverProboblityRast.Size = new System.Drawing.Size(76, 20);
            this.txt_crossoverProboblityRast.TabIndex = 30;
            this.txt_crossoverProboblityRast.Text = "0.8";
            // 
            // txt_populationSizeRast
            // 
            this.txt_populationSizeRast.Location = new System.Drawing.Point(172, 29);
            this.txt_populationSizeRast.Margin = new System.Windows.Forms.Padding(2);
            this.txt_populationSizeRast.Name = "txt_populationSizeRast";
            this.txt_populationSizeRast.Size = new System.Drawing.Size(76, 20);
            this.txt_populationSizeRast.TabIndex = 29;
            this.txt_populationSizeRast.Text = "100";
            // 
            // lbl_bestRast
            // 
            this.lbl_bestRast.AutoSize = true;
            this.lbl_bestRast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bestRast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_bestRast.Location = new System.Drawing.Point(1006, 72);
            this.lbl_bestRast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bestRast.Name = "lbl_bestRast";
            this.lbl_bestRast.Size = new System.Drawing.Size(60, 20);
            this.lbl_bestRast.TabIndex = 53;
            this.lbl_bestRast.Text = "label12";
            // 
            // lbl_medianRast
            // 
            this.lbl_medianRast.AutoSize = true;
            this.lbl_medianRast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medianRast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_medianRast.Location = new System.Drawing.Point(1006, 40);
            this.lbl_medianRast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_medianRast.Name = "lbl_medianRast";
            this.lbl_medianRast.Size = new System.Drawing.Size(60, 20);
            this.lbl_medianRast.TabIndex = 52;
            this.lbl_medianRast.Text = "label13";
            // 
            // lbl_meanRast
            // 
            this.lbl_meanRast.AutoSize = true;
            this.lbl_meanRast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meanRast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_meanRast.Location = new System.Drawing.Point(1006, 10);
            this.lbl_meanRast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_meanRast.Name = "lbl_meanRast";
            this.lbl_meanRast.Size = new System.Drawing.Size(60, 20);
            this.lbl_meanRast.TabIndex = 51;
            this.lbl_meanRast.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(936, 72);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "Best";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(934, 41);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 49;
            this.label16.Text = "Median";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(932, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "Mean";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Range Down";
            // 
            // txt_rangeDownRast
            // 
            this.txt_rangeDownRast.Location = new System.Drawing.Point(490, 29);
            this.txt_rangeDownRast.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rangeDownRast.Name = "txt_rangeDownRast";
            this.txt_rangeDownRast.Size = new System.Drawing.Size(76, 20);
            this.txt_rangeDownRast.TabIndex = 54;
            this.txt_rangeDownRast.Text = "-5.12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(671, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Range Down";
            // 
            // txt_rangeDown
            // 
            this.txt_rangeDown.Location = new System.Drawing.Point(665, 33);
            this.txt_rangeDown.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rangeDown.Name = "txt_rangeDown";
            this.txt_rangeDown.Size = new System.Drawing.Size(76, 20);
            this.txt_rangeDown.TabIndex = 58;
            this.txt_rangeDown.Text = "-5.12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(578, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Range Up";
            // 
            // txt_rangeUp
            // 
            this.txt_rangeUp.Location = new System.Drawing.Point(572, 33);
            this.txt_rangeUp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rangeUp.Name = "txt_rangeUp";
            this.txt_rangeUp.Size = new System.Drawing.Size(76, 20);
            this.txt_rangeUp.TabIndex = 56;
            this.txt_rangeUp.Text = "5.12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 777);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationAfter)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationBeforeRast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_populationAfterRast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_mutateAndNextRast;
        private System.Windows.Forms.Button btn_mutatePopulationRast;
        private System.Windows.Forms.Button btn_nextGenerationRast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_populationBeforeRast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_populationAfterRast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_generationSizeRast;
        private System.Windows.Forms.TextBox txt_rangeUpRast;
        private System.Windows.Forms.TextBox txt_crossoverProboblityRast;
        private System.Windows.Forms.TextBox txt_populationSizeRast;
        private System.Windows.Forms.Button btn_generateRastring;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_mutateAndNextGeneration;
        private System.Windows.Forms.Button btn_mutatePopulation;
        private System.Windows.Forms.Button btn_nextGeneration;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_populationBefore;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_populationAfter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_generationSize;
        private System.Windows.Forms.TextBox txt_crossoverPorbobility;
        private System.Windows.Forms.TextBox txt_populationSize;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_best;
        private System.Windows.Forms.Label lbl_median;
        private System.Windows.Forms.Label lbl_mean;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_bestRast;
        private System.Windows.Forms.Label lbl_medianRast;
        private System.Windows.Forms.Label lbl_meanRast;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_rangeDownRast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rangeDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_rangeUp;
    }
}

