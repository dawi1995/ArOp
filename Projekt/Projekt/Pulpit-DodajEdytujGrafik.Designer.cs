namespace Projekt
{
    partial class Pulpit_DodajEdytujGrafik
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
            this.label_Data = new System.Windows.Forms.Label();
            this.label_GodzinyPracy = new System.Windows.Forms.Label();
            this.label_DataDoEdycji = new System.Windows.Forms.Label();
            this.button_DodajEdytujGrafik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.textBox_LiczbaGodzin = new System.Windows.Forms.TextBox();
            this.textBox_DataDoEdycji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(95, 39);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(39, 13);
            this.label_Data.TabIndex = 0;
            this.label_Data.Text = "Data : ";
            // 
            // label_GodzinyPracy
            // 
            this.label_GodzinyPracy.AutoSize = true;
            this.label_GodzinyPracy.Location = new System.Drawing.Point(95, 89);
            this.label_GodzinyPracy.Name = "label_GodzinyPracy";
            this.label_GodzinyPracy.Size = new System.Drawing.Size(78, 13);
            this.label_GodzinyPracy.TabIndex = 1;
            this.label_GodzinyPracy.Text = "Liczba godzin :";
            // 
            // label_DataDoEdycji
            // 
            this.label_DataDoEdycji.AutoSize = true;
            this.label_DataDoEdycji.Location = new System.Drawing.Point(95, 140);
            this.label_DataDoEdycji.Name = "label_DataDoEdycji";
            this.label_DataDoEdycji.Size = new System.Drawing.Size(88, 13);
            this.label_DataDoEdycji.TabIndex = 2;
            this.label_DataDoEdycji.Text = "Data do edycji : *";
            // 
            // button_DodajEdytujGrafik
            // 
            this.button_DodajEdytujGrafik.Location = new System.Drawing.Point(156, 212);
            this.button_DodajEdytujGrafik.Name = "button_DodajEdytujGrafik";
            this.button_DodajEdytujGrafik.Size = new System.Drawing.Size(260, 23);
            this.button_DodajEdytujGrafik.TabIndex = 3;
            this.button_DodajEdytujGrafik.Text = "Dodaj\\Edytuj w grafiku";
            this.button_DodajEdytujGrafik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*pole wymagane tylko przy edycji grafiku";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(239, 36);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(215, 20);
            this.textBox_Data.TabIndex = 5;
            // 
            // textBox_LiczbaGodzin
            // 
            this.textBox_LiczbaGodzin.Location = new System.Drawing.Point(239, 86);
            this.textBox_LiczbaGodzin.Name = "textBox_LiczbaGodzin";
            this.textBox_LiczbaGodzin.Size = new System.Drawing.Size(215, 20);
            this.textBox_LiczbaGodzin.TabIndex = 6;
            // 
            // textBox_DataDoEdycji
            // 
            this.textBox_DataDoEdycji.Location = new System.Drawing.Point(239, 137);
            this.textBox_DataDoEdycji.Name = "textBox_DataDoEdycji";
            this.textBox_DataDoEdycji.Size = new System.Drawing.Size(215, 20);
            this.textBox_DataDoEdycji.TabIndex = 7;
            // 
            // Pulpit_DodajEdytujGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 308);
            this.Controls.Add(this.textBox_DataDoEdycji);
            this.Controls.Add(this.textBox_LiczbaGodzin);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_DodajEdytujGrafik);
            this.Controls.Add(this.label_DataDoEdycji);
            this.Controls.Add(this.label_GodzinyPracy);
            this.Controls.Add(this.label_Data);
            this.Name = "Pulpit_DodajEdytujGrafik";
            this.Text = "Pulpit_DodajEdytujGrafik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Label label_GodzinyPracy;
        private System.Windows.Forms.Label label_DataDoEdycji;
        private System.Windows.Forms.Button button_DodajEdytujGrafik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.TextBox textBox_LiczbaGodzin;
        private System.Windows.Forms.TextBox textBox_DataDoEdycji;
    }
}