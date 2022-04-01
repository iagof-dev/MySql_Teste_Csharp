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
    public partial class menu_home : Form
    {
        public menu_home()
        {
            InitializeComponent();
            Console.WriteLine("menu_home | test_mode ativado = 1!");
            text_user.Text = (Properties.Settings.Default.user_name);
            Console.WriteLine("menu_home | loaded!");
        }

        private void menu_home_Load(object sender, EventArgs e)
        {
            version_debug.Text = "Ver= " + Application.ProductVersion;

        }
    }
}
