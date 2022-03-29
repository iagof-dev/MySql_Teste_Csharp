using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql_Teste_Csharp
{
    public partial class inicio_home : Form
    {
        public inicio_home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://n3rdydzn.xyz/");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/n3rdydzn");
        }

        private void inicio_home_Load(object sender, EventArgs e)
        {
            ///debug_version.Text = "Version: " + Application.ProductVersion;
           debug_version.Text = "Version: Development";
        }
    }
}
