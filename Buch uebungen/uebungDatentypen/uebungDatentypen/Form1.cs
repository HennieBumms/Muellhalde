using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uebungDatentypen {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private enum Farbe : int {
            Rot=1, Gelb=2, Blau=3
        }

        private void button1_Click(object sender, EventArgs e) {
            string name = "Hendrik Zabel";
            string city = "Bremen";
            int postalCode = 28213;
            string street = "Busestraße";
            string number = "2c";
            int age = 31;
            double gehalt = 0.0;

            Lbldisplay.Text = "Adresse:\n" +
                name + "\n" +
                street + " " + number + "\n" +
                postalCode + " " + city + "\n\n" +
                "Alter: " + age + "\n" +
                "Gehalt: " + gehalt + "\n"+
                "Farbe: " + Farbe.Gelb + " " + (int) Farbe.Gelb;
        }

        private void button2_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
        }

        public void Timer1_Tick_1(object sender, EventArgs e) {
            LinksOben.Location = new Point(LinksOben.Location.X - 10, LinksOben.Location.Y - 10);
            LinksUnten.Location = new Point(LinksUnten.Location.X - 10, LinksUnten.Location.Y + 10);
            RechtsOben.Location = new Point(RechtsOben.Location.X + 10, RechtsOben.Location.Y - 10);
            RechtsUnten.Location = new Point(RechtsUnten.Location.X + 10, RechtsUnten.Location.Y + 10);
        }

        public void ValueChanged(object sender, EventArgs e) {
            TextOutput.Text = "Wert: " + NumInput.Value;
        }

        private void SalaryCalc_Click(object sender, EventArgs e) {
            if (SalaryInput.Text != "") {
                double input = Convert.ToDouble(SalaryInput.Text);
                double output = 0.0;
                if (input <= 12000) {
                    output = input / 100 * 12;
                } else if (input > 12000 && input <= 20000) {
                    output = input / 100 * 15;
                } else if (input > 20000 && input <= 30000) {
                    output = input / 100 * 20;
                } else {
                    output = input / 100 * 25;
                }
                SalaryOutput.Text = "Steuerbetrag: " + output;
            }
        }

    }
}
