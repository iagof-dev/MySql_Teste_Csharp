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
    public partial class registrar : Form
    {
        //dados servidor
        string server_Data = "datasource=" + Properties.Settings.Default.mysql_ip + ";username=" + Properties.Settings.Default.mysql_user + ";password=" + Properties.Settings.Default.mysql_pass + ";database=" + Properties.Settings.Default.mysql_database;

        MySqlConnection conexao;
        public registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (registro_email.Text.Contains("@") == true)
            {
                Console.WriteLine("Registro Form | Email contem @");
                user_register();
            }
            else
            {
                MessageBox.Show("Preencha corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrar_Load(object sender, EventArgs e)
        {
            registro_user.TabIndex = 0;
            registro_email.TabIndex = 1;
            registro_senha.TabIndex = 2;
            button1.TabIndex = 3;
            Console.WriteLine("Registro Form | loaded");
        }

        public void user_register()
        {
            try
            {
                //conectar ao server
                conexao = new MySqlConnection(server_Data);
                Console.WriteLine("Registro Form | Criando Conexão com MYSQL/Server");

                //dados á ser enviado pro banco
                string sql = "insert into registro values (DEFAULT, '" + registro_user.Text + "', '" + registro_email.Text + "', '" + registro_senha.Text + "', NULL, DEFAULT, DEFAULT);";
                Console.WriteLine("Registro Form | Registrando Dados para enviar, Debug: U=" + registro_user.Text + "E=" + registro_email.Text + "P=" + registro_senha.Text);

                string path_image = string.Empty;
                path_image = Properties.Resources.Portrait_Placeholder.ToString();
                




                //enviar dados usando comando

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                Console.WriteLine("Registro Form | Enviando Comando com Dados");

                //abrir conexão com MySql
                conexao.Open();
                Console.WriteLine("Registro Form | Abrindo Conexão com MySql");
                Console.WriteLine("Registro Form | Conexão Bem Sucedida ao MySql");
                Console.WriteLine("Registro Form | Verificando se foi registrado");
                comando.ExecuteReader();
                //Resultado após comando bem sucedido
                MessageBox.Show("Usuário Registrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine("Registro Form | Usuario Registrado!");
                Console.WriteLine("Registro Form | Escondendo Form");
                Console.WriteLine("Registro Form | Fechando Form");
                registro_user.Text = string.Empty;
                registro_senha.Text = string.Empty;
                registro_email.Text = string.Empty;

            }
            catch (Exception ex)
            {
                Console.WriteLine("!Registro Form | Erro!");
                Console.WriteLine("Erro debug: " + ex.Message);
                //Mensagem de Erro
                Console.WriteLine("Registro Form | Enviando Logs para Usuario");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Depois de dar certo ou errado oq fazer; Exemplo=Fechar Conexão
                Console.WriteLine("Registro Form | Conexão MySql fechada!");
                conexao.Close();
            }
        }

        private void registro_user_MouseDown(object sender, MouseEventArgs e)
        {
            if (registro_user.ForeColor == Color.Gray)
            {
                registro_user.ForeColor = Color.Black;
                registro_user.Text = String.Empty;
            }
        }

        private void registro_email_MouseDown(object sender, MouseEventArgs e)
        {
            if (registro_email.ForeColor == Color.Gray)
            {
                registro_email.ForeColor = Color.Black;
                registro_email.Text = String.Empty;
            }
        }

        private void registro_senha_MouseDown(object sender, MouseEventArgs e)
        {
            if (registro_senha.ForeColor == Color.Gray)
            {
                registro_senha.ForeColor = Color.Black;
                registro_senha.Text = String.Empty;
            }
        }
    }
}
