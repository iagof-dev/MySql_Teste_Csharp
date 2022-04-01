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
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.user_name = "N3rdyDzn";
                Properties.Settings.Default.user_pfp = "https://cdn.discordapp.com/attachments/889233196091342920/951232926186614804/euzin.png";
                Properties.Settings.Default.user_group = "dev";
                Properties.Settings.Default.user_id = "1";
                Properties.Settings.Default.user_email = "admin@n3rdydzn.xyz";
                Properties.Settings.Default.test_mode = "1";
                Properties.Settings.Default.all_loaded = "1";
                Properties.Settings.Default.Save();
                MessageBox.Show("Ativado!", "Modo Teste Ativado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine("Login Form | Modo Teste ativado! test_mode = 1");
                Form formis = new Logado();
                Inicio.ActiveForm.Hide();
                formis.ShowDialog();
            }
            else
            {
                Properties.Settings.Default.user_email = login_usuario.Text;
                Properties.Settings.Default.Save();
                LoginSystem(login_usuario.Text, login_senha.Text);
            }
        }
        private string LoginSystem(string usuario, string senha)
        {
            string retorno = "";
            Console.WriteLine("Login Form | Criando conexão");
            MySqlConnection conn = new MySqlConnection(server_Data);
            string comando = "use cadastro; SELECT * FROM registro WHERE email=@email AND senha=@senha; select * from registro where email=@email;";
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            cmd.Parameters.AddWithValue("@email", Properties.Settings.Default.user_email);
            cmd.Parameters.AddWithValue("@senha", senha);

            conn.Open();
            MySqlDataReader leitor = cmd.ExecuteReader();
            if (leitor.HasRows)
            {
                leitor.Read();


                conn.Close();

                

                Form formis = new Logado();
                Inicio.ActiveForm.Hide();
                formis.ShowDialog();

            }
            else
            {
                conn.Close();
                MessageBox.Show("Dados Incorretos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }

        private void login_Load(object sender, EventArgs e)
        {
            login_usuario.TabIndex = 0;
            login_senha.TabIndex = 1;
            button1.TabIndex = 2;
            Console.WriteLine("Login Form | Loaded!");
        }
        private void login_usuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (login_usuario.ForeColor == Color.Gray)
            { 
                login_usuario.ForeColor = Color.Black;
                login_usuario.Text = String.Empty;
            }
        }

        private void login_senha_MouseDown(object sender, MouseEventArgs e)
        {
            if (login_senha.ForeColor == Color.Gray)
            {
                login_senha.ForeColor = Color.Black;
                login_senha.Text = String.Empty;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult test_mode_ativar = MessageBox.Show("Ativando modo de teste você não poderá fazer nenhuma alteração", "Deseja ativar o modo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (test_mode_ativar == DialogResult.Yes)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
    }
}
