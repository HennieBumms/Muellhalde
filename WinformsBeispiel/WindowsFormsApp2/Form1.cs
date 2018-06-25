using ClassLibrary1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            comboBox1.DataSource = new List<string>{"Das", "ist", "ein", "Test"};
            dataGridView1.DataSource = new List<string> { "Das", "ist", "ein", "Test" }.Select(x => new { Value = x, Länge = x.Length }).ToList();
            listBox1.DataSource = new List<string> { "Das", "ist", "ein", "Test" };
            checkedListBox1.DataSource = new List<string> { "Das", "ist", "ein", "Test" };
            //Cursor = Cursors.WaitCursor;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "bla";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.Tabelle1". Sie können sie bei Bedarf verschieben oder entfernen.
            Class1 bla = new Class1();
            DataTable dt = bla.Bla();
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e) {
            string myConnectionString = "SERVER=localhost;" +
                            "DATABASE=nobelpreise;" +
                            "UID=root;" +
                            "PASSWORD=;" + "SslMode=none";
            DataTable dt = (DataTable)dataGridView2.DataSource;
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM winners",connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            adapter.Update(dt);
        }
    }
}
