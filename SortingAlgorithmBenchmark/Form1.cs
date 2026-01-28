using System;
using System.Diagnostics;

namespace SortingAlgorithmBenchmark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbNumarElemente.Items.Add("1000");
            cmbNumarElemente.Items.Add("5000");
            cmbNumarElemente.Items.Add("10000");
            cmbNumarElemente.Items.Add("20000");
            cmbNumarElemente.Items.Add("50000");
            cmbNumarElemente.Items.Add("100000");
            cmbNumarElemente.SelectedIndex = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            panelGrafic.Controls.Clear();
            if (!int.TryParse(cmbNumarElemente.Text, out int numarElemente))
            {
                MessageBox.Show("Te rog selecteaza un numar valid!");
                return;
            }
            int[] dateInitiale = GenerareDateRandom(numarElemente);

            var algoritmi = new List<ISortingAlgorithm>
            {
                new BubbleSort(),
                new InsertionSort(),
                new SelectionSort(),
                new QuickSort(),
                new SystemSort(),
                new MergeSort()
            };
            int pozitieY = 20;

            Color[] culori = { 
                Color.Red,
                Color.OrangeRed,
                Color.Purple,
                Color.SeaGreen,
                Color.Orange,
                Color.DodgerBlue
            };
            int indexCuloare = 0;

            foreach(var alg in algoritmi)
            {
                int[] dateDeSortat = (int[])dateInitiale.Clone();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                alg.Sorteaza(dateDeSortat);
                sw.Stop();

                long timpMilisecunde = sw.ElapsedMilliseconds;
                AdaugaBaraGrafic(alg.Nume, timpMilisecunde, pozitieY, culori[indexCuloare % culori.Length]);
                pozitieY += 70;
                indexCuloare++;
                if (indexCuloare >= culori.Length) indexCuloare = 0;
            }
        }

        private void AdaugaBaraGrafic(string numeAlgoritm, long timp, int y, Color culoareBara)
        {
            Label lblNume = new Label();
            lblNume.Text = $"{numeAlgoritm}: {timp} ms";
            lblNume.Location = new Point(10, y);
            lblNume.AutoSize = true;
            lblNume.Font = new Font("Arial", 10, FontStyle.Bold);
            panelGrafic.Controls.Add(lblNume);

            Panel bara = new Panel();
            bara.Location = new Point(10, y + 25);
            bara.Height = 30;
            bara.BackColor = culoareBara;

            int latime = (int)timp;
            if (latime < 5) latime = 5;
            if (latime > panelGrafic.Width - 50) latime = panelGrafic.Width - 50;

            bara.Width = latime;

            panelGrafic.Controls.Add(bara);
        }

        private int[] GenerareDateRandom(int n)
        {
            Random rand = new Random();
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = rand.Next(0, 10000);
            }
            return vector;
        }

    }
}
