using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string[] Ort;
        double[] Menge;
        bool[] Hauptstadt;
        int index;
        bool Restart,draw;
        double Mittelwert;
        public Form1()
        {
            InitializeComponent();
            index = 0;
            Restart = false;
            this.Width = 544;
            this.Height = 91;
            draw = false;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int anzahl;
            if(!Restart)
            {
                anzahl = (int)numericUpDownMessstellenAnzahl.Value;
                Restart = true;
                Menge = new double[anzahl];
                Hauptstadt = new bool[Menge.Length];
                Ort = new string[Menge.Length];
                this.Width = 1145;
                this.Height = 617;
                numericUpDownNummerMessstellen.Maximum = Menge.Length;
            }
            else
            {
                Application.Restart();
            }
            

        }

       

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            double Mengecontrol = - 1;//zwischen Speicher
            Ort[index] = textBoxOrt.Text;
            //Werte und Typkontrolle der Menge
            try//Typ-Kontrolle
            {
                Mengecontrol = Convert.ToDouble(textBoxMenge.Text);
            }catch
            {
                MessageBox.Show("Bitte geben Sie eine Zahl ein");
            }
            if(Mengecontrol < 0 || Mengecontrol >5000) //Werte Kontrolle
            {

                MessageBox.Show("Nur Zahlen von 0 bis 5000 möglich");
            }
            else
            {
                Menge[index] = Mengecontrol;
                Mengecontrol = -1;
            }

            Hauptstadt[index] = checkBox1.Checked; // Hauptstadt oder keine Hauptstadt


            //listbox Alle Stationen
            listBoxMessstatioen.Items.Add(string.Format("{0}: {1} l/m²",Ort[index],Math.Round(Menge[index]),1));

            //listbox Hauptstäte
            if (checkBox1.Checked)
                listBoxHauptstadt.Items.Add(string.Format("{0}: {1} l/m²", Ort[index], Math.Round(Menge[index]),1));

            //Statistik
            double sum;
            sum = 0;
            for (int i = 0; i < index+1; i++)
            {
                sum = sum + Menge[i];
            }
            Mittelwert = sum /(index + 1);
            textBoxStatistik.Text = string.Format("Durchschnitt aller Stationen: {0} l/m² \r\n", Math.Round(Mittelwert, 1));

            double summehauptstadt = 0;
            int hilfe=0;
            for (int i = 0; i < index + 1; i++)
            {
                if (Hauptstadt[i])
                {
                    summehauptstadt += Menge[i];
                    hilfe++;
                }
            }

            double Mittelwerthauptstadt;
            if (hilfe<=0)
            {
                Mittelwerthauptstadt = 0;
            }else
            {
                Mittelwerthauptstadt  = summehauptstadt / hilfe;
            }
                 

            textBoxStatistik.Text += string.Format("Durchschnitt aller Stationen: {0} l/m² \r\n", Math.Round(Mittelwerthauptstadt, 1));

            numericUpDownNummerMessstellen.Value = index+1;
            index++;
            groupBoxMesspunkt.Text = string.Format("{0}. Messpunkt", index + 1);
            if (index == Menge.Length)
                buttonHinzufügen.Enabled = false;
            draw = true;
            pictureBoxDiagramm.Invalidate();
        }

        private void numericUpDownNummerMessstellen_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxDiagramm.Invalidate();
        }

        private void listBoxMessstatioen_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownNummerMessstellen.Value = listBoxMessstatioen.SelectedIndex + 1;
        }

        private void pictureBoxDiagramm_Paint(object sender, PaintEventArgs e)
        {
            if (draw)
            { 
                int Auswahl = (int)numericUpDownNummerMessstellen.Value;
                labelMessstelleName.Text = Ort[Auswahl - 1];
                Graphics dev = e.Graphics;
                float scal = ((float)pictureBoxDiagramm.Height - 40) / 10000;
                float breit = 50;
                float hohe = (scal * (float)Menge[Auswahl - 1]); //Menge = Wasser Menge
                float hohemitl = (scal * (float)Mittelwert);
                if(!Hauptstadt[Auswahl-1])
                {
                    dev.FillRectangle(Brushes.Black, 20, (pictureBoxDiagramm.Height - 20) - hohe, breit, hohe);
                }else
                {
                    dev.FillRectangle(Brushes.HotPink, 20, (pictureBoxDiagramm.Height - 20) - hohe, breit, hohe);
                }
                dev.FillRectangle(Brushes.Green, 20, (pictureBoxDiagramm.Height-20)  - hohemitl,60, 3);
        }
        }
    }
}
