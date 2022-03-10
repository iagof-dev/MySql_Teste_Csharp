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
            //this.Hide();
            System.Threading.Thread.Sleep(30);
            Form form = new registrar();
            form.ShowDialog();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://n3rdydzn.xyz/");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/n3rdydzn");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server_Data = "datasource=" + Properties.Settings.Default.mysql_ip + ";username=" + Properties.Settings.Default.mysql_user + ";password=" + Properties.Settings.Default.mysql_pass + ";database=" + Properties.Settings.Default.mysql_database;
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(30);
            Form login = new login();
            login.ShowDialog();
            this.Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1 | loaded");
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Form debug = new Logado();
            debug.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
