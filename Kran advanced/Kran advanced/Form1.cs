using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kran_advanced {


    public partial class Form1 : Form {
    Kran kran = new Kran();

        public Form1() {
            InitializeComponent();
        }
        public void Haken_Ein(object sender, EventArgs e) {
            kran.HakenEin(haken);
        }

        private void Haken_Aus(object sender, EventArgs e) {
            kran.HakenAus(haken);
        }

        private void Arm_Ein(object sender, EventArgs e) {
            kran.ArmEin(arm, haken);
        }

        private void Arm_Aus(object sender, EventArgs e) {
            kran.ArmAus(arm, haken);
        }

        private void Basis_Links(object sender, EventArgs e) {
            kran.BasiLinks(basi, arm, haken, high);
        }

        private void Basis_Rechts(object sender, EventArgs e) {
            kran.BasiRechts(basi, arm, haken, high);
        }


        private void Kran_Aus(object sender, EventArgs e) {
            kran.KranAus(basi, arm, haken, high);
        }

        private void Kran_Ein(object sender, EventArgs e) {
            kran.KranEin(basi, arm, haken, high);
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            if (RadioArmAus.Checked) {
                kran.ArmAus(arm, haken);
            }
            if (RadioArmEin.Checked) {
                kran.ArmEin(arm, haken);
            }
            if (RadioHakenAus.Checked) {
                kran.HakenAus(haken);
            }
            if (RadioHakenEin.Checked) {
                kran.HakenEin(haken);
            }
            if (RadioKranLInks.Checked) {
                kran.BasiLinks(basi, arm, haken, high);
            }
            if (RadioKranRechts.Checked) {
                kran.BasiRechts(basi, arm, haken, high);
            }
            if (RadioKranAus.Checked) {
                kran.KranAus(basi, arm, haken, high);
            }
            if (RadioKranEin.Checked) {
                kran.KranEin(basi, arm, haken, high);
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
        }
    }
}
