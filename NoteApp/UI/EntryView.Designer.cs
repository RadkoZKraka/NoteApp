using System.ComponentModel;

namespace NoteApp.UI
{
    partial class FirstView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteList = new System.Windows.Forms.ComboBox();
            this.addNoteList = new System.Windows.Forms.Button();
            this.deleteNoteList = new System.Windows.Forms.Button();
            this.loadNoteList = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteList
            // 
            this.noteList.FormattingEnabled = true;
            this.noteList.Location = new System.Drawing.Point(89, 92);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(206, 21);
            this.noteList.TabIndex = 0;
            // 
            // addNoteList
            // 
            this.addNoteList.Location = new System.Drawing.Point(133, 171);
            this.addNoteList.Name = "addNoteList";
            this.addNoteList.Size = new System.Drawing.Size(114, 25);
            this.addNoteList.TabIndex = 1;
            this.addNoteList.Text = "Dodaj bazę notatek";
            this.addNoteList.UseVisualStyleBackColor = true;
            this.addNoteList.Click += new System.EventHandler(this.addNoteList_Click);
            // 
            // deleteNoteList
            // 
            this.deleteNoteList.Location = new System.Drawing.Point(133, 214);
            this.deleteNoteList.Name = "deleteNoteList";
            this.deleteNoteList.Size = new System.Drawing.Size(114, 25);
            this.deleteNoteList.TabIndex = 2;
            this.deleteNoteList.Text = "Usuń bazę notatek";
            this.deleteNoteList.UseVisualStyleBackColor = true;
            this.deleteNoteList.Click += new System.EventHandler(this.deleteNoteList_Click);
            // 
            // loadNoteList
            // 
            this.loadNoteList.Location = new System.Drawing.Point(133, 128);
            this.loadNoteList.Name = "loadNoteList";
            this.loadNoteList.Size = new System.Drawing.Size(114, 25);
            this.loadNoteList.TabIndex = 3;
            this.loadNoteList.Text = "Załaduj baze";
            this.loadNoteList.UseVisualStyleBackColor = true;
            this.loadNoteList.Click += new System.EventHandler(this.loadNoteList_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(270, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // FirstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadNoteList);
            this.Controls.Add(this.deleteNoteList);
            this.Controls.Add(this.addNoteList);
            this.Controls.Add(this.noteList);
            this.Name = "FirstView";
            this.Size = new System.Drawing.Size(387, 327);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.ComboBox noteList;
        public System.Windows.Forms.Button addNoteList;
        public System.Windows.Forms.Button deleteNoteList;
        public System.Windows.Forms.Button loadNoteList;
        public System.Windows.Forms.Button exitButton;

        #endregion
    }
}