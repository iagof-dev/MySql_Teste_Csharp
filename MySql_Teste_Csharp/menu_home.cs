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
    public partial class menu_home : Form
    {
        public menu_home()
        {
            InitializeComponent();
            Console.WriteLine("menu_home | loaded!");
        }

        private void menu_home_Load(object sender, EventArgs e)
        {
            version_debug.Text = "Ver= " + Application.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_user.Text = "a";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_user.Text = "JAPONESSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text_user.Text = "ASDHF7AS78FG78ASGHF67AS6FG6SAG668*t¨T6ATG6G6g@$%#$&(#¨$&#¨%$@$#%¨&*&#$%¨&#$%¨&$%¨&*#@wYSb VDAVDFAVBUSYFBUAI";
        }
    }
}
