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
        string server_Data = "datasource=" + Properties.Settings.Default.mysql_ip + ";username=" + Properties.Settings.Default.mysql_user + ";password=" + Properties.Settings.Default.mysql_pass + ";database=" + Properties.Settings.Default.mysql_database;
        public menu_home()
        {
            InitializeComponent();

            if (Properties.Settings.Default.test_mode == "1")
            {
                Console.WriteLine("menu_home | test_mode ativado = 1!");
                text_user.Text = (Properties.Settings.Default.user_name);
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(server_Data);
                string comando = "use cadastro; select * from registro where email=@email;";
                MySqlCommand cmd = new MySqlCommand(comando, conn);
                cmd.Parameters.AddWithValue("@email", Properties.Settings.Default.user_email);
                conn.Open();
                MySqlDataReader leitor = cmd.ExecuteReader();
                try
                {
                    leitor.Read();
                    var usuario = leitor.GetString(1);
                    text_user.Text = ($"{usuario}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro debug: " + ex.Message);
                    //Mensagem de Erro
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            Console.WriteLine("menu_home | loaded!");
        }

        private void menu_home_Load(object sender, EventArgs e)
        {
            version_debug.Text = "Ver= " + Application.ProductVersion;

        }
    }
}
