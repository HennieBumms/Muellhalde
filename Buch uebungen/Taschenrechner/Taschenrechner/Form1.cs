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

namespace Taschenrechner {
    public partial class Form1 : Form {

        ArrayList numbers = new ArrayList();
        ArrayList operators = new ArrayList();
        int removedNumbers = 0;
        int removedOperators = 0;
        bool calculationFinished = false;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Button1_Click(object sender, EventArgs e) {
            PrintDigit(1);
        }

        private void Button2_Click(object sender, EventArgs e) {
            PrintDigit(2);
        }

        private void Button3_Click(object sender, EventArgs e) {
            PrintDigit(3);
        }

        private void Button4_Click(object sender, EventArgs e) {
            PrintDigit(4);
        }

        private void Button5_Click(object sender, EventArgs e) {
            PrintDigit(5);
        }

        private void Button6_Click(object sender, EventArgs e) {
            PrintDigit(6);
        }

        private void Button7_Click(object sender, EventArgs e) {
            PrintDigit(7);
        }

        private void Button8_Click(object sender, EventArgs e) {
            PrintDigit(8);
        }

        private void Button9_Click(object sender, EventArgs e) {
            PrintDigit(9);
        }

        private void Button0_Click(object sender, EventArgs e) {
            PrintDigit(0);
        }

        private void ButtonComma_Click(object sender, EventArgs e) {
            if (!LabelCurrentValue.Text.Contains(",")) {
                LabelCurrentValue.Text += ",";
            }
        }

        private void PrintDigit(int x) {
            if (calculationFinished) {
                LabelCalculation.Text = "0";
                LabelCurrentValue.Text = "0";
                calculationFinished = false;
            }
            if (LabelCurrentValue.Text == "0") {
                LabelCurrentValue.Text = x + "";
            } else {
                LabelCurrentValue.Text += x;
            }
        }

        private void ButtonCE_Click(object sender, EventArgs e) {
            LabelCurrentValue.Text = "0";
        }

        private void ButtonDivide_Click(object sender, EventArgs e) {
            PrintOperator('/');
        }

        private void ButtonMultiply_Click(object sender, EventArgs e) {
            PrintOperator('*');
        }

        private void ButtonMinus_Click(object sender, EventArgs e) {
            PrintOperator('-');
        }

        private void ButtonPlus_Click(object sender, EventArgs e) {
            PrintOperator('+');
        }

        private void PrintOperator(char dings) {
            if (LabelCalculation.Text == "0") {
                LabelCalculation.Text = LabelCurrentValue.Text + " " + dings + " ";
            } else {
                LabelCalculation.Text += LabelCurrentValue.Text + " " + dings + " ";
            }
            operators.Add(dings);
            numbers.Add(Convert.ToDouble(LabelCurrentValue.Text));
            LabelCurrentValue.Text = "0";
        }

        private void ButtonEqual_Click(object sender, EventArgs e) {
            LabelCalculation.Text += LabelCurrentValue.Text;
            numbers.Add(Convert.ToDouble(LabelCurrentValue.Text));
            double result = 0.0;
            ArrayList PointIndices = getIndicesForPointCalc();
            calcPoints(PointIndices);
            LabelCurrentValue.Text = numbers[0] + "";
            CleanUp();
            this.calculationFinished = true;
        }

        private void CleanUp() {
            this.removedNumbers = 0;
            this.removedOperators = 0;
            this.numbers.Clear();
            this.operators.Clear();
        }

        private void calcPoints(ArrayList PointIndices) {
            foreach (int index in PointIndices) {                
                if (operators.Cast<char>().Count() > 0 && (char) operators[index - removedOperators] == '*') {
                    numbers[index-removedNumbers] = (double) numbers[index - removedNumbers] * (double) numbers[index + 1 - removedNumbers];
                    numbers.RemoveAt(index + 1 - removedNumbers);
                    operators.RemoveAt(index - removedOperators);
                    removedNumbers++;
                    removedOperators++;
                } else if (operators.Count > 0 && (char) operators[index - removedOperators] == '/') {
                    numbers[index-removedNumbers] = (double) numbers[index - removedNumbers] / (double) numbers[index + 1 - removedNumbers];
                    numbers.RemoveAt(index + 1 - removedNumbers);
                    operators.RemoveAt(index - removedOperators);
                    removedNumbers++;
                    removedOperators++;
                }
            }
        }

        private ArrayList getIndicesForPointCalc() {
            ArrayList PointIndices = new ArrayList();
            for (int i = 0; i < operators.Count; i++) {
                if ((char) operators[i] == '/' || (char) operators[i] == '*') {
                    PointIndices.Add(i);
                }
            }
            return PointIndices;
        }

        private void ButtonC_Click(object sender, EventArgs e) {
            LabelCurrentValue.Text = "0";
            LabelCalculation.Text = "0";
            CleanUp();
            this.calculationFinished = true;
        }
    }
}
