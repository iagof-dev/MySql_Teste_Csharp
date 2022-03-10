namespace MySql_Teste_Csharp
{
    partial class menu_home
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
            this.BemVindo = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.Label();
            this.version_debug = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BemVindo
            // 
            this.BemVindo.AutoSize = true;
            this.BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindo.ForeColor = System.Drawing.Color.White;
            this.BemVindo.Location = new System.Drawing.Point(368, 145);
            this.BemVindo.Name = "BemVindo";
            this.BemVindo.Size = new System.Drawing.Size(210, 42);
            this.BemVindo.TabIndex = 0;
            this.BemVindo.Text = "Bem Vindo!";
            // 
            // text_user
            // 
            this.text_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user.ForeColor = System.Drawing.Color.MediumPurple;
            this.text_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.text_user.Location = new System.Drawing.Point(308, 187);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(324, 62);
            this.text_user.TabIndex = 1;
            this.text_user.Text = "$user_text$";
            this.text_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // version_debug
            // 
            this.version_debug.AutoSize = true;
            this.version_debug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.version_debug.Location = new System.Drawing.Point(865, 474);
            this.version_debug.Name = "version_debug";
            this.version_debug.Size = new System.Drawing.Size(29, 13);
            this.version_debug.TabIndex = 2;
            this.version_debug.Text = "Ver=";
            this.version_debug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(833, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(833, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(940, 496);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.version_debug);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.BemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu_home";
            this.Text = "menu_home";
            this.Load += new System.EventHandler(this.menu_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemVindo;
        private System.Windows.Forms.Label text_user;
        private System.Windows.Forms.Label version_debug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}