namespace ИМ_Лаб9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.l_empirical_prob = new System.Windows.Forms.Label();
            this.l_empirical_average = new System.Windows.Forms.Label();
            this.l_dispersion = new System.Windows.Forms.Label();
            this.l_relE = new System.Windows.Forms.Label();
            this.l_relD = new System.Windows.Forms.Label();
            this.l_chi_squared = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(368, 12);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(581, 442);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вероятность 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вероятность 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вероятность 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вероятность 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вероятность 5 (auto calculate)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество экспериментов:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(242, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(242, 63);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(242, 95);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Location = new System.Drawing.Point(242, 127);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown4.TabIndex = 17;
            this.numericUpDown4.Value = new decimal(new int[] {
            12,
            0,
            0,
            131072});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(242, 198);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown6.TabIndex = 19;
            // 
            // l_empirical_prob
            // 
            this.l_empirical_prob.AutoSize = true;
            this.l_empirical_prob.Location = new System.Drawing.Point(12, 434);
            this.l_empirical_prob.Name = "l_empirical_prob";
            this.l_empirical_prob.Size = new System.Drawing.Size(226, 20);
            this.l_empirical_prob.TabIndex = 20;
            this.l_empirical_prob.Text = "Эмпирические вероятности:";
            // 
            // l_empirical_average
            // 
            this.l_empirical_average.AutoSize = true;
            this.l_empirical_average.Location = new System.Drawing.Point(12, 300);
            this.l_empirical_average.Name = "l_empirical_average";
            this.l_empirical_average.Size = new System.Drawing.Size(192, 20);
            this.l_empirical_average.TabIndex = 21;
            this.l_empirical_average.Text = "Эмпирическое среднее:";
            // 
            // l_dispersion
            // 
            this.l_dispersion.AutoSize = true;
            this.l_dispersion.Location = new System.Drawing.Point(12, 334);
            this.l_dispersion.Name = "l_dispersion";
            this.l_dispersion.Size = new System.Drawing.Size(99, 20);
            this.l_dispersion.TabIndex = 22;
            this.l_dispersion.Text = "Дисперсия: ";
            // 
            // l_relE
            // 
            this.l_relE.AutoSize = true;
            this.l_relE.Location = new System.Drawing.Point(12, 485);
            this.l_relE.Name = "l_relE";
            this.l_relE.Size = new System.Drawing.Size(312, 20);
            this.l_relE.TabIndex = 23;
            this.l_relE.Text = "Относительная погрешность среднего:";
            // 
            // l_relD
            // 
            this.l_relD.AutoSize = true;
            this.l_relD.Location = new System.Drawing.Point(426, 485);
            this.l_relD.Name = "l_relD";
            this.l_relD.Size = new System.Drawing.Size(322, 20);
            this.l_relD.TabIndex = 24;
            this.l_relD.Text = "Относительная погрешность дисперсии:";
            // 
            // l_chi_squared
            // 
            this.l_chi_squared.AutoSize = true;
            this.l_chi_squared.Location = new System.Drawing.Point(12, 369);
            this.l_chi_squared.Name = "l_chi_squared";
            this.l_chi_squared.Size = new System.Drawing.Size(174, 20);
            this.l_chi_squared.TabIndex = 25;
            this.l_chi_squared.Text = "Критерий хи квадрат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 540);
            this.Controls.Add(this.l_chi_squared);
            this.Controls.Add(this.l_relD);
            this.Controls.Add(this.l_relE);
            this.Controls.Add(this.l_dispersion);
            this.Controls.Add(this.l_empirical_average);
            this.Controls.Add(this.l_empirical_prob);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label l_empirical_prob;
        private System.Windows.Forms.Label l_empirical_average;
        private System.Windows.Forms.Label l_dispersion;
        private System.Windows.Forms.Label l_relE;
        private System.Windows.Forms.Label l_relD;
        private System.Windows.Forms.Label l_chi_squared;
    }
}

