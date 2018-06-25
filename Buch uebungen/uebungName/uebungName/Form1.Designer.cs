namespace uebungName {
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
            this.CmdName = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdName
            // 
            this.CmdName.Location = new System.Drawing.Point(218, 246);
            this.CmdName.Name = "CmdName";
            this.CmdName.Size = new System.Drawing.Size(91, 46);
            this.CmdName.TabIndex = 0;
            this.CmdName.Text = "Name";
            this.CmdName.UseVisualStyleBackColor = true;
            this.CmdName.Click += new System.EventHandler(this.CmdName_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(397, 238);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Beende";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(316, 193);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(24, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "leer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "leer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Beende";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Name";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(691, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CmdName);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMyName;
        private System.Windows.Forms.Button CmdMyName;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdName;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

