using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Wyczysc_Click(object sender, EventArgs e)
        {
            Waga.Text = "";
            Wzrost.Text = "";
            Wynik.Text = "";
            Kilogramy.Checked = false;
            Funty.Checked = false;
            Wynik.BackColor = Color.White;
            label1.Text = "";
            label2.Text = "";
        }

        private void Oblicz_Click(object sender, EventArgs e)
        {
            double waga = Convert.ToDouble(Waga.Text);
            double wzrost = Convert.ToDouble(Wzrost.Text);
            double wynik = 0.0;
            string wynik2;
            bool blad = false;
            bool blad2 = false;
            bool blad3 = false;

            
            if (Kilogramy.Checked)
            {
                wynik = waga / (wzrost * wzrost);
            }

            else if (Funty.Checked)
            {
                waga = waga / 2.205; // przekształcenie funtów w kilogramy
                wynik = waga / (wzrost * wzrost);
            }

            if (wzrost > 2.4)
            {
                blad = true;
            }

            if (Funty.Checked == false && Kilogramy.Checked == false)
            {
                blad2 = true;
            }

            if (waga < 0 || wzrost < 0)
            {
                blad3 = true;
            }


            if (wynik < 16)
            {
                wynik2 = "Wygłodzenie.  Jesteś wygłodzony/na! Jeśli podałaś prawidłowe wartości wagi i wzrostu, " +
                     "to powinnaś jak najprędzej udać się do lekarza.";
                Wynik.BackColor = Color.Aquamarine;
            }

            else if (wynik >= 16 && wynik < 17)
            {
                wynik2 = "Wychudzenie. Jesteś wychudzony/na! Prawdopodobne cierpisz na anoreksję, " +
                    "lub chorujesz na ciężką chorobę. Powinnaś skontaktować się z lekarzem.";
                Wynik.BackColor = Color.MediumSpringGreen;
            }

            else if (wynik >= 17 && wynik < 18.5)
            {
                wynik2 = "Niedowaga. Masz niedowagę. Jeśli nie masz szczupłej wysportowanej sylwetki ciała wynikającej np. z " +
                    "profesjonalnych treningów, weź pod uwagę zwiększenie swojej wagi - powinna być nieco wyższa.";
                Wynik.BackColor = Color.SpringGreen;
            }

            else if (wynik >= 18.5 && wynik < 25)
            {
                wynik2 = "Wartość Prawidłowa. Nie pozostaje Ci nic innego jak pracować nad " +
                    "utrzymaniem odpowiedniej wagi, oraz zadbanie o inne aspekty zdrowotne.";
                Wynik.BackColor = Color.Chartreuse;
            }

            else if (wynik >= 25 && wynik < 30)
            {
                wynik2 = "Nadwaga. Zadbaj o siebie - swoje zdrowie i wygląd. Zasługujesz na to! " +
                    "Pod opieką specjalistów łatwo możesz zejść do prawidłowej wagi.";
                Wynik.BackColor = Color.YellowGreen;
            }

            else if (wynik >= 30 && wynik < 35)
            {
                wynik2 = "I Stopień Otyłości. Zadbaj o siebie - swoje zdrowie i wygląd. Zasługujesz na to! " +
                    "Pod opieką specjalistów łatwo możesz zejść do prawidłowej wagi.";
                Wynik.BackColor = Color.Chocolate;
            }

            else if (wynik >= 35 && wynik < 40)
            {
                wynik2 = "II Stopień Otyłości. Zadbaj o siebie - swoje zdrowie i wygląd. Zasługujesz na to! " +
                    "Pod opieką specjalistów łatwo możesz zejść do prawidłowej wagi.";
                Wynik.BackColor = Color.OrangeRed;
            }

            else
            {
                wynik2 = "Otyłość Skrajna. Nie jest dobrze! Masz skrajną otyłość. " +
                    "Jeśli nie jesteś jeszcze pod kontrolą lekarza, udaj się do niego natychmiast!";
                Wynik.BackColor = Color.Red;
            }


            if (blad == true)
            {
                label1.Text = "Podaj wzrost w metrach!";
                Wynik.BackColor = Color.White;
            }

            else if (blad2 == true)
            {
                label2.Text = "Wybierz jednostkę masy!";
                Wynik.BackColor = Color.White;
            }

            else if (blad3 == true)
            {
                Wynik.Text = "Podaj poprawne wartości!";
                Wynik.ForeColor = Color.Red;
                Wynik.BackColor = Color.White;
            }

            else
            {
                Wynik.Text = "Twoje BMI wynosi: " + wynik.ToString("#.##") + ".\r\n" + wynik2;
                label1.Text = "";
                label2.Text = "";
            }
        }

        private void Wyjdz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
