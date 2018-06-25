using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uebungName {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e) {
            Close();
        }

        private void CmdName_Click(object sender, EventArgs e) {
            LblName.Text = "jsofid";
        }
    }
}
