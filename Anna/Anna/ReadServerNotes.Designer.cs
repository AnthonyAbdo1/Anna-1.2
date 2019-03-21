namespace Anna
{
    partial class ReadServerNotes
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
            this.NoteName = new System.Windows.Forms.Label();
            this.NoteTitle = new System.Windows.Forms.TextBox();
            this.NoteBody = new System.Windows.Forms.TextBox();
            this.ReadNoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoteName
            // 
            this.NoteName.AutoSize = true;
            this.NoteName.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteName.Location = new System.Drawing.Point(80, 9);
            this.NoteName.Name = "NoteName";
            this.NoteName.Size = new System.Drawing.Size(78, 28);
            this.NoteName.TabIndex = 0;
            this.NoteName.Text = "Note Name";
            this.NoteName.Click += new System.EventHandler(this.label1_Click);
            // 
            // NoteTitle
            // 
            this.NoteTitle.Location = new System.Drawing.Point(12, 40);
            this.NoteTitle.Name = "NoteTitle";
            this.NoteTitle.Size = new System.Drawing.Size(233, 20);
            this.NoteTitle.TabIndex = 1;
            this.NoteTitle.TextChanged += new System.EventHandler(this.NoteTitle_TextChanged);
            // 
            // NoteBody
            // 
            this.NoteBody.Location = new System.Drawing.Point(12, 81);
            this.NoteBody.Multiline = true;
            this.NoteBody.Name = "NoteBody";
            this.NoteBody.Size = new System.Drawing.Size(1464, 1122);
            this.NoteBody.TabIndex = 2;
            this.NoteBody.TextChanged += new System.EventHandler(this.NoteBody_TextChanged);
            // 
            // ReadNoteBtn
            // 
            this.ReadNoteBtn.Location = new System.Drawing.Point(265, 25);
            this.ReadNoteBtn.Name = "ReadNoteBtn";
            this.ReadNoteBtn.Size = new System.Drawing.Size(128, 48);
            this.ReadNoteBtn.TabIndex = 3;
            this.ReadNoteBtn.Text = "Search";
            this.ReadNoteBtn.UseVisualStyleBackColor = true;
            this.ReadNoteBtn.Click += new System.EventHandler(this.ReadNoteBtn_Click);
            // 
            // ReadServerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1250);
            this.Controls.Add(this.ReadNoteBtn);
            this.Controls.Add(this.NoteBody);
            this.Controls.Add(this.NoteTitle);
            this.Controls.Add(this.NoteName);
            this.Name = "ReadServerNotes";
            this.Text = "ReadServerNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteName;
        private System.Windows.Forms.TextBox NoteTitle;
        private System.Windows.Forms.TextBox NoteBody;
        private System.Windows.Forms.Button ReadNoteBtn;
    }
}