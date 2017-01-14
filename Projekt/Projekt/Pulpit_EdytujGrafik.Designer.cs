namespace Projekt
{
    partial class Pulpit_EdytujGrafik
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_idpracownika = new System.Windows.Forms.TextBox();
            this.textBox_datadozmiany = new System.Windows.Forms.TextBox();
            this.textBox_nowadata = new System.Windows.Forms.TextBox();
            this.textBox_czaspracy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID pracownika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data do zmiany:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nowa data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Czas pracy:";
            // 
            // textBox_idpracownika
            // 
            this.textBox_idpracownika.Location = new System.Drawing.Point(297, 17);
            this.textBox_idpracownika.Name = "textBox_idpracownika";
            this.textBox_idpracownika.Size = new System.Drawing.Size(132, 20);
            this.textBox_idpracownika.TabIndex = 4;
            // 
            // textBox_datadozmiany
            // 
            this.textBox_datadozmiany.Location = new System.Drawing.Point(297, 50);
            this.textBox_datadozmiany.Name = "textBox_datadozmiany";
            this.textBox_datadozmiany.Size = new System.Drawing.Size(132, 20);
            this.textBox_datadozmiany.TabIndex = 5;
            // 
            // textBox_nowadata
            // 
            this.textBox_nowadata.Location = new System.Drawing.Point(297, 78);
            this.textBox_nowadata.Name = "textBox_nowadata";
            this.textBox_nowadata.Size = new System.Drawing.Size(132, 20);
            this.textBox_nowadata.TabIndex = 6;
            // 
            // textBox_czaspracy
            // 
            this.textBox_czaspracy.Location = new System.Drawing.Point(297, 110);
            this.textBox_czaspracy.Name = "textBox_czaspracy";
            this.textBox_czaspracy.Size = new System.Drawing.Size(132, 20);
            this.textBox_czaspracy.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edytuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pulpit_EdytujGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_czaspracy);
            this.Controls.Add(this.textBox_nowadata);
            this.Controls.Add(this.textBox_datadozmiany);
            this.Controls.Add(this.textBox_idpracownika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pulpit_EdytujGrafik";
            this.Text = "Pulpit_EdytujGrafik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_idpracownika;
        private System.Windows.Forms.TextBox textBox_datadozmiany;
        private System.Windows.Forms.TextBox textBox_nowadata;
        private System.Windows.Forms.TextBox textBox_czaspracy;
        private System.Windows.Forms.Button button1;
    }
}