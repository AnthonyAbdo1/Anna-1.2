namespace Anna
{
    partial class WriteToFileForm
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
            this.WriteToFileBtn = new System.Windows.Forms.Button();
            this.FileInputBox = new System.Windows.Forms.TextBox();
            this.FilePathLocationTxtBox = new System.Windows.Forms.TextBox();
            this.ReadFromFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WriteToFileBtn
            // 
            this.WriteToFileBtn.Location = new System.Drawing.Point(0, 0);
            this.WriteToFileBtn.Name = "WriteToFileBtn";
            this.WriteToFileBtn.Size = new System.Drawing.Size(117, 57);
            this.WriteToFileBtn.TabIndex = 0;
            this.WriteToFileBtn.Text = "Submit";
            this.WriteToFileBtn.UseVisualStyleBackColor = true;
            this.WriteToFileBtn.Click += new System.EventHandler(this.WriteToFileBtn_Click);
            // 
            // FileInputBox
            // 
            this.FileInputBox.Location = new System.Drawing.Point(0, 63);
            this.FileInputBox.Multiline = true;
            this.FileInputBox.Name = "FileInputBox";
            this.FileInputBox.Size = new System.Drawing.Size(1921, 1319);
            this.FileInputBox.TabIndex = 1;
            this.FileInputBox.TextChanged += new System.EventHandler(this.FileInputBox_TextChanged);
            // 
            // FilePathLocationTxtBox
            // 
            this.FilePathLocationTxtBox.Location = new System.Drawing.Point(123, 37);
            this.FilePathLocationTxtBox.Name = "FilePathLocationTxtBox";
            this.FilePathLocationTxtBox.Size = new System.Drawing.Size(273, 20);
            this.FilePathLocationTxtBox.TabIndex = 2;
            this.FilePathLocationTxtBox.TextChanged += new System.EventHandler(this.FilePathLocationTxtBox_TextChanged);
            // 
            // ReadFromFileBtn
            // 
            this.ReadFromFileBtn.Location = new System.Drawing.Point(450, 0);
            this.ReadFromFileBtn.Name = "ReadFromFileBtn";
            this.ReadFromFileBtn.Size = new System.Drawing.Size(117, 57);
            this.ReadFromFileBtn.TabIndex = 3;
            this.ReadFromFileBtn.Text = "Read From File";
            this.ReadFromFileBtn.UseVisualStyleBackColor = true;
            this.ReadFromFileBtn.Click += new System.EventHandler(this.ReadFromFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name";
            // 
            // WriteToFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadFromFileBtn);
            this.Controls.Add(this.FilePathLocationTxtBox);
            this.Controls.Add(this.FileInputBox);
            this.Controls.Add(this.WriteToFileBtn);
            this.Name = "WriteToFileForm";
            this.Text = "WriteToFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteToFileBtn;
        private System.Windows.Forms.TextBox FileInputBox;
        private System.Windows.Forms.TextBox FilePathLocationTxtBox;
        private System.Windows.Forms.Button ReadFromFileBtn;
        private System.Windows.Forms.Label label1;
    }
}