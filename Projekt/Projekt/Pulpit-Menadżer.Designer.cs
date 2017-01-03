namespace Projekt
{
    partial class Pulpit_Menadżer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_DodajEdytujPracownika = new System.Windows.Forms.Button();
            this.button_UsunPracownika = new System.Windows.Forms.Button();
            this.button_ZmieńGrafik = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Wyloguj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_DodajEdytujPracownika
            // 
            this.button_DodajEdytujPracownika.Location = new System.Drawing.Point(874, 101);
            this.button_DodajEdytujPracownika.Name = "button_DodajEdytujPracownika";
            this.button_DodajEdytujPracownika.Size = new System.Drawing.Size(286, 23);
            this.button_DodajEdytujPracownika.TabIndex = 1;
            this.button_DodajEdytujPracownika.Text = "Dodaj/edytuj pracownika";
            this.button_DodajEdytujPracownika.UseVisualStyleBackColor = true;
            this.button_DodajEdytujPracownika.Click += new System.EventHandler(this.button_DodajEdytujPracownika_Click);
            // 
            // button_UsunPracownika
            // 
            this.button_UsunPracownika.Location = new System.Drawing.Point(874, 167);
            this.button_UsunPracownika.Name = "button_UsunPracownika";
            this.button_UsunPracownika.Size = new System.Drawing.Size(286, 23);
            this.button_UsunPracownika.TabIndex = 2;
            this.button_UsunPracownika.Text = "Usuń pracownika";
            this.button_UsunPracownika.UseVisualStyleBackColor = true;
            this.button_UsunPracownika.Click += new System.EventHandler(this.button_UsunPracownika_Click);
            // 
            // button_ZmieńGrafik
            // 
            this.button_ZmieńGrafik.Location = new System.Drawing.Point(874, 303);
            this.button_ZmieńGrafik.Name = "button_ZmieńGrafik";
            this.button_ZmieńGrafik.Size = new System.Drawing.Size(286, 23);
            this.button_ZmieńGrafik.TabIndex = 3;
            this.button_ZmieńGrafik.Text = "Dodaj/edytuj grafik";
            this.button_ZmieńGrafik.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(874, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(286, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Usuń z grafiku";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_Wyloguj
            // 
            this.button_Wyloguj.Location = new System.Drawing.Point(1136, 628);
            this.button_Wyloguj.Name = "button_Wyloguj";
            this.button_Wyloguj.Size = new System.Drawing.Size(117, 23);
            this.button_Wyloguj.TabIndex = 5;
            this.button_Wyloguj.Text = "Wyloguj";
            this.button_Wyloguj.UseVisualStyleBackColor = true;
            // 
            // Pulpit_Menadżer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 582);
            this.Controls.Add(this.button_Wyloguj);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_ZmieńGrafik);
            this.Controls.Add(this.button_UsunPracownika);
            this.Controls.Add(this.button_DodajEdytujPracownika);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pulpit_Menadżer";
            this.Text = "Pulpit_Menadżer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_DodajEdytujPracownika;
        private System.Windows.Forms.Button button_UsunPracownika;
        private System.Windows.Forms.Button button_ZmieńGrafik;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Wyloguj;
    }
}