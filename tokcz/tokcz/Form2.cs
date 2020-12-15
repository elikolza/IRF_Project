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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using tokcz.Entities;

namespace tokcz
{
    public partial class Form2 : Form
    {
        //Adatkötött lista
        BindingList<Data> datas = new BindingList<Data>();

        //Microsoft Excel alkalmazás
        Excel.Application xlApp;

        //Munkafüzet 
        Excel.Workbook xlWb;

        //Munkalap munkafüzeten belül
        Excel.Worksheet xlSheet;

        private void CreateExcel()
        {
            try
            {
                //Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                //Új munkafüzet
                xlWb = xlApp.Workbooks.Add(Missing.Value);

                //Új munkalap
                xlSheet = xlWb.ActiveSheet;

                //Tábla létrehozása
                CreateTable();

                //Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }

            //Hibakezelés beépített hibaüzenettel
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                //Hiba esetén az Excel applikáció bezárása automatikusan
                xlWb.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWb = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            //Tömb létrehozása, mely tartalmazza a tábla fejléceit + egy extra oszlop fejlécét
            string[] headers = new string[]
            {
                "Occupation",
                "All workers",
                "All weekly",
                "Male workers",
                "Male weekly",
                "Female workers",
                "Female weekly",
            };

            string[] content = { dataGridView.Columns.ToString()};
            //Tömb elemeinek kiírása a munkalap első sorába
            /*for (int tömb = 0; tömb <= headers.Length; tömb++)
            {
                xlSheet.Cells[1, tömb + 1] = headers[tömb];
            }*/

            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                xlSheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        xlSheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        xlSheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        //Excel formázása
        private void FormatExcel()
        {
            //Utolsó sor
            int LastRowID = xlSheet.UsedRange.Rows.Count;
            //Utolsó oszlop
            int LastColID = xlSheet.UsedRange.Columns.Count;
            //Fejléc meghatározása
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1,1), GetCell(1,LastColID));
            //Fejléc betűtípusa dőlt
            headerRange.Font.Italic = true;
            //Fejléc függőleges elhelyzés
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            //Fejléc vízszintes elhelyzés 
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Fejléc kitöltése
            headerRange.EntireColumn.AutoFit();
            //Fejléc sormagasság
            headerRange.RowHeight = 45;
            //Fejléc kitöltési színe
            headerRange.Interior.Color = Color.Aquamarine;
            //Fejléc körüli szegély
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            //Tábla körüli szegély
            Excel.Range tableRange = xlSheet.get_Range(GetCell(1,1), GetCell(LastRowID, LastColID));
            //Tábla körüli szegly formázás
            tableRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            //Első oszlop meghatározás
            Excel.Range firstcolRange = xlSheet.get_Range(GetCell(2, 1), GetCell(LastRowID, 1));
            //Első oszlop betűtípus
            firstcolRange.Font.Bold = true;
            //Első oszlop háttér
            firstcolRange.Interior.Color = Color.LightCoral;
        }

        public Form2()
        {
            InitializeComponent();
            //A "data" lista összekötése a DataGridView-val
            dataGridView.DataSource = datas;
        }

        //file beolvasás eseménykezelője
        private void buttoncsv_Click(object sender, EventArgs e)
        {
            // Példányosít egyet a windows standard fájlmegnyitó ablakából
            OpenFileDialog ofd = new OpenFileDialog();

            //Alapértemezetten az exe fájlunk mappája fog megnyílni a dialógus ablakban
            ofd.InitialDirectory = Application.StartupPath;

            //A kiválasztható fájlformátumokat adjuk meg ezzel a sorral. Jelen esetben csak a csv-t fogadjuk el
            ofd.Filter = "Comma Seperated Values (*.csv,)|*.csv";

            //A csv lesz az alapértelmezetten kiválasztott kiterjesztés
            ofd.DefaultExt = "csv";

            //Ha ez igaz, akkor hozzáírja a megadott fájlnévhez a kiterjesztést, de érzékeli, ha a felhasználó azt is beírta és nem fogja duplán hozzáírni
            ofd.AddExtension = true;

            //Ez a sor megnyitja a dialógus ablakot és csak akkor engedi tovább futni a kódot, ha az ablakot az OK gombbal zárták be
            if (ofd.ShowDialog() != DialogResult.OK) return;

            //A StreamReader paraméterei:
            // 1) Fájlnév: itt azt a fájlnevet adjuk át, amit a felhasználó az ofd dialógusban megadott
            // 2) Karakterkódolás: megadható fixen, de érdemes inkább a Default opciót megadni, mert ez kiolvassa a fájlból, hogy milyen karakterkódolással lett eredetileg lementve
            using (StreamReader sr = new StreamReader(ofd.FileName,Encoding.Default))

            {
                //Az alábbi kódsor beolvassa ugyan a csv első sorát, de nem tárolja el változóban a tartalmát, hanem egyszerűen eldobja azt
                //sr.ReadLine()
                //Ettől a StreamReader továbblép a következő sorba, és a lenti ciklus a második sortól kezdve fogja felolvasni a sorokat
                //Addig ismételjük a ciklust, míg el nem érjük a fájl végét
                while(!sr.EndOfStream)
                {
                    //Ez a sor egy sor nevű tömbbe olvassa be a fájl következő sorát úgy, hogy a pontosvesszők mentén feldarabolja azt
                    string[] sor = sr.ReadLine().Split(',');

                    //Példányosítjuk a következő Data-t
                    Data d = new Data();

                    d.Occupation = sor[0];

                    try
                    {
                        d.All_workers = int.Parse(sor[1]);
                    }
                    catch
                    {

                    }

                    try
                    {
                        d.All_weekly = int.Parse(sor[2]);
                    }
                    catch
                    {

                    }
                    try
                    {
                        d.Male_workers = int.Parse(sor[3]);
                    }
                    catch
                    {

                    }
                    try
                    {
                        d.All_weekly = int.Parse(sor[4]);
                    }
                    catch
                    {

                    }
                    try
                    {
                        d.Female_workers = int.Parse(sor[5]);
                    }
                    catch
                    {

                    }
                    try
                    {
                        d.Female_weekly = int.Parse(sor[6]);
                    }
                    catch
                    {

                    }
                    //Az újonnan létrehozott Datat-t hozzáadjuk a datas listához
                    datas.Add(d);
                }
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(rowIndex);
        }

        private void buttonxls_Click(object sender, EventArgs e)
        {
            CreateExcel();
            FormatExcel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string oszlop, szures;
            oszlop = textBox1.Text;
            szures = textBox2.Text;
        }

        private void buttonmikro_Click(object sender, EventArgs e)
        {
            Form3 nf = new Form3();
            nf.Show();
        }
    }
}
