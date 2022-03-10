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
            this.SuspendLayout();
            // 
            // registro_user
            // 
            this.registro_user.Location = new System.Drawing.Point(50, 80);
            this.registro_user.Name = "registro_user";
            this.registro_user.Size = new System.Drawing.Size(157, 20);
            this.registro_user.TabIndex = 0;
            // 
            // registro_senha
            // 
            this.registro_senha.Location = new System.Drawing.Point(50, 181);
            this.registro_senha.Name = "registro_senha";
            this.registro_senha.PasswordChar = '*';
            this.registro_senha.Size = new System.Drawing.Size(157, 20);
            this.registro_senha.TabIndex = 1;
            // 
            // registro_email
            // 
            this.registro_email.Location = new System.Drawing.Point(50, 132);
            this.registro_email.Name = "registro_email";
            this.registro_email.Size = new System.Drawing.Size(157, 20);
            this.registro_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registro_email);
            this.Controls.Add(this.registro_senha);
            this.Controls.Add(this.registro_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "registrar";
            this.Text = "registrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registrar_FormClosed);
            this.Load += new System.EventHandler(this.registrar_Load);
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
    }
}