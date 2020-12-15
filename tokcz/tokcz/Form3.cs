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

        public Form3()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Év");
            int a = 1965;
            for (int i = 1965; i < 2026; i++)
            {
                dt.Rows.Add(a);
                a++;
            }
            comboBoxdate.DataSource = dt;
            comboBoxdate.DisplayMember = "Év";
            comboBoxdate.ValueMember = "Év";

            //Betöltő függvények eredményeinek betöltése a megfelelő listába
            Educations = GetEducations(@"C:\Users\admin\source\repos\IRF_Project\tokcz\suli.csv");
            FinishProbabilities = GetFinishProbabilities(@"C:\Users\admin\source\repos\IRF_Project\tokcz\atlag.csv");
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
            return Educations;
        }

        //atlag.CSV állomány felolvasása
        public List<FinishProbability> GetFinishProbabilities(string csvpath)
        {
            List<FinishProbability> finishProbabilities = new List<FinishProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    //A beolvasott sor elemekre való felbontása
                    var line = sr.ReadLine().Split(';');

                    //Minden iterációs lépésben a megfelelő listához hozzácsatolja az új objektumot
                    finishProbabilities.Add(new FinishProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfTerms = int.Parse(line[1]),
                        Probability = double.Parse(line[2]),
                    });
                }
            }

            //Ciklus zárása után visszatér a metódus a listával
            return FinishProbabilities;
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            textBoxdatas.Clear();
            if (textBoxfile.Text !="")
            {
                Educations = GetEducations(textBoxfile.Text);
            }
            string ev = comboBoxdate.SelectedValue.ToString();

            //Véletlenszám generátor
            Random rng = new Random(1234);

            for (int year = 1965; year <= int.Parse(ev); year++)
            {
                //Végigmegyünk az összes személyen
                for (int i = 0; i < Educations.Count; i++)
                {
                    //Szimulációs lépés
                    Education education = Educations[i];
                    //Ha nem tanuló már, ugrunk a következő lépésre
                    if (!education.IsPupil) continue;
                    byte age = (byte)(year - education.StartYear);

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

                int nbrOfMales = (from x in Educations
                                  where x.Gender == Gender.Male && x.IsPupil
                                  select x).Count();
                int nbrOfFemales = (from x in Educations
                                    where x.Gender == Gender.Female && x.IsPupil
                                    select x).Count();
                Console.WriteLine(string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
                textBoxdatas.AppendText(string.Format("Év:{0} Fiuk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales) + Environment.NewLine);
            }
        }

        private void buttonbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxfile.Text = ofd.FileName;
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.WriteLine(textBoxdatas.Text);
            }
        }
    }
}
