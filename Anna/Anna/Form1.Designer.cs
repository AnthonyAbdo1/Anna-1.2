namespace Anna
{
    partial class NavigationMenu
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
            this.LogToFile = new System.Windows.Forms.Button();
            this.LogToServerBtn = new System.Windows.Forms.Button();
            this.SearchServerNotes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Button();
            this.Weight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogToFile
            // 
            this.LogToFile.Location = new System.Drawing.Point(12, 42);
            this.LogToFile.Name = "LogToFile";
            this.LogToFile.Size = new System.Drawing.Size(89, 43);
            this.LogToFile.TabIndex = 0;
            this.LogToFile.Text = "Read/Write To File";
            this.LogToFile.UseVisualStyleBackColor = true;
            this.LogToFile.Click += new System.EventHandler(this.LogToFile_Click);
            // 
            // LogToServerBtn
            // 
            this.LogToServerBtn.Location = new System.Drawing.Point(12, 91);
            this.LogToServerBtn.Name = "LogToServerBtn";
            this.LogToServerBtn.Size = new System.Drawing.Size(89, 43);
            this.LogToServerBtn.TabIndex = 1;
            this.LogToServerBtn.Text = "Log to Server";
            this.LogToServerBtn.UseVisualStyleBackColor = true;
            this.LogToServerBtn.Click += new System.EventHandler(this.LogToServerBtn_Click);
            // 
            // SearchServerNotes
            // 
            this.SearchServerNotes.Location = new System.Drawing.Point(12, 140);
            this.SearchServerNotes.Name = "SearchServerNotes";
            this.SearchServerNotes.Size = new System.Drawing.Size(89, 43);
            this.SearchServerNotes.TabIndex = 2;
            this.SearchServerNotes.Text = "Search Server Notes";
            this.SearchServerNotes.UseVisualStyleBackColor = true;
            this.SearchServerNotes.Click += new System.EventHandler(this.SearchServerNotes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Basic Data Logging";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converters";
            // 
            // Temperature
            // 
            this.Temperature.Location = new System.Drawing.Point(183, 42);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(89, 43);
            this.Temperature.TabIndex = 5;
            this.Temperature.Text = "Temperature";
            this.Temperature.UseVisualStyleBackColor = true;
            this.Temperature.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(183, 91);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(89, 43);
            this.Weight.TabIndex = 6;
            this.Weight.Text = "Weight";
            this.Weight.UseVisualStyleBackColor = true;
            this.Weight.Click += new System.EventHandler(this.Weight_Click);
            // 
            // NavigationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchServerNotes);
            this.Controls.Add(this.LogToServerBtn);
            this.Controls.Add(this.LogToFile);
            this.Name = "NavigationMenu";
            this.Text = "Navigation Menu";
            this.Load += new System.EventHandler(this.NavigationMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogToFile;
        private System.Windows.Forms.Button LogToServerBtn;
        private System.Windows.Forms.Button SearchServerNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Temperature;
        private System.Windows.Forms.Button Weight;
    }
}

