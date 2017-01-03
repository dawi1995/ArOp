namespace Projekt
{
    partial class Pulpit_DodajTowarcs
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
            this.label_NazwaTowaru = new System.Windows.Forms.Label();
            this.label_IdTowaru = new System.Windows.Forms.Label();
            this.label_Sektor = new System.Windows.Forms.Label();
            this.label_Rzad = new System.Windows.Forms.Label();
            this.label_Polka = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button_DodajNowyTowar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NazwaTowaru
            // 
            this.label_NazwaTowaru.AutoSize = true;
            this.label_NazwaTowaru.Location = new System.Drawing.Point(90, 45);
            this.label_NazwaTowaru.Name = "label_NazwaTowaru";
            this.label_NazwaTowaru.Size = new System.Drawing.Size(81, 13);
            this.label_NazwaTowaru.TabIndex = 0;
            this.label_NazwaTowaru.Text = "Nazwa towaru :";
            // 
            // label_IdTowaru
            // 
            this.label_IdTowaru.AutoSize = true;
            this.label_IdTowaru.Location = new System.Drawing.Point(90, 94);
            this.label_IdTowaru.Name = "label_IdTowaru";
            this.label_IdTowaru.Size = new System.Drawing.Size(59, 13);
            this.label_IdTowaru.TabIndex = 1;
            this.label_IdTowaru.Text = "ID towaru :";
            // 
            // label_Sektor
            // 
            this.label_Sektor.AutoSize = true;
            this.label_Sektor.Location = new System.Drawing.Point(90, 142);
            this.label_Sektor.Name = "label_Sektor";
            this.label_Sektor.Size = new System.Drawing.Size(44, 13);
            this.label_Sektor.TabIndex = 2;
            this.label_Sektor.Text = "Sektor :";
            // 
            // label_Rzad
            // 
            this.label_Rzad.AutoSize = true;
            this.label_Rzad.Location = new System.Drawing.Point(90, 190);
            this.label_Rzad.Name = "label_Rzad";
            this.label_Rzad.Size = new System.Drawing.Size(38, 13);
            this.label_Rzad.TabIndex = 3;
            this.label_Rzad.Text = "Rząd :";
            // 
            // label_Polka
            // 
            this.label_Polka.AutoSize = true;
            this.label_Polka.Location = new System.Drawing.Point(90, 241);
            this.label_Polka.Name = "label_Polka";
            this.label_Polka.Size = new System.Drawing.Size(42, 13);
            this.label_Polka.TabIndex = 4;
            this.label_Polka.Text = "Półka :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(249, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(249, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 20);
            this.textBox5.TabIndex = 9;
            // 
            // button_DodajNowyTowar
            // 
            this.button_DodajNowyTowar.Location = new System.Drawing.Point(182, 295);
            this.button_DodajNowyTowar.Name = "button_DodajNowyTowar";
            this.button_DodajNowyTowar.Size = new System.Drawing.Size(201, 23);
            this.button_DodajNowyTowar.TabIndex = 10;
            this.button_DodajNowyTowar.Text = "Dodaj nowy towar";
            this.button_DodajNowyTowar.UseVisualStyleBackColor = true;
            // 
            // Pulpit_DodajTowarcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 353);
            this.Controls.Add(this.button_DodajNowyTowar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Polka);
            this.Controls.Add(this.label_Rzad);
            this.Controls.Add(this.label_Sektor);
            this.Controls.Add(this.label_IdTowaru);
            this.Controls.Add(this.label_NazwaTowaru);
            this.Name = "Pulpit_DodajTowarcs";
            this.Text = "Pulpit_DodajTowar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NazwaTowaru;
        private System.Windows.Forms.Label label_IdTowaru;
        private System.Windows.Forms.Label label_Sektor;
        private System.Windows.Forms.Label label_Rzad;
        private System.Windows.Forms.Label label_Polka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button_DodajNowyTowar;
    }
}