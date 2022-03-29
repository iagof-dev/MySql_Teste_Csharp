using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql_Teste_Csharp;
using System.Runtime.InteropServices;

namespace MySql_Teste_Csharp
{
    public partial class Logado : Form
    {
        int menu_aberto = 0;
        int menu_valor_pixels = 9;
        int menu_valor_abrir = 175;
        int menu_valor_fechar = 67;

        public Logado()
        {
            InitializeComponent();
            Console.WriteLine("Menu Form | Loaded!");
            menu_aberto = 0;
            definirform(new menu_home());
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
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result_msg = MessageBox.Show("Deseja sair de sua conta?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result_msg == DialogResult.Yes)
            {
                //sim
                //Inicio.ActiveForm.
                this.Close();
                Logado log = new Logado();
                Form voltar = new Inicio();
                voltar.Show();
                log.Close();
            }
            
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Logado Form | Debug=Mouse_Clicked home Button");
            definirform(new menu_home());
        }

        private void menu_hamburguer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Logado Form | Debug=Mouse_Clicked MENU HAMBURGER Button");
            //menu_aberto = 0 (fechado)
            //menu_aberto = 1 (aberto)

            //175 = Menu Aberto
            //67 = menu fechado
            //menu.Location

            menu_animacao.Stop();
            if (menu_aberto == 1)
            {
                Console.WriteLine("Logado Form | Menu está aberto!");
                menu_aberto = 0;
                menu_animacao.Start();
            }
            else
            {
                Console.WriteLine("Logado Form | Menu está fechado!");
                menu_aberto = 1;
                menu_animacao.Start();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Logado Form | Debug=Mouse_Clicked USER Button");
            definirform(new menu_conta());
        }
        private void menu_animacao_Tick(object sender, EventArgs e)
        {
            menu_animacao.Interval = 1;
            if (menu_aberto == 0)
            {
                if (menu.Width == menu_valor_abrir)
                {
                    menu_animacao.Stop();
                }
                else
                {
                    menu.Width += menu_valor_pixels;
                }
            }
            else
            {
                if (menu_aberto == 1)
                {
                    if (menu.Width == menu_valor_fechar)
                    {
                        menu_animacao.Stop();
                    }
                    else
                    {
                        menu.Width -= menu_valor_pixels;
                    }

                }
            }
        }
    }
}
