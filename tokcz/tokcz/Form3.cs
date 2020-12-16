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
        
        //Férfi és női lélekszámok tárolásásra alkalmas lista létrehozása
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
            Educations = GetEducations(@"C:\temp\suli.csv");
            FinishProbabilities = GetFinishProbabilities(@"C:\temp\atlag.csv");

            //Záróév megváltoztatása
            for (int i = 1965; i < numericUpDown1.Value; i++)
            {
                //Végigmegyünk a hallgatók összes egyedén
                for (int j = 0; j < Educations.Count; j++)
                {
                    StudStep(i, Educations[j]);
                }

                //Minden év végén lekérdezzük a két csoport egyedszámát
                int NbrOfMales = (from x in Educations
                                  where x.Gender == Gender.Male && x.IsPupil
                                  select x).Count();
                int NBOfFemales = (from x in Educations
                                   where x.Gender == Gender.Female && x.IsPupil
                                   select x).Count();
                Console.WriteLine(string.Format("Év:{0} Fiúk:{1} Lányok:{2}", i, NbrOfMales, NBOfFemales));
                //Lélekszámok tárolásásra alkalmas listák adatokkal való feltöltése
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
                        P = double.Parse(line[2])
                    });
                }
            }

            return finishes;
        }

        private void StudStep(int year, Education education)
        {
            //Ha nem tanuló már, ugrunk a következő lépésre
            if (!education.IsPupil) return;
            //Adott személy félévének száma a sulikezdés éve alapján
            int trm = (int)(year - education.StartYear);

            //Iskola befejezésének valószínűség kikeresése
            if (education.IsPupil)
            {
                double Probability = (from x in FinishProbabilities
                                      where x.NbrOfTerms == trm
                                      select x.P).FirstOrDefault();

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
            //Szimuláció évein végigmegyünk
            for (int years = 1965; years < numericUpDown1.Value; years++)
            {
                richTextBox1.Text += "Szimulációs év: " + years + "\n \t Fiúk: " +
                                      NbrOfMalesInYears[years - 1965] + "\n \t Lányok: " +
                                      NbrOfFemalesInYears[years - 1965] + "\n \n";
            }
        }

        private void buttonbrowse_Click(object sender, EventArgs e)
        {
            //Ok gomb lenyomása után a felette lévő Textboxba kerül a suli fájl elérési útvonala
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxfile.Text = ofd.FileName;
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            //Szimuláció indítása előtt a RichTextBox és a lélekszám listák tartalmainak ürítése
            NbrOfMalesInYears.Clear();
            NbrOfFemalesInYears.Clear();
            richTextBox1.Clear();
            Simulation();
            DisplayResults();
        }
    }
}
