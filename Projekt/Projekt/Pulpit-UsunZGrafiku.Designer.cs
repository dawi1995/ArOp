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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pulpit_UsunZGrafiku));
            this.label_DataDoUsunięcia = new System.Windows.Forms.Label();
            this.textBox_idracownika = new System.Windows.Forms.TextBox();
            this.button_UsunZGrafiku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dataDoUsuniecia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DataDoUsunięcia
            // 
            this.label_DataDoUsunięcia.AutoSize = true;
            this.label_DataDoUsunięcia.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataDoUsunięcia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.label_DataDoUsunięcia.Location = new System.Drawing.Point(12, 15);
            this.label_DataDoUsunięcia.Name = "label_DataDoUsunięcia";
            this.label_DataDoUsunięcia.Size = new System.Drawing.Size(102, 25);
            this.label_DataDoUsunięcia.TabIndex = 0;
            this.label_DataDoUsunięcia.Text = "ID pracownika :";
            // 
            // textBox_idracownika
            // 
            this.textBox_idracownika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.textBox_idracownika.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idracownika.Location = new System.Drawing.Point(157, 12);
            this.textBox_idracownika.Name = "textBox_idracownika";
            this.textBox_idracownika.Size = new System.Drawing.Size(215, 32);
            this.textBox_idracownika.TabIndex = 1;
            // 
            // button_UsunZGrafiku
            // 
            this.button_UsunZGrafiku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_UsunZGrafiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_UsunZGrafiku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UsunZGrafiku.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UsunZGrafiku.Location = new System.Drawing.Point(192, 162);
            this.button_UsunZGrafiku.Name = "button_UsunZGrafiku";
            this.button_UsunZGrafiku.Size = new System.Drawing.Size(180, 40);
            this.button_UsunZGrafiku.TabIndex = 2;
            this.button_UsunZGrafiku.Text = "Usun z grafiku";
            this.button_UsunZGrafiku.UseVisualStyleBackColor = false;
            this.button_UsunZGrafiku.Click += new System.EventHandler(this.button_UsunZGrafiku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data do usuniecia :";
            // 
            // textBox_dataDoUsuniecia
            // 
            this.textBox_dataDoUsuniecia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.textBox_dataDoUsuniecia.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dataDoUsuniecia.Location = new System.Drawing.Point(157, 50);
            this.textBox_dataDoUsuniecia.Name = "textBox_dataDoUsuniecia";
            this.textBox_dataDoUsuniecia.Size = new System.Drawing.Size(215, 32);
            this.textBox_dataDoUsuniecia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("Agency FB", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(154, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Format: RRRR-MM-DD GG:MM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 129);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Pulpit_UsunZGrafiku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(384, 259);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_dataDoUsuniecia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_UsunZGrafiku);
            this.Controls.Add(this.textBox_idracownika);
            this.Controls.Add(this.label_DataDoUsunięcia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pulpit_UsunZGrafiku";
            this.Text = "Pulpit_UsunZGrafiku";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DataDoUsunięcia;
        private System.Windows.Forms.TextBox textBox_idracownika;
        private System.Windows.Forms.Button button_UsunZGrafiku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dataDoUsuniecia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}