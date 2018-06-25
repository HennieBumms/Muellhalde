using System;

namespace uebungDatentypen {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbldisplay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LinksOben = new System.Windows.Forms.Panel();
            this.RechtsOben = new System.Windows.Forms.Panel();
            this.LinksUnten = new System.Windows.Forms.Panel();
            this.RechtsUnten = new System.Windows.Forms.Panel();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.TextOutput = new System.Windows.Forms.Label();
            this.NumInput = new System.Windows.Forms.NumericUpDown();
            this.SalaryInput = new System.Windows.Forms.TextBox();
            this.SalaryOutput = new System.Windows.Forms.Label();
            this.SalaryCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mach rein, da";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbldisplay
            // 
            this.Lbldisplay.AutoSize = true;
            this.Lbldisplay.Location = new System.Drawing.Point(48, 30);
            this.Lbldisplay.Name = "Lbldisplay";
            this.Lbldisplay.Size = new System.Drawing.Size(30, 13);
            this.Lbldisplay.TabIndex = 1;
            this.Lbldisplay.Text = "leeer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // LinksOben
            // 
            this.LinksOben.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LinksOben.Location = new System.Drawing.Point(341, 192);
            this.LinksOben.Name = "LinksOben";
            this.LinksOben.Size = new System.Drawing.Size(30, 30);
            this.LinksOben.TabIndex = 3;
            // 
            // RechtsOben
            // 
            this.RechtsOben.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RechtsOben.Location = new System.Drawing.Point(419, 192);
            this.RechtsOben.Name = "RechtsOben";
            this.RechtsOben.Size = new System.Drawing.Size(30, 30);
            this.RechtsOben.TabIndex = 4;
            // 
            // LinksUnten
            // 
            this.LinksUnten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LinksUnten.Location = new System.Drawing.Point(341, 257);
            this.LinksUnten.Name = "LinksUnten";
            this.LinksUnten.Size = new System.Drawing.Size(30, 30);
            this.LinksUnten.TabIndex = 4;
            // 
            // RechtsUnten
            // 
            this.RechtsUnten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RechtsUnten.Location = new System.Drawing.Point(419, 257);
            this.RechtsUnten.Name = "RechtsUnten";
            this.RechtsUnten.Size = new System.Drawing.Size(30, 30);
            this.RechtsUnten.TabIndex = 5;
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(21, 116);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(134, 97);
            this.TextInput.TabIndex = 6;
            // 
            // TextOutput
            // 
            this.TextOutput.AutoSize = true;
            this.TextOutput.Location = new System.Drawing.Point(18, 236);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(35, 13);
            this.TextOutput.TabIndex = 7;
            this.TextOutput.Text = "label1";
            // 
            // NumInput
            // 
            this.NumInput.DecimalPlaces = 2;
            this.NumInput.Location = new System.Drawing.Point(21, 267);
            this.NumInput.Name = "NumInput";
            this.NumInput.Size = new System.Drawing.Size(120, 20);
            this.NumInput.TabIndex = 8;
            this.NumInput.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // SalaryInput
            // 
            this.SalaryInput.Location = new System.Drawing.Point(21, 317);
            this.SalaryInput.Name = "SalaryInput";
            this.SalaryInput.Size = new System.Drawing.Size(134, 20);
            this.SalaryInput.TabIndex = 9;
            // 
            // SalaryOutput
            // 
            this.SalaryOutput.AutoSize = true;
            this.SalaryOutput.Location = new System.Drawing.Point(18, 355);
            this.SalaryOutput.Name = "SalaryOutput";
            this.SalaryOutput.Size = new System.Drawing.Size(35, 13);
            this.SalaryOutput.TabIndex = 10;
            this.SalaryOutput.Text = "label1";
            // 
            // SalaryCalc
            // 
            this.SalaryCalc.Location = new System.Drawing.Point(21, 386);
            this.SalaryCalc.Name = "SalaryCalc";
            this.SalaryCalc.Size = new System.Drawing.Size(134, 23);
            this.SalaryCalc.TabIndex = 11;
            this.SalaryCalc.Text = "button3";
            this.SalaryCalc.UseVisualStyleBackColor = true;
            this.SalaryCalc.Click += new System.EventHandler(this.SalaryCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalaryCalc);
            this.Controls.Add(this.SalaryOutput);
            this.Controls.Add(this.SalaryInput);
            this.Controls.Add(this.NumInput);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.RechtsUnten);
            this.Controls.Add(this.LinksUnten);
            this.Controls.Add(this.RechtsOben);
            this.Controls.Add(this.LinksOben);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lbldisplay);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbldisplay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel LinksOben;
        private System.Windows.Forms.Panel RechtsOben;
        private System.Windows.Forms.Panel LinksUnten;
        private System.Windows.Forms.Panel RechtsUnten;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label TextOutput;
        private System.Windows.Forms.NumericUpDown NumInput;
        private System.Windows.Forms.TextBox SalaryInput;
        private System.Windows.Forms.Label SalaryOutput;
        private System.Windows.Forms.Button SalaryCalc;
    }
}

