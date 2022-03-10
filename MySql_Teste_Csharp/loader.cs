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
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }
        private void loader_Load(object sender, EventArgs e)
        {
            Form loader_abrir = new Inicio();
            loader_abrir.ShowDialog();
        }

    }
}
