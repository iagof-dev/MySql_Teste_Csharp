using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace MySql_Teste_Csharp
{



    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }
        private void loader_Load(object sender, EventArgs e)
        {

            setinfo();
            abrirform();

        }

        public void abrirform()
        {
            Form loader_abrir = new Inicio();
            loader_abrir.ShowDialog();
        }

        public void setinfo()
        {
            Properties.Settings.Default.user_name = String.Empty;
            Properties.Settings.Default.user_pfp = String.Empty;
            Properties.Settings.Default.user_group = String.Empty;
            Properties.Settings.Default.user_id = String.Empty;
            Properties.Settings.Default.all_loaded = String.Empty;
            Properties.Settings.Default.user_email = String.Empty;
            Properties.Settings.Default.Save();
        }
        public void v_update()
            {
            System.Net.WebClient vup = new System.Net.WebClient();
            string upverify = vup.DownloadString("http://localhost/teste_up.txt");

            if (upverify == Application.ProductVersion)
            {
              Console.WriteLine("Loader Form | Versão Mais Recente sendo utilizada!");
              setinfo();
              abrirform();
            }
            else
            {
                MessageBox.Show("Versão Desatualizada!", "Atualização!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

    }
}
