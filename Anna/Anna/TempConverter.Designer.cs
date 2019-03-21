namespace Anna
{
    partial class TempConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FtoCbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FahrenheitBox = new System.Windows.Forms.TextBox();
            this.FtoC = new System.Windows.Forms.CheckBox();
            this.CtoF = new System.Windows.Forms.CheckBox();
            this.CtoK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FtoCbtn
            // 
            this.FtoCbtn.Location = new System.Drawing.Point(12, 131);
            this.FtoCbtn.Name = "FtoCbtn";
            this.FtoCbtn.Size = new System.Drawing.Size(75, 46);
            this.FtoCbtn.TabIndex = 0;
            this.FtoCbtn.Text = "Convert";
            this.FtoCbtn.UseVisualStyleBackColor = true;
            this.FtoCbtn.Click += new System.EventHandler(this.FtoCbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // FahrenheitBox
            // 
            this.FahrenheitBox.Location = new System.Drawing.Point(12, 25);
            this.FahrenheitBox.Name = "FahrenheitBox";
            this.FahrenheitBox.Size = new System.Drawing.Size(963, 20);
            this.FahrenheitBox.TabIndex = 3;
            this.FahrenheitBox.TextChanged += new System.EventHandler(this.FahrenheitBox_TextChanged);
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Location = new System.Drawing.Point(12, 62);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(54, 17);
            this.FtoC.TabIndex = 5;
            this.FtoC.Text = "F to C";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.CheckedChanged += new System.EventHandler(this.FtoC_CheckedChanged);
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Location = new System.Drawing.Point(12, 85);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(54, 17);
            this.CtoF.TabIndex = 6;
            this.CtoF.Text = "C to F";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.CheckedChanged += new System.EventHandler(this.CtoF_CheckedChanged);
            // 
            // CtoK
            // 
            this.CtoK.AutoSize = true;
            this.CtoK.Location = new System.Drawing.Point(12, 108);
            this.CtoK.Name = "CtoK";
            this.CtoK.Size = new System.Drawing.Size(55, 17);
            this.CtoK.TabIndex = 7;
            this.CtoK.Text = "C to K";
            this.CtoK.UseVisualStyleBackColor = true;
            this.CtoK.CheckedChanged += new System.EventHandler(this.CtoK_CheckedChanged);
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 659);
            this.Controls.Add(this.CtoK);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.FahrenheitBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FtoCbtn);
            this.Name = "TempConverter";
            this.Text = "TempConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FtoCbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FahrenheitBox;
        private System.Windows.Forms.CheckBox FtoC;
        private System.Windows.Forms.CheckBox CtoF;
        private System.Windows.Forms.CheckBox CtoK;
    }
}