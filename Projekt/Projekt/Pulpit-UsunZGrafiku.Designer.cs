namespace Projekt
{
    partial class Pulpit_UsunZGrafiku
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
            this.label_DataDoUsunięcia = new System.Windows.Forms.Label();
            this.textBox_idracownika = new System.Windows.Forms.TextBox();
            this.button_UsunZGrafiku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dataDoUsuniecia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_DataDoUsunięcia
            // 
            this.label_DataDoUsunięcia.AutoSize = true;
            this.label_DataDoUsunięcia.Location = new System.Drawing.Point(24, 26);
            this.label_DataDoUsunięcia.Name = "label_DataDoUsunięcia";
            this.label_DataDoUsunięcia.Size = new System.Drawing.Size(82, 13);
            this.label_DataDoUsunięcia.TabIndex = 0;
            this.label_DataDoUsunięcia.Text = "ID pracownika :";
            // 
            // textBox_idracownika
            // 
            this.textBox_idracownika.Location = new System.Drawing.Point(159, 23);
            this.textBox_idracownika.Name = "textBox_idracownika";
            this.textBox_idracownika.Size = new System.Drawing.Size(196, 20);
            this.textBox_idracownika.TabIndex = 1;
            // 
            // button_UsunZGrafiku
            // 
            this.button_UsunZGrafiku.Location = new System.Drawing.Point(112, 231);
            this.button_UsunZGrafiku.Name = "button_UsunZGrafiku";
            this.button_UsunZGrafiku.Size = new System.Drawing.Size(185, 23);
            this.button_UsunZGrafiku.TabIndex = 2;
            this.button_UsunZGrafiku.Text = "Usuń z grafiku";
            this.button_UsunZGrafiku.UseVisualStyleBackColor = true;
            this.button_UsunZGrafiku.Click += new System.EventHandler(this.button_UsunZGrafiku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data do usunięcia :";
            // 
            // textBox_dataDoUsuniecia
            // 
            this.textBox_dataDoUsuniecia.Location = new System.Drawing.Point(159, 54);
            this.textBox_dataDoUsuniecia.Name = "textBox_dataDoUsuniecia";
            this.textBox_dataDoUsuniecia.Size = new System.Drawing.Size(196, 20);
            this.textBox_dataDoUsuniecia.TabIndex = 4;
            // 
            // Pulpit_UsunZGrafiku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 266);
            this.Controls.Add(this.textBox_dataDoUsuniecia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_UsunZGrafiku);
            this.Controls.Add(this.textBox_idracownika);
            this.Controls.Add(this.label_DataDoUsunięcia);
            this.Name = "Pulpit_UsunZGrafiku";
            this.Text = "Pulpit_UsunZGrafiku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DataDoUsunięcia;
        private System.Windows.Forms.TextBox textBox_idracownika;
        private System.Windows.Forms.Button button_UsunZGrafiku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dataDoUsuniecia;
    }
}