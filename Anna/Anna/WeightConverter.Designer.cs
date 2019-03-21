namespace Anna
{
    partial class WeightConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OunceToGill = new System.Windows.Forms.CheckBox();
            this.GillToPint = new System.Windows.Forms.CheckBox();
            this.PintToQuart = new System.Windows.Forms.CheckBox();
            this.QuartToGallon = new System.Windows.Forms.CheckBox();
            this.PoundToTon = new System.Windows.Forms.CheckBox();
            this.OunceToPound = new System.Windows.Forms.CheckBox();
            this.DramToOunce = new System.Windows.Forms.CheckBox();
            this.GrainToDram = new System.Windows.Forms.CheckBox();
            this.LiquedCoverterTxtBox = new System.Windows.Forms.TextBox();
            this.WeightConverterTxtBox = new System.Windows.Forms.TextBox();
            this.LiquedConverterBtn = new System.Windows.Forms.Button();
            this.WeightConverterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liqued Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Weight Converter";
            // 
            // OunceToGill
            // 
            this.OunceToGill.AutoSize = true;
            this.OunceToGill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OunceToGill.Location = new System.Drawing.Point(25, 51);
            this.OunceToGill.Name = "OunceToGill";
            this.OunceToGill.Size = new System.Drawing.Size(113, 22);
            this.OunceToGill.TabIndex = 2;
            this.OunceToGill.Text = "Ounce to Gill";
            this.OunceToGill.UseVisualStyleBackColor = true;
            this.OunceToGill.CheckedChanged += new System.EventHandler(this.OunceToGill_CheckedChanged);
            // 
            // GillToPint
            // 
            this.GillToPint.AutoSize = true;
            this.GillToPint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GillToPint.Location = new System.Drawing.Point(25, 74);
            this.GillToPint.Name = "GillToPint";
            this.GillToPint.Size = new System.Drawing.Size(94, 22);
            this.GillToPint.TabIndex = 3;
            this.GillToPint.Text = "Gill to Pint";
            this.GillToPint.UseVisualStyleBackColor = true;
            this.GillToPint.CheckedChanged += new System.EventHandler(this.GillToPint_CheckedChanged);
            // 
            // PintToQuart
            // 
            this.PintToQuart.AutoSize = true;
            this.PintToQuart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PintToQuart.Location = new System.Drawing.Point(25, 97);
            this.PintToQuart.Name = "PintToQuart";
            this.PintToQuart.Size = new System.Drawing.Size(115, 22);
            this.PintToQuart.TabIndex = 4;
            this.PintToQuart.Text = "Pint To Quart";
            this.PintToQuart.UseVisualStyleBackColor = true;
            this.PintToQuart.CheckedChanged += new System.EventHandler(this.PintToQuart_CheckedChanged);
            // 
            // QuartToGallon
            // 
            this.QuartToGallon.AutoSize = true;
            this.QuartToGallon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuartToGallon.Location = new System.Drawing.Point(25, 118);
            this.QuartToGallon.Name = "QuartToGallon";
            this.QuartToGallon.Size = new System.Drawing.Size(133, 22);
            this.QuartToGallon.TabIndex = 5;
            this.QuartToGallon.Text = "Quart To Gallon";
            this.QuartToGallon.UseVisualStyleBackColor = true;
            this.QuartToGallon.CheckedChanged += new System.EventHandler(this.QuartToGallon_CheckedChanged);
            // 
            // PoundToTon
            // 
            this.PoundToTon.AutoSize = true;
            this.PoundToTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoundToTon.Location = new System.Drawing.Point(425, 120);
            this.PoundToTon.Name = "PoundToTon";
            this.PoundToTon.Size = new System.Drawing.Size(127, 24);
            this.PoundToTon.TabIndex = 9;
            this.PoundToTon.Text = "Pound To Ton";
            this.PoundToTon.UseVisualStyleBackColor = true;
            // 
            // OunceToPound
            // 
            this.OunceToPound.AutoSize = true;
            this.OunceToPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OunceToPound.Location = new System.Drawing.Point(425, 97);
            this.OunceToPound.Name = "OunceToPound";
            this.OunceToPound.Size = new System.Drawing.Size(143, 24);
            this.OunceToPound.TabIndex = 8;
            this.OunceToPound.Text = "Ounce to Pound";
            this.OunceToPound.UseVisualStyleBackColor = true;
            // 
            // DramToOunce
            // 
            this.DramToOunce.AutoSize = true;
            this.DramToOunce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DramToOunce.Location = new System.Drawing.Point(425, 74);
            this.DramToOunce.Name = "DramToOunce";
            this.DramToOunce.Size = new System.Drawing.Size(136, 24);
            this.DramToOunce.TabIndex = 7;
            this.DramToOunce.Text = "Dram to Ounce";
            this.DramToOunce.UseVisualStyleBackColor = true;
            // 
            // GrainToDram
            // 
            this.GrainToDram.AutoSize = true;
            this.GrainToDram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrainToDram.Location = new System.Drawing.Point(425, 51);
            this.GrainToDram.Name = "GrainToDram";
            this.GrainToDram.Size = new System.Drawing.Size(128, 24);
            this.GrainToDram.TabIndex = 6;
            this.GrainToDram.Text = "Grain to Dram";
            this.GrainToDram.UseVisualStyleBackColor = true;
            // 
            // LiquedCoverterTxtBox
            // 
            this.LiquedCoverterTxtBox.Location = new System.Drawing.Point(164, 51);
            this.LiquedCoverterTxtBox.Multiline = true;
            this.LiquedCoverterTxtBox.Name = "LiquedCoverterTxtBox";
            this.LiquedCoverterTxtBox.Size = new System.Drawing.Size(247, 86);
            this.LiquedCoverterTxtBox.TabIndex = 10;
            this.LiquedCoverterTxtBox.TextChanged += new System.EventHandler(this.LiquedCoverterTxtBox_TextChanged);
            // 
            // WeightConverterTxtBox
            // 
            this.WeightConverterTxtBox.Location = new System.Drawing.Point(567, 51);
            this.WeightConverterTxtBox.Multiline = true;
            this.WeightConverterTxtBox.Name = "WeightConverterTxtBox";
            this.WeightConverterTxtBox.Size = new System.Drawing.Size(247, 86);
            this.WeightConverterTxtBox.TabIndex = 11;
            // 
            // LiquedConverterBtn
            // 
            this.LiquedConverterBtn.Location = new System.Drawing.Point(164, 155);
            this.LiquedConverterBtn.Name = "LiquedConverterBtn";
            this.LiquedConverterBtn.Size = new System.Drawing.Size(80, 55);
            this.LiquedConverterBtn.TabIndex = 12;
            this.LiquedConverterBtn.Text = "Submit";
            this.LiquedConverterBtn.UseVisualStyleBackColor = true;
            this.LiquedConverterBtn.Click += new System.EventHandler(this.LiquedConverterBtn_Click);
            // 
            // WeightConverterBtn
            // 
            this.WeightConverterBtn.Location = new System.Drawing.Point(567, 155);
            this.WeightConverterBtn.Name = "WeightConverterBtn";
            this.WeightConverterBtn.Size = new System.Drawing.Size(80, 55);
            this.WeightConverterBtn.TabIndex = 13;
            this.WeightConverterBtn.Text = "Submit";
            this.WeightConverterBtn.UseVisualStyleBackColor = true;
            // 
            // WeightConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 638);
            this.Controls.Add(this.WeightConverterBtn);
            this.Controls.Add(this.LiquedConverterBtn);
            this.Controls.Add(this.WeightConverterTxtBox);
            this.Controls.Add(this.LiquedCoverterTxtBox);
            this.Controls.Add(this.PoundToTon);
            this.Controls.Add(this.OunceToPound);
            this.Controls.Add(this.DramToOunce);
            this.Controls.Add(this.GrainToDram);
            this.Controls.Add(this.QuartToGallon);
            this.Controls.Add(this.PintToQuart);
            this.Controls.Add(this.GillToPint);
            this.Controls.Add(this.OunceToGill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeightConverter";
            this.Text = "WeightConverter";
            this.Load += new System.EventHandler(this.WeightConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox OunceToGill;
        private System.Windows.Forms.CheckBox GillToPint;
        private System.Windows.Forms.CheckBox PintToQuart;
        private System.Windows.Forms.CheckBox QuartToGallon;
        private System.Windows.Forms.CheckBox PoundToTon;
        private System.Windows.Forms.CheckBox OunceToPound;
        private System.Windows.Forms.CheckBox DramToOunce;
        private System.Windows.Forms.CheckBox GrainToDram;
        private System.Windows.Forms.TextBox LiquedCoverterTxtBox;
        private System.Windows.Forms.TextBox WeightConverterTxtBox;
        private System.Windows.Forms.Button LiquedConverterBtn;
        private System.Windows.Forms.Button WeightConverterBtn;
    }
}