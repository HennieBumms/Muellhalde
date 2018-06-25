namespace Kran_advanced {
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
            this.basi = new System.Windows.Forms.Panel();
            this.haken = new System.Windows.Forms.Panel();
            this.high = new System.Windows.Forms.Panel();
            this.arm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.RadioHakenAus = new System.Windows.Forms.RadioButton();
            this.RadioHakenEin = new System.Windows.Forms.RadioButton();
            this.RadioArmAus = new System.Windows.Forms.RadioButton();
            this.RadioArmEin = new System.Windows.Forms.RadioButton();
            this.RadioKranRechts = new System.Windows.Forms.RadioButton();
            this.RadioKranLInks = new System.Windows.Forms.RadioButton();
            this.RadioKranAus = new System.Windows.Forms.RadioButton();
            this.RadioKranEin = new System.Windows.Forms.RadioButton();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // basi
            // 
            this.basi.BackColor = System.Drawing.Color.FromArgb(255, 220, 1, 220);
            this.basi.Location = new System.Drawing.Point(558, 400);
            this.basi.Name = "basi";
            this.basi.Size = new System.Drawing.Size(179, 35);
            this.basi.TabIndex = 0;
            // 
            // haken
            // 
            this.haken.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.haken.Location = new System.Drawing.Point(515, 203);
            this.haken.Name = "haken";
            this.haken.Size = new System.Drawing.Size(36, 49);
            this.haken.TabIndex = 1;
            // 
            // high
            // 
            this.high.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.high.Location = new System.Drawing.Point(628, 203);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(43, 197);
            this.high.TabIndex = 2;
            // 
            // arm
            // 
            this.arm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.arm.Location = new System.Drawing.Point(515, 174);
            this.arm.Name = "arm";
            this.arm.Size = new System.Drawing.Size(156, 29);
            this.arm.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(921, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Haken aus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Haken_Ein);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(921, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Haken ein";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Haken_Aus);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(921, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ausleger aus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Arm_Aus);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(921, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ausleger ein";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Arm_Ein);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(921, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Kran rechts";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Basis_Links);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(921, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Kran links";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Basis_Rechts);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(921, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Kran ein";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Kran_Ein);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(921, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Kran aus";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Kran_Aus);
            // 
            // RadioHakenAus
            // 
            this.RadioHakenAus.AutoSize = true;
            this.RadioHakenAus.Location = new System.Drawing.Point(1056, 21);
            this.RadioHakenAus.Name = "RadioHakenAus";
            this.RadioHakenAus.Size = new System.Drawing.Size(77, 17);
            this.RadioHakenAus.TabIndex = 12;
            this.RadioHakenAus.TabStop = true;
            this.RadioHakenAus.Text = "Haken aus";
            this.RadioHakenAus.UseVisualStyleBackColor = true;
            // 
            // RadioHakenEin
            // 
            this.RadioHakenEin.AutoSize = true;
            this.RadioHakenEin.Location = new System.Drawing.Point(1056, 63);
            this.RadioHakenEin.Name = "RadioHakenEin";
            this.RadioHakenEin.Size = new System.Drawing.Size(74, 17);
            this.RadioHakenEin.TabIndex = 13;
            this.RadioHakenEin.TabStop = true;
            this.RadioHakenEin.Text = "Haken ein";
            this.RadioHakenEin.UseVisualStyleBackColor = true;
            // 
            // RadioArmAus
            // 
            this.RadioArmAus.AutoSize = true;
            this.RadioArmAus.Location = new System.Drawing.Point(1056, 108);
            this.RadioArmAus.Name = "RadioArmAus";
            this.RadioArmAus.Size = new System.Drawing.Size(86, 17);
            this.RadioArmAus.TabIndex = 14;
            this.RadioArmAus.TabStop = true;
            this.RadioArmAus.Text = "Ausleger aus";
            this.RadioArmAus.UseVisualStyleBackColor = true;
            // 
            // RadioArmEin
            // 
            this.RadioArmEin.AutoSize = true;
            this.RadioArmEin.Location = new System.Drawing.Point(1056, 160);
            this.RadioArmEin.Name = "RadioArmEin";
            this.RadioArmEin.Size = new System.Drawing.Size(83, 17);
            this.RadioArmEin.TabIndex = 15;
            this.RadioArmEin.TabStop = true;
            this.RadioArmEin.Text = "Ausleger ein";
            this.RadioArmEin.UseVisualStyleBackColor = true;
            // 
            // RadioKranRechts
            // 
            this.RadioKranRechts.AutoSize = true;
            this.RadioKranRechts.Location = new System.Drawing.Point(1056, 203);
            this.RadioKranRechts.Name = "RadioKranRechts";
            this.RadioKranRechts.Size = new System.Drawing.Size(79, 17);
            this.RadioKranRechts.TabIndex = 16;
            this.RadioKranRechts.TabStop = true;
            this.RadioKranRechts.Text = "Kran rechts";
            this.RadioKranRechts.UseVisualStyleBackColor = true;
            // 
            // RadioKranLInks
            // 
            this.RadioKranLInks.AutoSize = true;
            this.RadioKranLInks.Location = new System.Drawing.Point(1056, 251);
            this.RadioKranLInks.Name = "RadioKranLInks";
            this.RadioKranLInks.Size = new System.Drawing.Size(71, 17);
            this.RadioKranLInks.TabIndex = 17;
            this.RadioKranLInks.TabStop = true;
            this.RadioKranLInks.Text = "Kran links";
            this.RadioKranLInks.UseVisualStyleBackColor = true;
            // 
            // RadioKranAus
            // 
            this.RadioKranAus.AutoSize = true;
            this.RadioKranAus.Location = new System.Drawing.Point(1056, 297);
            this.RadioKranAus.Name = "RadioKranAus";
            this.RadioKranAus.Size = new System.Drawing.Size(67, 17);
            this.RadioKranAus.TabIndex = 18;
            this.RadioKranAus.TabStop = true;
            this.RadioKranAus.Text = "Kran aus";
            this.RadioKranAus.UseVisualStyleBackColor = true;
            // 
            // RadioKranEin
            // 
            this.RadioKranEin.AutoSize = true;
            this.RadioKranEin.Location = new System.Drawing.Point(1056, 348);
            this.RadioKranEin.Name = "RadioKranEin";
            this.RadioKranEin.Size = new System.Drawing.Size(64, 17);
            this.RadioKranEin.TabIndex = 19;
            this.RadioKranEin.TabStop = true;
            this.RadioKranEin.Text = "Kran ein";
            this.RadioKranEin.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(1149, 21);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 20;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(1149, 63);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 21;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 566);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.RadioKranEin);
            this.Controls.Add(this.RadioKranAus);
            this.Controls.Add(this.RadioKranLInks);
            this.Controls.Add(this.RadioKranRechts);
            this.Controls.Add(this.RadioArmEin);
            this.Controls.Add(this.RadioArmAus);
            this.Controls.Add(this.RadioHakenEin);
            this.Controls.Add(this.RadioHakenAus);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arm);
            this.Controls.Add(this.high);
            this.Controls.Add(this.haken);
            this.Controls.Add(this.basi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel basi;
        private System.Windows.Forms.Panel haken;
        private System.Windows.Forms.Panel high;
        private System.Windows.Forms.Panel arm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton RadioHakenAus;
        private System.Windows.Forms.RadioButton RadioHakenEin;
        private System.Windows.Forms.RadioButton RadioArmAus;
        private System.Windows.Forms.RadioButton RadioArmEin;
        private System.Windows.Forms.RadioButton RadioKranRechts;
        private System.Windows.Forms.RadioButton RadioKranLInks;
        private System.Windows.Forms.RadioButton RadioKranAus;
        private System.Windows.Forms.RadioButton RadioKranEin;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Timer timer1;
    }
}

