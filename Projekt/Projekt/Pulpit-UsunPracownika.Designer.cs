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
            this.button_UsunPracownika = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.textbox_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_UsunPracownika
            // 
            this.button_UsunPracownika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.button_UsunPracownika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_UsunPracownika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UsunPracownika.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UsunPracownika.Location = new System.Drawing.Point(105, 100);
            this.button_UsunPracownika.Name = "button_UsunPracownika";
            this.button_UsunPracownika.Size = new System.Drawing.Size(180, 40);
            this.button_UsunPracownika.TabIndex = 14;
            this.button_UsunPracownika.Text = "Usun pracownika";
            this.button_UsunPracownika.UseVisualStyleBackColor = false;
            this.button_UsunPracownika.Click += new System.EventHandler(this.button_UsunPracownika_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(57)))));
            this.label_ID.Location = new System.Drawing.Point(12, 15);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(32, 25);
            this.label_ID.TabIndex = 15;
            this.label_ID.Text = "ID :";
            // 
            // textbox_ID
            // 
            this.textbox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.textbox_ID.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ID.Location = new System.Drawing.Point(157, 12);
            this.textbox_ID.Name = "textbox_ID";
            this.textbox_ID.Size = new System.Drawing.Size(215, 32);
            this.textbox_ID.TabIndex = 16;
            // 
            // Pulpit_UsunPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.textbox_ID);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.button_UsunPracownika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pulpit_UsunPracownika";
            this.Text = "Pulpit_UsunPracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_UsunPracownika;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textbox_ID;
    }
}