namespace Projekt
{
    partial class Pulpit_UsunPracownika
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_PESEL = new System.Windows.Forms.Label();
            this.label_Nazwisko = new System.Windows.Forms.Label();
            this.label_Imie = new System.Windows.Forms.Label();
            this.button_UsunPracownika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label_PESEL
            // 
            this.label_PESEL.AutoSize = true;
            this.label_PESEL.Location = new System.Drawing.Point(77, 133);
            this.label_PESEL.Name = "label_PESEL";
            this.label_PESEL.Size = new System.Drawing.Size(47, 13);
            this.label_PESEL.TabIndex = 10;
            this.label_PESEL.Text = "PESEL :";
            // 
            // label_Nazwisko
            // 
            this.label_Nazwisko.AutoSize = true;
            this.label_Nazwisko.Location = new System.Drawing.Point(77, 88);
            this.label_Nazwisko.Name = "label_Nazwisko";
            this.label_Nazwisko.Size = new System.Drawing.Size(59, 13);
            this.label_Nazwisko.TabIndex = 9;
            this.label_Nazwisko.Text = "Nazwisko :";
            // 
            // label_Imie
            // 
            this.label_Imie.AutoSize = true;
            this.label_Imie.Location = new System.Drawing.Point(77, 41);
            this.label_Imie.Name = "label_Imie";
            this.label_Imie.Size = new System.Drawing.Size(32, 13);
            this.label_Imie.TabIndex = 8;
            this.label_Imie.Text = "Imię :";
            // 
            // button_UsunPracownika
            // 
            this.button_UsunPracownika.Location = new System.Drawing.Point(119, 195);
            this.button_UsunPracownika.Name = "button_UsunPracownika";
            this.button_UsunPracownika.Size = new System.Drawing.Size(244, 23);
            this.button_UsunPracownika.TabIndex = 14;
            this.button_UsunPracownika.Text = "Usuń pracownika";
            this.button_UsunPracownika.UseVisualStyleBackColor = true;
            // 
            // Pulpit_UsunPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 269);
            this.Controls.Add(this.button_UsunPracownika);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_PESEL);
            this.Controls.Add(this.label_Nazwisko);
            this.Controls.Add(this.label_Imie);
            this.Name = "Pulpit_UsunPracownika";
            this.Text = "Pulpit_UsunPracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_PESEL;
        private System.Windows.Forms.Label label_Nazwisko;
        private System.Windows.Forms.Label label_Imie;
        private System.Windows.Forms.Button button_UsunPracownika;
    }
}