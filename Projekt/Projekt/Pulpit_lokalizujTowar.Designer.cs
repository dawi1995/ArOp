﻿namespace Projekt
{
    partial class Pulpit_lokalizujTowar
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
            this.textBox_idtowaru = new System.Windows.Forms.TextBox();
            this.button_lokalizuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID towaru:";
            // 
            // textBox_idtowaru
            // 
            this.textBox_idtowaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.textBox_idtowaru.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idtowaru.Location = new System.Drawing.Point(157, 12);
            this.textBox_idtowaru.Name = "textBox_idtowaru";
            this.textBox_idtowaru.Size = new System.Drawing.Size(215, 32);
            this.textBox_idtowaru.TabIndex = 2;
            // 
            // button_lokalizuj
            // 
            this.button_lokalizuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_lokalizuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_lokalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lokalizuj.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lokalizuj.Location = new System.Drawing.Point(105, 100);
            this.button_lokalizuj.Name = "button_lokalizuj";
            this.button_lokalizuj.Size = new System.Drawing.Size(180, 40);
            this.button_lokalizuj.TabIndex = 3;
            this.button_lokalizuj.Text = "Wyszukaj";
            this.button_lokalizuj.UseVisualStyleBackColor = false;
            // 
            // Pulpit_lokalizujTowar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.button_lokalizuj);
            this.Controls.Add(this.textBox_idtowaru);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pulpit_lokalizujTowar";
            this.Text = "Pulpit_lokalizujTowar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_idtowaru;
        private System.Windows.Forms.Button button_lokalizuj;
    }
}