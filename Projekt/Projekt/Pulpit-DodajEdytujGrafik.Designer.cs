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
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.textBox_LiczbaGodzin = new System.Windows.Forms.TextBox();
            this.textBox_idpracownika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(94, 54);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(39, 13);
            this.label_Data.TabIndex = 0;
            this.label_Data.Text = "Data : ";
            // 
            // label_GodzinyPracy
            // 
            this.label_GodzinyPracy.AutoSize = true;
            this.label_GodzinyPracy.Location = new System.Drawing.Point(94, 83);
            this.label_GodzinyPracy.Name = "label_GodzinyPracy";
            this.label_GodzinyPracy.Size = new System.Drawing.Size(78, 13);
            this.label_GodzinyPracy.TabIndex = 1;
            this.label_GodzinyPracy.Text = "Liczba godzin :";
            // 
            // label_DataDoEdycji
            // 
            this.label_DataDoEdycji.AutoSize = true;
            this.label_DataDoEdycji.Location = new System.Drawing.Point(94, 26);
            this.label_DataDoEdycji.Name = "label_DataDoEdycji";
            this.label_DataDoEdycji.Size = new System.Drawing.Size(79, 13);
            this.label_DataDoEdycji.TabIndex = 2;
            this.label_DataDoEdycji.Text = "ID pracownika:";
            // 
            // button_DodajEdytujGrafik
            // 
            this.button_DodajEdytujGrafik.Location = new System.Drawing.Point(156, 212);
            this.button_DodajEdytujGrafik.Name = "button_DodajEdytujGrafik";
            this.button_DodajEdytujGrafik.Size = new System.Drawing.Size(260, 23);
            this.button_DodajEdytujGrafik.TabIndex = 3;
            this.button_DodajEdytujGrafik.Text = "Dodaj do grafiku";
            this.button_DodajEdytujGrafik.UseVisualStyleBackColor = true;
            this.button_DodajEdytujGrafik.Click += new System.EventHandler(this.button_DodajEdytujGrafik_Click);
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(238, 51);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(215, 20);
            this.textBox_Data.TabIndex = 5;
            // 
            // textBox_LiczbaGodzin
            // 
            this.textBox_LiczbaGodzin.Location = new System.Drawing.Point(238, 80);
            this.textBox_LiczbaGodzin.Name = "textBox_LiczbaGodzin";
            this.textBox_LiczbaGodzin.Size = new System.Drawing.Size(215, 20);
            this.textBox_LiczbaGodzin.TabIndex = 6;
            // 
            // textBox_idpracownika
            // 
            this.textBox_idpracownika.Location = new System.Drawing.Point(238, 23);
            this.textBox_idpracownika.Name = "textBox_idpracownika";
            this.textBox_idpracownika.Size = new System.Drawing.Size(215, 20);
            this.textBox_idpracownika.TabIndex = 7;
            // 
            // Pulpit_DodajEdytujGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 308);
            this.Controls.Add(this.textBox_idpracownika);
            this.Controls.Add(this.textBox_LiczbaGodzin);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.button_DodajEdytujGrafik);
            this.Controls.Add(this.label_DataDoEdycji);
            this.Controls.Add(this.label_GodzinyPracy);
            this.Controls.Add(this.label_Data);
            this.Name = "Pulpit_DodajEdytujGrafik";
            this.Text = "Pulpit_DodajGrafik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Label label_GodzinyPracy;
        private System.Windows.Forms.Label label_DataDoEdycji;
        private System.Windows.Forms.Button button_DodajEdytujGrafik;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.TextBox textBox_LiczbaGodzin;
        private System.Windows.Forms.TextBox textBox_idpracownika;
    }
}