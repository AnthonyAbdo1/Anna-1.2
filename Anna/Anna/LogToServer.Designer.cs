namespace Anna
{
    partial class LogToServer
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
            this.NoteSubject = new System.Windows.Forms.TextBox();
            this.ServerNoteBody = new System.Windows.Forms.TextBox();
            this.SubmitToServerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoteSubject
            // 
            this.NoteSubject.Location = new System.Drawing.Point(134, 26);
            this.NoteSubject.Name = "NoteSubject";
            this.NoteSubject.Size = new System.Drawing.Size(227, 20);
            this.NoteSubject.TabIndex = 0;
            this.NoteSubject.TextChanged += new System.EventHandler(this.NoteSubject_TextChanged);
            // 
            // ServerNoteBody
            // 
            this.ServerNoteBody.Location = new System.Drawing.Point(12, 65);
            this.ServerNoteBody.Multiline = true;
            this.ServerNoteBody.Name = "ServerNoteBody";
            this.ServerNoteBody.Size = new System.Drawing.Size(1801, 1273);
            this.ServerNoteBody.TabIndex = 1;
            this.ServerNoteBody.TextChanged += new System.EventHandler(this.ServerNoteBody_TextChanged);
            // 
            // SubmitToServerBtn
            // 
            this.SubmitToServerBtn.Location = new System.Drawing.Point(12, 12);
            this.SubmitToServerBtn.Name = "SubmitToServerBtn";
            this.SubmitToServerBtn.Size = new System.Drawing.Size(99, 47);
            this.SubmitToServerBtn.TabIndex = 2;
            this.SubmitToServerBtn.Text = "Submit";
            this.SubmitToServerBtn.UseVisualStyleBackColor = true;
            this.SubmitToServerBtn.Click += new System.EventHandler(this.SubmitToServerBtn_Click);
            // 
            // LogToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 1350);
            this.Controls.Add(this.SubmitToServerBtn);
            this.Controls.Add(this.ServerNoteBody);
            this.Controls.Add(this.NoteSubject);
            this.Name = "LogToServer";
            this.Text = "LogToServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteSubject;
        private System.Windows.Forms.TextBox ServerNoteBody;
        private System.Windows.Forms.Button SubmitToServerBtn;
    }
}