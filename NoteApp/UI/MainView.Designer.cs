using System.ComponentModel;

namespace NoteApp.UI
{
    partial class MainView
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
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Impact", 8.25F);
            this.nextButton.Location = new System.Drawing.Point(596, 393);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(128, 55);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Następna";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prevButton
            // 
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Font = new System.Drawing.Font("Impact", 8.25F);
            this.prevButton.Location = new System.Drawing.Point(26, 393);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(128, 55);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "Poprzednia";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // newButton
            // 
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Impact", 8.25F);
            this.newButton.Location = new System.Drawing.Point(160, 415);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(103, 33);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "Nowa";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // delButton
            // 
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Impact", 8.25F);
            this.delButton.Location = new System.Drawing.Point(487, 415);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(103, 33);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Usuń";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 8.25F);
            this.label2.Location = new System.Drawing.Point(324, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notatki";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Impact", 8.25F);
            this.saveButton.Location = new System.Drawing.Point(269, 422);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(212, 26);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(26, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 327);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 36);
            this.comboBox1.MaxLength = 900;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 8.25F);
            this.button1.Location = new System.Drawing.Point(269, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj użytkownika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 8.25F);
            this.button2.Location = new System.Drawing.Point(392, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(748, 454);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        public System.Windows.Forms.TextBox textBox1;

        public System.Windows.Forms.ComboBox comboBox1;


        public System.Windows.Forms.Button saveButton;

        public System.Windows.Forms.Label label2;

        public System.Windows.Forms.Button nextButton;
        public System.Windows.Forms.Button prevButton;
        public System.Windows.Forms.Button newButton;
        public System.Windows.Forms.Button delButton;

        #endregion
    }
}