using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prüfung_Gewichtung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wenn Textboxen leer
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
                MessageBox.Show("Gib eine Punktezahl im WISO Teil an du Spast!!!!!");
                return; //er übergibt buchstäblich NICHTS zurück an die Methode und stoppt den weiteren Programmablauf
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
                MessageBox.Show("Gib eine Punktezahl im Kernqualifikations Teil an du Spast!!!!!");
                return;
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
                MessageBox.Show("Gib eine Punktezahl im Fachqualifikations Teil an du Spast!!!!!");
                return;
            }

            double wiso = Convert.ToDouble(textBox2.Text);
            double ga1 = Convert.ToDouble(textBox4.Text);
            double ga2 = Convert.ToDouble(textBox3.Text);
            if (wiso > 100)
            {
                MessageBox.Show("über 100 Punkte sind nicht möglich du Spast!!!!!");
                return;
            }
            if (ga1 > 100)
            {
                MessageBox.Show("über 100 Punkte sind nicht möglich du Spast!!!!!");
                return;
            }
            if (ga2 > 100)
            {
                MessageBox.Show("über 100 Punkte sind nicht möglich du Spast!!!!!");
                return;
            }
            //Berechne die einzelnen Gewichtungen
            double WISO = wiso * 0.2;
            double GA2 = ga2 * 0.4;
            double GA1 = ga1 * 0.4;
            //Ziehe alle oben Berechneten % zusammen
            double gesamt = WISO + GA2 + GA1;
            //Ausgabe
            textBox1.Text = Convert.ToString(gesamt);
            label12.Visible = true;
            label17.Visible = false; //gesamtergebnis label
            label18.Visible = false; //gesamtergebnis label %
            textBox6.Visible = false; //gesamtergebnis textBox
            if (gesamt >= 51)
                {
                label12.Text = "Du hast den schriftlichen Teil Bestanden, Glückwunsch!";
                label12.ForeColor = Color.Green;
            }
            else
            {
                label12.Text = "Schade, gib jetzt alles in der Mündlichen Prüfung!!";
                label12.ForeColor = Color.Red;
            }
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //wenn Textboxen leer
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
                MessageBox.Show("Mach jetzt die verdammte Projektarbeit du Spast!!!!!");
                return;

            }
            double pr = Convert.ToDouble(textBox5.Text);
            if (pr > 100)
            {
                MessageBox.Show("über 100 % sind nicht möglich du Spast!!!!!");
            }
           
            label17.Visible = false; //gesamtergebnis label
            label18.Visible = false; //gesamtergebnis label %
            textBox6.Visible = false; //gesamtergebnis textBox
            label19.Visible = true;
            if (pr >= 51)
            {
                label19.Text = "Bestanden, Glückwunsch!";
                label19.ForeColor = Color.Green;
            }
            else
            {
                label19.Text = "du kannst nix!";
                label19.ForeColor = Color.Red;                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label18.Visible = true; //gesamtergebnis label %
            textBox6.Visible = true; //gesamtergebnis textBox
            label17.Visible = true; //Gesamt FI Label

            //schriftlicher Teil leer
            if (textBox5.Text == "")
            {
                MessageBox.Show("Bitte geben sie die Punkte/Das Ergebnis des schriftlichen Teils an!"); textBox5.Text = "0";
                return;
            }
          
            // Projektarbeit leer
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bitte schließen sie die Projektarbeit ab!");
                textBox1.Text = "0";
                return;
            }
          

            double project = Convert.ToDouble(textBox5.Text);
            double schrift = Convert.ToDouble(textBox1.Text);
            double PROJECT = project * 0.5;
            double SCHRIFT = schrift * 0.5;
            double erg = (PROJECT + SCHRIFT);
           
            textBox6.Text = Convert.ToString(erg);
            

            if (erg >= 51)
            {
                label17.Text = "Bestanden! Freibier, Koks und Nutten!!!!1";
                label17.ForeColor = Color.Green;
            }
            else
            {
                label17.Text = "Was kannst du eigentlich?";
                label17.ForeColor = Color.Red;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
