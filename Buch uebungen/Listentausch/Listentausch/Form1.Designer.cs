namespace Listentausch {
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
            this.BtnSwitchToRight = new System.Windows.Forms.Button();
            this.BtnSwitchToLeft = new System.Windows.Forms.Button();
            this.BoxLeft = new System.Windows.Forms.ListBox();
            this.BoxRight = new System.Windows.Forms.ListBox();
            this.LeftRed = new System.Windows.Forms.TrackBar();
            this.LeftBlue = new System.Windows.Forms.TrackBar();
            this.LeftGreen = new System.Windows.Forms.TrackBar();
            this.LabelLeftRed = new System.Windows.Forms.Label();
            this.LabelLeftGreen = new System.Windows.Forms.Label();
            this.LabelLeftBlue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxDeactivate = new System.Windows.Forms.ListBox();
            this.BtnDeleteItem = new System.Windows.Forms.Button();
            this.BoxNumbers = new System.Windows.Forms.ListBox();
            this.BtnGetMin = new System.Windows.Forms.Button();
            this.LblMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSwitchToRight
            // 
            this.BtnSwitchToRight.Location = new System.Drawing.Point(346, 57);
            this.BtnSwitchToRight.Name = "BtnSwitchToRight";
            this.BtnSwitchToRight.Size = new System.Drawing.Size(75, 23);
            this.BtnSwitchToRight.TabIndex = 2;
            this.BtnSwitchToRight.Text = ">>";
            this.BtnSwitchToRight.UseVisualStyleBackColor = true;
            this.BtnSwitchToRight.Click += new System.EventHandler(this.BtnSwitchToRight_Click);
            // 
            // BtnSwitchToLeft
            // 
            this.BtnSwitchToLeft.Location = new System.Drawing.Point(346, 86);
            this.BtnSwitchToLeft.Name = "BtnSwitchToLeft";
            this.BtnSwitchToLeft.Size = new System.Drawing.Size(75, 23);
            this.BtnSwitchToLeft.TabIndex = 3;
            this.BtnSwitchToLeft.Text = "<<";
            this.BtnSwitchToLeft.UseVisualStyleBackColor = true;
            this.BtnSwitchToLeft.Click += new System.EventHandler(this.BtnSwitchToLeft_Click);
            // 
            // BoxLeft
            // 
            this.BoxLeft.BackColor = System.Drawing.SystemColors.Window;
            this.BoxLeft.FormattingEnabled = true;
            this.BoxLeft.Location = new System.Drawing.Point(171, 57);
            this.BoxLeft.Name = "BoxLeft";
            this.BoxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.BoxLeft.Size = new System.Drawing.Size(120, 95);
            this.BoxLeft.TabIndex = 4;
            // 
            // BoxRight
            // 
            this.BoxRight.FormattingEnabled = true;
            this.BoxRight.Location = new System.Drawing.Point(497, 57);
            this.BoxRight.Name = "BoxRight";
            this.BoxRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.BoxRight.Size = new System.Drawing.Size(120, 95);
            this.BoxRight.TabIndex = 5;
            this.BoxRight.Enter += new System.EventHandler(this.BoxRight_Enter);
            // 
            // LeftRed
            // 
            this.LeftRed.Location = new System.Drawing.Point(171, 192);
            this.LeftRed.Maximum = 255;
            this.LeftRed.Name = "LeftRed";
            this.LeftRed.Size = new System.Drawing.Size(120, 45);
            this.LeftRed.TabIndex = 6;
            this.LeftRed.TickFrequency = 25;
            this.LeftRed.Value = 255;
            this.LeftRed.ValueChanged += new System.EventHandler(this.LeftRed_ValueChanged);
            // 
            // LeftBlue
            // 
            this.LeftBlue.Location = new System.Drawing.Point(171, 294);
            this.LeftBlue.Maximum = 255;
            this.LeftBlue.Name = "LeftBlue";
            this.LeftBlue.Size = new System.Drawing.Size(120, 45);
            this.LeftBlue.TabIndex = 7;
            this.LeftBlue.TickFrequency = 25;
            this.LeftBlue.Value = 255;
            this.LeftBlue.ValueChanged += new System.EventHandler(this.LeftBlue_ValueChanged);
            // 
            // LeftGreen
            // 
            this.LeftGreen.Location = new System.Drawing.Point(171, 243);
            this.LeftGreen.Maximum = 255;
            this.LeftGreen.Name = "LeftGreen";
            this.LeftGreen.Size = new System.Drawing.Size(120, 45);
            this.LeftGreen.TabIndex = 8;
            this.LeftGreen.TickFrequency = 25;
            this.LeftGreen.Value = 255;
            this.LeftGreen.ValueChanged += new System.EventHandler(this.LeftGreen_ValueChanged);
            // 
            // LabelLeftRed
            // 
            this.LabelLeftRed.AutoSize = true;
            this.LabelLeftRed.Location = new System.Drawing.Point(310, 192);
            this.LabelLeftRed.Name = "LabelLeftRed";
            this.LabelLeftRed.Size = new System.Drawing.Size(48, 13);
            this.LabelLeftRed.TabIndex = 9;
            this.LabelLeftRed.Text = "Rot: 255";
            // 
            // LabelLeftGreen
            // 
            this.LabelLeftGreen.AutoSize = true;
            this.LabelLeftGreen.Location = new System.Drawing.Point(310, 243);
            this.LabelLeftGreen.Name = "LabelLeftGreen";
            this.LabelLeftGreen.Size = new System.Drawing.Size(54, 13);
            this.LabelLeftGreen.TabIndex = 10;
            this.LabelLeftGreen.Text = "Grün: 255";
            // 
            // LabelLeftBlue
            // 
            this.LabelLeftBlue.AutoSize = true;
            this.LabelLeftBlue.Location = new System.Drawing.Point(310, 294);
            this.LabelLeftBlue.Name = "LabelLeftBlue";
            this.LabelLeftBlue.Size = new System.Drawing.Size(52, 13);
            this.LabelLeftBlue.TabIndex = 11;
            this.LabelLeftBlue.Text = "Blau: 255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // BoxDeactivate
            // 
            this.BoxDeactivate.BackColor = System.Drawing.SystemColors.Window;
            this.BoxDeactivate.FormattingEnabled = true;
            this.BoxDeactivate.Location = new System.Drawing.Point(497, 192);
            this.BoxDeactivate.Name = "BoxDeactivate";
            this.BoxDeactivate.Size = new System.Drawing.Size(120, 95);
            this.BoxDeactivate.TabIndex = 13;
            this.BoxDeactivate.SelectedIndexChanged += new System.EventHandler(this.BoxDeactivate_SelectedIndexChanged);
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.Enabled = false;
            this.BtnDeleteItem.Location = new System.Drawing.Point(661, 192);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(110, 96);
            this.BtnDeleteItem.TabIndex = 14;
            this.BtnDeleteItem.Text = "Löschen";
            this.BtnDeleteItem.UseVisualStyleBackColor = true;
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // BoxNumbers
            // 
            this.BoxNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.BoxNumbers.FormattingEnabled = true;
            this.BoxNumbers.Location = new System.Drawing.Point(497, 361);
            this.BoxNumbers.Name = "BoxNumbers";
            this.BoxNumbers.Size = new System.Drawing.Size(120, 95);
            this.BoxNumbers.TabIndex = 15;
            // 
            // BtnGetMin
            // 
            this.BtnGetMin.Location = new System.Drawing.Point(661, 360);
            this.BtnGetMin.Name = "BtnGetMin";
            this.BtnGetMin.Size = new System.Drawing.Size(110, 96);
            this.BtnGetMin.TabIndex = 16;
            this.BtnGetMin.Text = "Geht ab";
            this.BtnGetMin.UseVisualStyleBackColor = true;
            this.BtnGetMin.Click += new System.EventHandler(this.BtnGetMin_Click);
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.Location = new System.Drawing.Point(661, 463);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(35, 13);
            this.LblMin.TabIndex = 17;
            this.LblMin.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 556);
            this.Controls.Add(this.LblMin);
            this.Controls.Add(this.BtnGetMin);
            this.Controls.Add(this.BoxNumbers);
            this.Controls.Add(this.BtnDeleteItem);
            this.Controls.Add(this.BoxDeactivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelLeftBlue);
            this.Controls.Add(this.LabelLeftGreen);
            this.Controls.Add(this.LabelLeftRed);
            this.Controls.Add(this.LeftGreen);
            this.Controls.Add(this.LeftBlue);
            this.Controls.Add(this.LeftRed);
            this.Controls.Add(this.BoxRight);
            this.Controls.Add(this.BoxLeft);
            this.Controls.Add(this.BtnSwitchToLeft);
            this.Controls.Add(this.BtnSwitchToRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSwitchToRight;
        private System.Windows.Forms.Button BtnSwitchToLeft;
        private System.Windows.Forms.ListBox BoxLeft;
        private System.Windows.Forms.ListBox BoxRight;
        private System.Windows.Forms.TrackBar LeftRed;
        private System.Windows.Forms.TrackBar LeftBlue;
        private System.Windows.Forms.TrackBar LeftGreen;
        private System.Windows.Forms.Label LabelLeftRed;
        private System.Windows.Forms.Label LabelLeftGreen;
        private System.Windows.Forms.Label LabelLeftBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox BoxDeactivate;
        private System.Windows.Forms.Button BtnDeleteItem;
        private System.Windows.Forms.ListBox BoxNumbers;
        private System.Windows.Forms.Button BtnGetMin;
        private System.Windows.Forms.Label LblMin;
    }
}

