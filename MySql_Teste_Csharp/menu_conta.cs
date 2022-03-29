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
using MySql.Data.MySqlClient;

namespace MySql_Teste_Csharp
{
    public partial class menu_conta : Form
    {
        string server_Data = "datasource=" + Properties.Settings.Default.mysql_ip + ";username=" + Properties.Settings.Default.mysql_user + ";password=" + Properties.Settings.Default.mysql_pass + ";database=" + Properties.Settings.Default.mysql_database;

        public menu_conta()
        {
            InitializeComponent();
            Console.WriteLine("Conta SubForm | Loaded!");
        }

        private void Conta_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.test_mode == "1")
            {
                loaded_setinfo();
            }
            else { 
                if (Properties.Settings.Default.all_loaded == "1")
                {
                    loaded_setinfo();
                }
                else
                {
                    usr_getinfo();
                }
            }

        }

        public void loaded_setinfo()
        {
            Console.WriteLine("Conta SubForm | Todas informações já foram carregadas!");
            cargo_verify(String.Empty);
            WebRequest request2 = WebRequest.Create(Properties.Settings.Default.user_pfp);
            using (var response2 = request2.GetResponse())
            {
                using (var str2 = response2.GetResponseStream())
                {
                    usr_foto.Image = Bitmap.FromStream(str2);
                }
            }
            txt_id.Text = Properties.Settings.Default.user_id;
            txt_email.Text = Properties.Settings.Default.user_email;
            txt_nome.Text = Properties.Settings.Default.user_name;
            Console.WriteLine("Conta SubForm | Informações Carregadas foi setado aos $txt_email$, $txt_nome$, $usr_foto$!");
        }
        public void cargo_verify(string cargo)
        {
            if (Properties.Settings.Default.all_loaded == "0")
            {
                if (cargo == "dev")
                {
                    admin_button.Visible = true;
                    txt_cargo.Text = "👑 Developer";
                    txt_cargo.ForeColor = Color.Yellow;
                }
                else
                {
                    if (cargo == "admin")
                    {
                        admin_button.Visible = false;
                        txt_cargo.Text = "🔑 Administrador";
                        txt_cargo.ForeColor = Color.Red;
                    }
                    else
                    {
                        admin_button.Visible = false;
                        txt_cargo.Text = cargo;
                        txt_cargo.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                if (Properties.Settings.Default.user_group == "dev")
                {
                    admin_button.Visible = true;
                    txt_cargo.Text = "👑 Developer";
                    txt_cargo.ForeColor = Color.Yellow;
                }
                else
                {
                    if (Properties.Settings.Default.user_group == "admin")
                    {
                        admin_button.Visible = false;
                        txt_cargo.Text = "🔑 Administrador";
                        txt_cargo.ForeColor = Color.Red;
                    }
                    else
                    {
                        admin_button.Visible = false;
                        txt_cargo.Text = Properties.Settings.Default.user_group;
                        txt_cargo.ForeColor = Color.White;
                    }
                }
            }


        }


        public void usr_getinfo()
        {
            MySqlConnection conn = new MySqlConnection(server_Data);
            Console.WriteLine("Conta SubForm | Definindo informações para conexão");
            string comando = "use cadastro; select * from registro where email=@email;";
            Console.WriteLine("Conta SubForm | Definindo informações");
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            Console.WriteLine("Conta SubForm | Definindo comandos");
            cmd.Parameters.AddWithValue("@email", Properties.Settings.Default.user_email);
            Console.WriteLine("Conta SubForm | Dados de login registrado");
            conn.Open();
            Console.WriteLine("Conta SubForm | Abrindo conexão mysql");
            MySqlDataReader leitor = cmd.ExecuteReader();
            Console.WriteLine("Conta SubForm | Lendo registros...");
            try
            {
                leitor.Read();
                var id = leitor.GetString(0);
                Console.WriteLine("Conta SubForm | Pegando ID");
                var usuario = leitor.GetString(1);
                Console.WriteLine("Conta SubForm | Pegando Nome de Usuario");
                txt_email.Text = Properties.Settings.Default.user_email;
                var foto = leitor.GetString(4);
                Console.WriteLine("Conta SubForm | Pegando Foto do Usuario");
                var cargo = leitor.GetString(5);
                Console.WriteLine("Conta SubForm | Pegando Cargo do Usuario");
                Console.WriteLine("Conta SubForm | Definindo Email em txt_email");
                txt_id.Text = ($"{id}");
                Console.WriteLine("Conta SubForm | Definindo ID em txt_id");
                txt_nome.Text = ($"{usuario}");
                Console.WriteLine("Conta SubForm | Definindo Nome de Usuario em txt_nome");
                WebRequest request = WebRequest.Create($"{foto}");
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        usr_foto.Image = Bitmap.FromStream(str);
                    }
                }

                Console.WriteLine("Conta SubForm | Definindo Foto do Usuario em usr_foto");
                Properties.Settings.Default.all_loaded = "1";
                Console.WriteLine("Conta SubForm | Definindo Cargo");

                Console.WriteLine("Conta SubForm | Guardando Informações...");
                Properties.Settings.Default.user_name = ($"{usuario}");
                Properties.Settings.Default.user_pfp = ($"{foto}");
                Properties.Settings.Default.user_group = ($"{cargo}");
                Properties.Settings.Default.user_id = ($"{id}");
                Console.WriteLine("Conta SubForm | Informações Salvas!");
                cargo_verify($"{cargo}");

                Console.WriteLine("Conta SubForm | Finalizado!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Conta SubForm  | Erro!");
                Console.WriteLine("Erro debug: " + ex.Message);
                //Mensagem de Erro
                Console.WriteLine("Conta SubForm | Enviando Logs para Usuario");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Depois de dar certo ou errado oq fazer; Exemplo=Fechar Conexão
                Console.WriteLine("Conta SubForm | Conexão MySql foi fechada com sucesso!");
                conn.Close();
            }
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            Form admin_panel = new admin_panel();
            admin_panel.ShowDialog();
        }
    }
}
