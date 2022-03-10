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
    public partial class login : Form
    {
        string server_Data = "datasource=" + Properties.Settings.Default.mysql_ip + ";username=" + Properties.Settings.Default.mysql_user + ";password=" + Properties.Settings.Default.mysql_pass + ";database=" + Properties.Settings.Default.mysql_database;
        public login()
        {
            InitializeComponent();
            login_senha.PasswordChar = '*';
        }

        public void fechar()
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginSystem(login_usuario.Text, login_senha.Text);
        }
        private string LoginSystem(string usuario, string senha)
        {

            string retorno = "";
            ////instância da conexão
            Console.WriteLine("Login Form | Criando conexão");
            MySqlConnection conn = new MySqlConnection(server_Data);
            //comando sql que dá um count 
            //na tabela se existirem usuario e senha
            //com os dados informados
            string comando = "use cadastro; SELECT * FROM registro WHERE usuario=@usuario AND senha=@senha";
            Console.WriteLine("Login Form | Procurando registro");
            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            Console.WriteLine("Login Form | Registrando comando");
            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@usuario", usuario);
            Console.WriteLine("Login Form | Definindo info usuário");
            cmd.Parameters.AddWithValue("@senha", senha);
            Console.WriteLine("Login Form | Definindo info senha");
            //abro conexão
            conn.Open();
            Console.WriteLine("Login Form | Abrindo conexão com MySql");
            //instância do leitor
            MySqlDataReader leitor = cmd.ExecuteReader();
            Console.WriteLine("Login Form | Lendo registros");
            //se há linhas
            if (leitor.HasRows)
            {
                leitor.Read();
                Console.WriteLine("Login Form | Lendo Usuários");
                //string retorno recebe o nivel de acessos
                //do usuário
                Console.WriteLine("Login Form | Usuário Encontrado! enviando mensagem ao usuário de Sucesso");
                
                MessageBox.Show("Logado!");

                conn.Close();
                Console.WriteLine("Login Form | Conexão com MySql FECHADA!");

                Form formis = new Logado();
                Console.WriteLine("Login Form | Abrindo Logado.cs");
                this.Hide();
                this.Close();
                formis.ShowDialog();
                Console.WriteLine("Login Form | Fechando login.cs");
                



                //retorno = leitor["*"].ToString();

            }
            else
            {
                Console.WriteLine("Login Form | Erro Encontrado, UsPrbNONE");
                conn.Close();
                Console.WriteLine("Login Form | Conexão com MySql FECHADA!");
                MessageBox.Show("Erro!");
            }
            //fecho conexão
            
            //retorno o nível de acesso
            return retorno;
        }

        private void login_Load(object sender, EventArgs e)
        {
            login_usuario.TabIndex = 0;
            login_senha.TabIndex = 1;
            button1.TabIndex = 2;
            Console.WriteLine("Login Form | Loaded!");
        }
    }
}
