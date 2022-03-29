using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySql_Teste_Csharp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            definirform(new registrar());
        }
        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            definirform(new login());
        }

        public void definirform(object Form)
        {
            if (this.menu_formdocker.Controls.Count > 0)
                this.menu_formdocker.Controls.RemoveAt(0);
            Form menu_func = Form as Form;
            menu_func.TopLevel = false;
            menu_func.Dock = DockStyle.Fill;
            this.menu_formdocker.Controls.Add(menu_func);
            this.menu_formdocker.Tag = menu_func;
            menu_func.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            definirform(new inicio_home());
            unload_acc();
            Console.WriteLine("Form1 | loaded");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            definirform(new inicio_home());
        }
        public void unload_acc()
        {
            Properties.Settings.Default.user_name = String.Empty;
            Properties.Settings.Default.user_pfp = String.Empty;
            Properties.Settings.Default.user_group = String.Empty;
            Properties.Settings.Default.user_id = String.Empty;
            Properties.Settings.Default.all_loaded = String.Empty;
            Properties.Settings.Default.user_email = String.Empty;
        }
    }
}
