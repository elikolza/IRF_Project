using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tokcz.Entities;

namespace tokcz
{
    public partial class Form3 : Form
    {
        //Adatok betöltése
        List<Education> Educations = new List<Education>();
        List<FinishProbability> FinishProbabilities = new List<FinishProbability>();
        List<int> NbrOfMalesInYears = new List<int>();
        List<int> NbrOfFemalesInYears = new List<int>();

        //Véletlenszám generátor
        Random rng = new Random(1234);

        public Form3()
        {
            InitializeComponent();
        }

        private void Simulation()
        {
            //Betöltő függvények eredményeinek betöltése a megfelelő listába
            Educations = GetEducations(@"C:\Temp\suli.csv");
            FinishProbabilities = GetFinishProbabilities(@"C:\Temp\atlag.csv");
            for (int i = 1965; i < numericUpDown1.Value; i++)
            {
                for (int j = 0; j < Educations.Count; j++)
                {
                    StudStep(i, Educations[j]);
                }
                int NbrOfMales = (from x in Educations
                                  where x.Gender == Gender.Male && x.IsPupil
                                  select x).Count();
                int NBOfFemales = (from x in Educations
                                   where x.Gender == Gender.Female && x.IsPupil
                                   select x).Count();
                Console.WriteLine(string.Format("Év:{0} Fiúk:{1} Lányok:{2}", i, NbrOfMales, NBOfFemales));
                NbrOfMalesInYears.Add(NbrOfMales);
                NbrOfFemalesInYears.Add(NBOfFemales);
            }
        }

        //suli.CSV állomány felolvasása
        public List<Education> GetEducations(string csvpath)
        {
            List<Education> educations = new List<Education>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    //A beolvasott sor elemekre való felbontása
                    var line = sr.ReadLine().Split(';');

                    //Minden iterációs lépésben a megfelelő listához hozzácsatolja az új objektumot
                    educations.Add(new Education()
                    {
                        StartYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfTerms = int.Parse(line[2])
                    });
                }
            }

            //Ciklus zárása után visszatér a metódus a listával
            return educations;
        }

        //atlag.CSV állomány felolvasása
        public List<FinishProbability> GetFinishProbabilities(string csvpath)
        {
            List<FinishProbability> finishes = new List<FinishProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    finishes.Add(new FinishProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfTerms = int.Parse(line[1]),
                        Probability = double.Parse(line[2])
                    });
                }
            }

            return finishes;
        }

        private void StudStep(int year, Education education)
        {
            //Ha nem tanuló már, ugrunk a következő lépésre
            if (!education.IsPupil) return;
            int age = (int)(year - education.StartYear);

            //Iskola befejezésének valószínűség kikeresése
            if (education.IsPupil)
            {
                double Probability = (from x in FinishProbabilities
                                      where x.Age == age
                                      select x.Probability).FirstOrDefault();

                //Befejezik-e az iskolát?
                if (rng.NextDouble() <= Probability)
                {
                    Education diplomas = new Education();
                    diplomas.StartYear = year;
                    diplomas.NbrOfTerms = 0;
                    diplomas.Gender = (Gender)(rng.Next(1, 3));
                    Educations.Add(diplomas);
                }
            }
        }

        private void DisplayResults()
        {
            for (int years = 1965; years < numericUpDown1.Value; years++)
            {
                textBoxdatas.Text += "Szimulációs év: " + years + "\n \t Fiúk: " +
                                      NbrOfMalesInYears[years - 1965] + "\n \t Lányok: " +
                                      NbrOfFemalesInYears[years - 1965] + "\n \n";
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            NbrOfMalesInYears.Clear();
            NbrOfFemalesInYears.Clear();
            textBoxdatas.Clear();
            Simulation();
            DisplayResults();
        }

        private void buttonbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxfile.Text = ofd.FileName;
            }
        }
    }
}
