
namespace CzernikDox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNumer = new System.Windows.Forms.Button();
            this.buttonImie = new System.Windows.Forms.Button();
            this.buttonAdress = new System.Windows.Forms.Button();
            this.buttonKimJestem = new System.Windows.Forms.Button();
            this.buttonNazwisko = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNumer
            // 
            this.buttonNumer.BackColor = System.Drawing.Color.White;
            this.buttonNumer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNumer.FlatAppearance.BorderSize = 0;
            this.buttonNumer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNumer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNumer.ForeColor = System.Drawing.Color.Black;
            this.buttonNumer.Location = new System.Drawing.Point(12, 473);
            this.buttonNumer.Name = "buttonNumer";
            this.buttonNumer.Size = new System.Drawing.Size(127, 40);
            this.buttonNumer.TabIndex = 0;
            this.buttonNumer.Text = "Numer";
            this.buttonNumer.UseVisualStyleBackColor = false;
            this.buttonNumer.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonImie
            // 
            this.buttonImie.BackColor = System.Drawing.Color.White;
            this.buttonImie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonImie.FlatAppearance.BorderSize = 0;
            this.buttonImie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonImie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImie.ForeColor = System.Drawing.Color.Black;
            this.buttonImie.Location = new System.Drawing.Point(12, 65);
            this.buttonImie.Name = "buttonImie";
            this.buttonImie.Size = new System.Drawing.Size(127, 40);
            this.buttonImie.TabIndex = 1;
            this.buttonImie.Text = "Imie";
            this.buttonImie.UseVisualStyleBackColor = false;
            this.buttonImie.Click += new System.EventHandler(this.buttonImie_Click);
            // 
            // buttonAdress
            // 
            this.buttonAdress.BackColor = System.Drawing.Color.White;
            this.buttonAdress.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdress.FlatAppearance.BorderSize = 0;
            this.buttonAdress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdress.ForeColor = System.Drawing.Color.Black;
            this.buttonAdress.Location = new System.Drawing.Point(616, 473);
            this.buttonAdress.Name = "buttonAdress";
            this.buttonAdress.Size = new System.Drawing.Size(127, 40);
            this.buttonAdress.TabIndex = 2;
            this.buttonAdress.Text = "Adress";
            this.buttonAdress.UseVisualStyleBackColor = false;
            this.buttonAdress.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonKimJestem
            // 
            this.buttonKimJestem.BackColor = System.Drawing.Color.White;
            this.buttonKimJestem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonKimJestem.FlatAppearance.BorderSize = 0;
            this.buttonKimJestem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKimJestem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKimJestem.ForeColor = System.Drawing.Color.Black;
            this.buttonKimJestem.Location = new System.Drawing.Point(323, 129);
            this.buttonKimJestem.Name = "buttonKimJestem";
            this.buttonKimJestem.Size = new System.Drawing.Size(127, 40);
            this.buttonKimJestem.TabIndex = 3;
            this.buttonKimJestem.Text = "Kim Jestem?";
            this.buttonKimJestem.UseVisualStyleBackColor = false;
            this.buttonKimJestem.Click += new System.EventHandler(this.buttonMatixTanczy_Click);
            // 
            // buttonNazwisko
            // 
            this.buttonNazwisko.BackColor = System.Drawing.Color.White;
            this.buttonNazwisko.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNazwisko.FlatAppearance.BorderSize = 0;
            this.buttonNazwisko.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNazwisko.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNazwisko.ForeColor = System.Drawing.Color.Black;
            this.buttonNazwisko.Location = new System.Drawing.Point(616, 65);
            this.buttonNazwisko.Name = "buttonNazwisko";
            this.buttonNazwisko.Size = new System.Drawing.Size(127, 40);
            this.buttonNazwisko.TabIndex = 4;
            this.buttonNazwisko.Text = "Nazwisko";
            this.buttonNazwisko.UseVisualStyleBackColor = false;
            this.buttonNazwisko.Click += new System.EventHandler(this.buttonNazwisko_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(319, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Made by ENDERMANQ";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(674, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 27);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(755, 524);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNazwisko);
            this.Controls.Add(this.buttonKimJestem);
            this.Controls.Add(this.buttonAdress);
            this.Controls.Add(this.buttonImie);
            this.Controls.Add(this.buttonNumer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "𝙈𝙖𝙩𝙞𝙭 𝙋𝙤𝙧𝙩𝙛𝙤𝙡𝙞𝙤";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNumer;
        private System.Windows.Forms.Button buttonImie;
        private System.Windows.Forms.Button buttonAdress;
        private System.Windows.Forms.Button buttonKimJestem;
        private System.Windows.Forms.Button buttonNazwisko;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExit;
    }
}

