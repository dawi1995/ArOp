﻿namespace Projekt
{
    partial class Pulpit_Pracownik
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
            this.button_DodajTowar = new System.Windows.Forms.Button();
            this.button_DodajIstTowar = new System.Windows.Forms.Button();
            this.button_UsuńTowar = new System.Windows.Forms.Button();
            this.button_SprawdzZlecenia = new System.Windows.Forms.Button();
            this.button_SprawdzGrafik = new System.Windows.Forms.Button();
            this.button_Wyloguj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_DodajTowar
            // 
            this.button_DodajTowar.Location = new System.Drawing.Point(890, 77);
            this.button_DodajTowar.Name = "button_DodajTowar";
            this.button_DodajTowar.Size = new System.Drawing.Size(327, 23);
            this.button_DodajTowar.TabIndex = 1;
            this.button_DodajTowar.Text = "Dodaj nowy towar";
            this.button_DodajTowar.UseVisualStyleBackColor = true;
            this.button_DodajTowar.Click += new System.EventHandler(this.button_DodajTowar_Click);
            // 
            // button_DodajIstTowar
            // 
            this.button_DodajIstTowar.Location = new System.Drawing.Point(890, 143);
            this.button_DodajIstTowar.Name = "button_DodajIstTowar";
            this.button_DodajIstTowar.Size = new System.Drawing.Size(327, 23);
            this.button_DodajIstTowar.TabIndex = 2;
            this.button_DodajIstTowar.Text = "Dodaj istniejący towar";
            this.button_DodajIstTowar.UseVisualStyleBackColor = true;
            this.button_DodajIstTowar.Click += new System.EventHandler(this.button_DodajIstTowar_Click);
            // 
            // button_UsuńTowar
            // 
            this.button_UsuńTowar.Location = new System.Drawing.Point(890, 214);
            this.button_UsuńTowar.Name = "button_UsuńTowar";
            this.button_UsuńTowar.Size = new System.Drawing.Size(327, 23);
            this.button_UsuńTowar.TabIndex = 3;
            this.button_UsuńTowar.Text = "Usuń towar";
            this.button_UsuńTowar.UseVisualStyleBackColor = true;
            this.button_UsuńTowar.Click += new System.EventHandler(this.button_UsuńTowar_Click);
            // 
            // button_SprawdzZlecenia
            // 
            this.button_SprawdzZlecenia.Location = new System.Drawing.Point(890, 451);
            this.button_SprawdzZlecenia.Name = "button_SprawdzZlecenia";
            this.button_SprawdzZlecenia.Size = new System.Drawing.Size(327, 23);
            this.button_SprawdzZlecenia.TabIndex = 5;
            this.button_SprawdzZlecenia.Text = "Sprawdz swoje zlecenia";
            this.button_SprawdzZlecenia.UseVisualStyleBackColor = true;
            // 
            // button_SprawdzGrafik
            // 
            this.button_SprawdzGrafik.Location = new System.Drawing.Point(890, 502);
            this.button_SprawdzGrafik.Name = "button_SprawdzGrafik";
            this.button_SprawdzGrafik.Size = new System.Drawing.Size(327, 23);
            this.button_SprawdzGrafik.TabIndex = 6;
            this.button_SprawdzGrafik.Text = "Wyświetl grafik";
            this.button_SprawdzGrafik.UseVisualStyleBackColor = true;
            // 
            // button_Wyloguj
            // 
            this.button_Wyloguj.Location = new System.Drawing.Point(1143, 630);
            this.button_Wyloguj.Name = "button_Wyloguj";
            this.button_Wyloguj.Size = new System.Drawing.Size(117, 23);
            this.button_Wyloguj.TabIndex = 7;
            this.button_Wyloguj.Text = "Wyloguj";
            this.button_Wyloguj.UseVisualStyleBackColor = true;
            this.button_Wyloguj.Click += new System.EventHandler(this.button_Wyloguj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 478);
            this.panel1.TabIndex = 8;
            // 
            // Pulpit_Pracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Wyloguj);
            this.Controls.Add(this.button_SprawdzGrafik);
            this.Controls.Add(this.button_SprawdzZlecenia);
            this.Controls.Add(this.button_UsuńTowar);
            this.Controls.Add(this.button_DodajIstTowar);
            this.Controls.Add(this.button_DodajTowar);
            this.Name = "Pulpit_Pracownik";
            this.Text = "Pulpit_Pracownik";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_DodajTowar;
        private System.Windows.Forms.Button button_DodajIstTowar;
        private System.Windows.Forms.Button button_UsuńTowar;
        private System.Windows.Forms.Button button_SprawdzZlecenia;
        private System.Windows.Forms.Button button_SprawdzGrafik;
        private System.Windows.Forms.Button button_Wyloguj;
        private System.Windows.Forms.Panel panel1;
    }
}