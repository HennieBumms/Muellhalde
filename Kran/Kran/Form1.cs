using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kran {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void NachOben(object sender, EventArgs e) {
            panel.Location = new Point(panel.Location.X, panel.Location.Y - 10);
        }
        private void NachUnten(object sender, EventArgs e) {
            panel.Location = new Point(panel.Location.X-10, panel.Location.Y);
        }
        private void NachRechts(object sender, EventArgs e) {
            panel.Location = new Point(panel.Location.X+10, panel.Location.Y);
        }
        private void NachLinks(object sender, EventArgs e) {
            panel.Location = new Point(panel.Location.X, panel.Location.Y + 10);
        }
    }
}
