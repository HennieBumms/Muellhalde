using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listentausch {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BoxLeft.Items.Add("Gnocchi");
            BoxLeft.Items.Add("Fettucini");
            BoxLeft.Items.Add("Broccolli");
            BoxLeft.Items.Add("Blumenkohl");

            BoxRight.Items.Add("Käsemeyer");
            BoxRight.Items.Add("Keller");
            BoxRight.Items.Add("Blankenhagen");
            BoxRight.Items.Add("Zabel");

            BoxDeactivate.Items.Add("Gnocchi");
            BoxDeactivate.Items.Add("Fettucini");
            BoxDeactivate.Items.Add("Broccolli");
            BoxDeactivate.Items.Add("Blumenkohl");

            FillBoxNumbersWithRandomStuff();
        }

        private void FillBoxNumbersWithRandomStuff() {
            Random r = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i <= numbers.Length - 1; i++) {
                numbers[i] = r.Next(0, 30);
                BoxNumbers.Items.Add(numbers[i]);
            }
        }

        private void BtnSwitchToRight_Click(object sender, EventArgs e) {
            foreach (var v in BoxLeft.SelectedItems) {
                BoxRight.Items.Add(v);
            }
            foreach (var v in BoxRight.Items) {
                if (BoxLeft.Items.Contains(v)) {
                    BoxLeft.Items.Remove(v);
                }
            }
        }

        private void BtnSwitchToLeft_Click(object sender, EventArgs e) {
            foreach (var v in BoxRight.SelectedItems) {
                BoxLeft.Items.Add(v);
            }
            foreach (var v in BoxLeft.Items) {
                if (BoxRight.Items.Contains(v)) {
                    BoxRight.Items.Remove(v);
                }
            }
        }

        private void LeftRed_ValueChanged(object sender, EventArgs e) {
            ChangeColorOfLeftBox();
            LabelLeftRed.Text = "Rot: " + LeftRed.Value;
        }

        private void LeftGreen_ValueChanged(object sender, EventArgs e) {
            ChangeColorOfLeftBox();
            LabelLeftGreen.Text = "Grün: " + LeftGreen.Value;
        }

        private void LeftBlue_ValueChanged(object sender, EventArgs e) {
            ChangeColorOfLeftBox();
            LabelLeftBlue.Text = "Blau " + LeftBlue.Value;
        }

        private void ChangeColorOfLeftBox() {
            BoxLeft.BackColor = Color.FromArgb(255, LeftRed.Value, LeftGreen.Value, LeftBlue.Value);
            BoxRight.BackColor = Color.FromArgb(255, LeftRed.Value, LeftGreen.Value, LeftBlue.Value);
        }

        private void Form1_Activated(object sender, EventArgs e) {
            label1.Text = "Hui Huh!";
        }

        private void BoxRight_Enter(object sender, EventArgs e) {
            label1.Text = "Bah Buh!";
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e) {
            if (BoxDeactivate.SelectedIndex != -1) {
                BoxDeactivate.Items.RemoveAt(BoxDeactivate.SelectedIndex);
            }
        }

        private void BoxDeactivate_SelectedIndexChanged(object sender, EventArgs e) {
            BtnDeleteItem.Enabled = (BoxDeactivate.SelectedIndex != -1) ? true : false;
        }

        private void BtnGetMin_Click(object sender, EventArgs e) {
            String output = "";
            int min = 1000;
            ArrayList indices = new ArrayList();
            for (int i = 0; i < BoxNumbers.Items.Count; i++) {
                int bla = Convert.ToInt32(BoxNumbers.Items[i]);
                if (Convert.ToInt32(BoxNumbers.Items[i]) < min) {
                    min = Convert.ToInt32(BoxNumbers.Items[i]);
                    indices.Clear();
                    indices.Add(i);
                } else if (Convert.ToInt32(BoxNumbers.Items[i]) == min) {
                    indices.Add(i);
                }
            }
            output += "Minimaler Wert: " + min;
            foreach (int i in indices) {
                output += "\nGefunden an Index " + i;
            }
            LblMin.Text = output;
        }
    }

}
