namespace Projekt
{
    partial class Pulpit_UsunTowar
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sektor = new System.Windows.Forms.TextBox();
            this.textBox_rzad = new System.Windows.Forms.TextBox();
            this.textBox_polka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ilosc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_idtowaru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sektor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rząd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Półka:";
            // 
            // textBox_sektor
            // 
            this.textBox_sektor.Location = new System.Drawing.Point(225, 51);
            this.textBox_sektor.Name = "textBox_sektor";
            this.textBox_sektor.Size = new System.Drawing.Size(197, 20);
            this.textBox_sektor.TabIndex = 3;
            // 
            // textBox_rzad
            // 
            this.textBox_rzad.Location = new System.Drawing.Point(225, 82);
            this.textBox_rzad.Name = "textBox_rzad";
            this.textBox_rzad.Size = new System.Drawing.Size(197, 20);
            this.textBox_rzad.TabIndex = 4;
            // 
            // textBox_polka
            // 
            this.textBox_polka.Location = new System.Drawing.Point(225, 113);
            this.textBox_polka.Name = "textBox_polka";
            this.textBox_polka.Size = new System.Drawing.Size(197, 20);
            this.textBox_polka.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ilość:";
            // 
            // textBox_ilosc
            // 
            this.textBox_ilosc.Location = new System.Drawing.Point(225, 147);
            this.textBox_ilosc.Name = "textBox_ilosc";
            this.textBox_ilosc.Size = new System.Drawing.Size(197, 20);
            this.textBox_ilosc.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID towaru:";
            // 
            // textBox_idtowaru
            // 
            this.textBox_idtowaru.Location = new System.Drawing.Point(225, 20);
            this.textBox_idtowaru.Name = "textBox_idtowaru";
            this.textBox_idtowaru.Size = new System.Drawing.Size(197, 20);
            this.textBox_idtowaru.TabIndex = 10;
            // 
            // Pulpit_UsunTowar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 331);
            this.Controls.Add(this.textBox_idtowaru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ilosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_polka);
            this.Controls.Add(this.textBox_rzad);
            this.Controls.Add(this.textBox_sektor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pulpit_UsunTowar";
            this.Text = "Pulpit_UsunTowar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sektor;
        private System.Windows.Forms.TextBox textBox_rzad;
        private System.Windows.Forms.TextBox textBox_polka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ilosc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_idtowaru;
    }
}