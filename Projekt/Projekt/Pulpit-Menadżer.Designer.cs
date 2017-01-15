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
            this.button_DodajEdytujPracownika = new System.Windows.Forms.Button();
            this.button_UsunPracownika = new System.Windows.Forms.Button();
            this.button_ZmieńGrafik = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Wyloguj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_pracownicyOdswiez = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_pokazPracownikow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_DodajEdytujPracownika
            // 
            this.button_DodajEdytujPracownika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_DodajEdytujPracownika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DodajEdytujPracownika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DodajEdytujPracownika.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DodajEdytujPracownika.Location = new System.Drawing.Point(10, 10);
            this.button_DodajEdytujPracownika.Margin = new System.Windows.Forms.Padding(10);
            this.button_DodajEdytujPracownika.Name = "button_DodajEdytujPracownika";
            this.button_DodajEdytujPracownika.Size = new System.Drawing.Size(180, 40);
            this.button_DodajEdytujPracownika.TabIndex = 1;
            this.button_DodajEdytujPracownika.Text = "Dodaj/edytuj pracownika";
            this.button_DodajEdytujPracownika.UseVisualStyleBackColor = false;
            this.button_DodajEdytujPracownika.Click += new System.EventHandler(this.button_DodajEdytujPracownika_Click);
            // 
            // button_UsunPracownika
            // 
            this.button_UsunPracownika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_UsunPracownika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_UsunPracownika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UsunPracownika.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UsunPracownika.Location = new System.Drawing.Point(10, 53);
            this.button_UsunPracownika.Margin = new System.Windows.Forms.Padding(10);
            this.button_UsunPracownika.Name = "button_UsunPracownika";
            this.button_UsunPracownika.Size = new System.Drawing.Size(180, 40);
            this.button_UsunPracownika.TabIndex = 2;
            this.button_UsunPracownika.Text = "Usun pracownika";
            this.button_UsunPracownika.UseVisualStyleBackColor = false;
            this.button_UsunPracownika.Click += new System.EventHandler(this.button_UsunPracownika_Click);
            // 
            // button_ZmieńGrafik
            // 
            this.button_ZmieńGrafik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_ZmieńGrafik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ZmieńGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZmieńGrafik.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ZmieńGrafik.Location = new System.Drawing.Point(10, 96);
            this.button_ZmieńGrafik.Margin = new System.Windows.Forms.Padding(10);
            this.button_ZmieńGrafik.Name = "button_ZmieńGrafik";
            this.button_ZmieńGrafik.Size = new System.Drawing.Size(180, 40);
            this.button_ZmieńGrafik.TabIndex = 3;
            this.button_ZmieńGrafik.Text = "Dodaj grafik";
            this.button_ZmieńGrafik.UseVisualStyleBackColor = false;
            this.button_ZmieńGrafik.Click += new System.EventHandler(this.button_ZmieńGrafik_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(10, 184);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Usun z grafiku";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edytuj grafik";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_pokazPracownikow);
            this.panel1.Controls.Add(this.button_DodajEdytujPracownika);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_UsunPracownika);
            this.panel1.Controls.Add(this.button_ZmieńGrafik);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 478);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button_pracownicyOdswiez);
            this.panel2.Location = new System.Drawing.Point(219, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 454);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // button_pracownicyOdswiez
            // 
            this.button_pracownicyOdswiez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_pracownicyOdswiez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pracownicyOdswiez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pracownicyOdswiez.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pracownicyOdswiez.Location = new System.Drawing.Point(303, 7);
            this.button_pracownicyOdswiez.Margin = new System.Windows.Forms.Padding(10);
            this.button_pracownicyOdswiez.Name = "button_pracownicyOdswiez";
            this.button_pracownicyOdswiez.Size = new System.Drawing.Size(180, 40);
            this.button_pracownicyOdswiez.TabIndex = 5;
            this.button_pracownicyOdswiez.Text = "Odswiez";
            this.button_pracownicyOdswiez.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 388);
            this.dataGridView1.TabIndex = 6;
            // 
            // button_pokazPracownikow
            // 
            this.button_pokazPracownikow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_pokazPracownikow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pokazPracownikow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pokazPracownikow.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pokazPracownikow.Location = new System.Drawing.Point(10, 270);
            this.button_pokazPracownikow.Margin = new System.Windows.Forms.Padding(10);
            this.button_pokazPracownikow.Name = "button_pokazPracownikow";
            this.button_pokazPracownikow.Size = new System.Drawing.Size(180, 40);
            this.button_pokazPracownikow.TabIndex = 7;
            this.button_pokazPracownikow.Text = "Pokaz pracowników";
            this.button_pokazPracownikow.UseVisualStyleBackColor = false;
            this.button_pokazPracownikow.Click += new System.EventHandler(this.button_pokazPracownikow_Click);
            // 
            // Pulpit_Menadżer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(717, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Wyloguj);
            this.Name = "Pulpit_Menadżer";
            this.Text = "Pulpit_Menadżer";
            this.Load += new System.EventHandler(this.Pulpit_Menadżer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_DodajEdytujPracownika;
        private System.Windows.Forms.Button button_UsunPracownika;
        private System.Windows.Forms.Button button_ZmieńGrafik;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Wyloguj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_pokazPracownikow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_pracownicyOdswiez;
    }
}