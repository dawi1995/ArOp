namespace Projekt
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Haslo = new System.Windows.Forms.Label();
            this.button_Zaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(147, 83);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(39, 13);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Login :";
            // 
            // label_Haslo
            // 
            this.label_Haslo.AutoSize = true;
            this.label_Haslo.Location = new System.Drawing.Point(147, 142);
            this.label_Haslo.Name = "label_Haslo";
            this.label_Haslo.Size = new System.Drawing.Size(42, 13);
            this.label_Haslo.TabIndex = 3;
            this.label_Haslo.Text = "Hasło :";
            // 
            // button_Zaloguj
            // 
            this.button_Zaloguj.Location = new System.Drawing.Point(214, 208);
            this.button_Zaloguj.Name = "button_Zaloguj";
            this.button_Zaloguj.Size = new System.Drawing.Size(163, 23);
            this.button_Zaloguj.TabIndex = 4;
            this.button_Zaloguj.Text = "Zaloguj";
            this.button_Zaloguj.UseVisualStyleBackColor = true;
            this.button_Zaloguj.Click += new System.EventHandler(this.button_Zaloguj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 293);
            this.Controls.Add(this.button_Zaloguj);
            this.Controls.Add(this.label_Haslo);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Haslo;
        private System.Windows.Forms.Button button_Zaloguj;
    }
}

