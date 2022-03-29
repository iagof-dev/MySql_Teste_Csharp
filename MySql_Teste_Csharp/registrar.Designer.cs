namespace MySql_Teste_Csharp
{
    partial class registrar
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
            this.registro_user = new System.Windows.Forms.TextBox();
            this.registro_senha = new System.Windows.Forms.TextBox();
            this.registro_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registro_user
            // 
            this.registro_user.ForeColor = System.Drawing.Color.Gray;
            this.registro_user.Location = new System.Drawing.Point(240, 98);
            this.registro_user.Name = "registro_user";
            this.registro_user.Size = new System.Drawing.Size(157, 20);
            this.registro_user.TabIndex = 0;
            this.registro_user.Text = "joão_123";
            this.registro_user.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registro_user_MouseDown);
            // 
            // registro_senha
            // 
            this.registro_senha.ForeColor = System.Drawing.Color.Gray;
            this.registro_senha.Location = new System.Drawing.Point(240, 177);
            this.registro_senha.Name = "registro_senha";
            this.registro_senha.PasswordChar = '*';
            this.registro_senha.Size = new System.Drawing.Size(157, 20);
            this.registro_senha.TabIndex = 1;
            this.registro_senha.Text = "***********";
            this.registro_senha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registro_senha_MouseDown);
            // 
            // registro_email
            // 
            this.registro_email.ForeColor = System.Drawing.Color.Gray;
            this.registro_email.Location = new System.Drawing.Point(240, 137);
            this.registro_email.Name = "registro_email";
            this.registro_email.Size = new System.Drawing.Size(157, 20);
            this.registro_email.TabIndex = 2;
            this.registro_email.Text = "exemplo@n3rdydzn.xyz";
            this.registro_email.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registro_email_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySql_Teste_Csharp.Properties.Resources.registration;
            this.pictureBox1.Location = new System.Drawing.Point(93, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registro_email);
            this.Controls.Add(this.registro_senha);
            this.Controls.Add(this.registro_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrar";
            this.Text = "registrar";
            this.Load += new System.EventHandler(this.registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registro_user;
        private System.Windows.Forms.TextBox registro_senha;
        private System.Windows.Forms.TextBox registro_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}