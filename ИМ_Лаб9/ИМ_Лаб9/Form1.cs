using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИМ_Лаб9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N;
        double[] probabilities;
        double[] x = new double[5] { 2, 23, 42, 12, 4 };
        int[] ni = new int[5];

        double[] empirical_prob;
        double empirical_average;
        double dispersion;
        double relE;
        double relD;
        double chi_squared;

        public void Calculate()
        {
            Random rand = new Random();
            N = (int)numericUpDown6.Value;
            if (N == 0) N = 1;
            
            double prob_5 = 1 - (double)numericUpDown1.Value - 
                                (double)numericUpDown2.Value - 
                                (double)numericUpDown3.Value - 
                                (double)numericUpDown4.Value;
            probabilities = new double[5] 
            { 
                (double)numericUpDown1.Value, 
                (double)numericUpDown2.Value, 
                (double)numericUpDown3.Value, 
                (double)numericUpDown4.Value, 
                prob_5 
            };

            ni = new int[5]; 
            empirical_prob = new double[5];

            double summ = 0;
            for (int i = 0; i < 5; i++) summ += probabilities[i];
            
            if (summ != 1)
            {
                MessageBox.Show("Неверно введены данные",
                    "Ошибка",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            }

            //Подсчет частоты хначения xi
            for (int i = 0; i < N; i++)
            {
                var p = rand.NextDouble();
                ni[GetEvent(p)]++;
            }

            //Вычисление эмпирических вероятностей
            for (int i = 0; i < 5; i++)
            {
                empirical_prob[i] = (double)(ni[i]) / (double)N;
            }

            //Вычисление эмпирического среднего
            empirical_average = 0;
            for (int i = 0; i < 5; i++)
            {
                empirical_average += probabilities[i] * empirical_prob[i];
            }

            //Вычисление мат ожидания
            double Ex = 0;
            for (int i = 0; i < 5; i++)
            {
                Ex += probabilities[i] * x[i];
            }

            //Вычисление дисперсии
            dispersion = 0;
            for(int i = 0; i < 5; i++)
            {
                dispersion += probabilities[i] * (x[i] - Ex) * (x[i] - Ex);
            }

            //Вычисление эмпирической дисперсии
            double empirical_dispersion = 0;
            for(int i = 0; i < 5; i++)
            {
                empirical_dispersion = empirical_prob[i] * x[i] * x[i] 
                                    - empirical_average 
                                    * empirical_average;

            }

            //Вычисление абсолютной погрешноси
            double absE = Math.Abs((empirical_average - Ex));
            double absD = Math.Abs((empirical_dispersion - dispersion));

            //Вычисление относительной погрешности RelativeE RelativeD
            relE = absE / Math.Abs(Ex);
            relD = absD / Math.Abs(dispersion);

            //Вычисление статистики Хи квадрат
            chi_squared = 0;
            for(int i = 0; i < 5; i++)
            {
                chi_squared += (ni[i] * ni[i]) / (N * probabilities[i]);
            }
            chi_squared -= N;
        }

        private int GetEvent(double p)
        {
            int i = 0;
            while (p >= 0)
            {
                p -= probabilities[i];
                i++;
            }

            return i - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
            double chi = 9.488;
            l_empirical_prob.Text = "Эмпирические вероятности: \n";
            for (int i = 0; i < 5;i++) {
                l_empirical_prob.Text += empirical_prob[i] + "  ";
            }
            l_empirical_average.Text = "Эмпирическое среднее: " + empirical_average;
            l_dispersion.Text = "Дисперсия: " + dispersion;
            l_relE.Text = "Относительная погрешность среднего: \n" + relE;
            l_relD.Text = "Относительная погрешность дисперсии: \n" + relD;
            l_chi_squared.Text = "Критерий хи квадрат: \n" + chi_squared;
            if (chi_squared > chi) l_chi_squared.Text += " > 9.488 is true";
            else l_chi_squared.Text += " > 9.488 is false";
            for (int i = 0; i < 5; i++)
            {
                var value = (float)ni[i] / N;
                chart1.Series[0].Points.AddXY(i + 1, value);
            }
        }
    }
}
