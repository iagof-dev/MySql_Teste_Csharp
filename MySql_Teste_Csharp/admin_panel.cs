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
    public partial class admin_panel : Form
    {
        string server_Data = "datasource=" + Properties.Settings.Default.mysql_ip + ";username=" + Properties.Settings.Default.mysql_user + ";password=" + Properties.Settings.Default.mysql_pass + ";database=" + Properties.Settings.Default.mysql_database;

        public admin_panel()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione o Cargo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usr_update(Convert.ToString(txt_id.Value));
            }
        }
        private string usr_update(string id)
        {
            string retorno = String.Empty;

            Console.WriteLine("Admin Panel Form | Criando conexão");
            MySqlConnection conn = new MySqlConnection(server_Data);
            string comando = "use cadastro; UPDATE registro SET cargo = '"+ comboBox1.GetItemText(comboBox1.SelectedItem) + "', email = '" + txt_email.Text + "' WHERE id = '" + txt_id.Value + "';";
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            Console.WriteLine("Admin Panel Form | Registrando comando");
            cmd.Parameters.AddWithValue("@id", id);
            Console.WriteLine("Admin Panel Form | Definindo info ID");
            conn.Open();
            Console.WriteLine("Admin Panel Form | Abrindo conexão com MySql");
            MySqlDataReader leitor = cmd.ExecuteReader();
            Console.WriteLine("Admin Panel Form | Sucesso!");
            Console.WriteLine("Admin Panel Form | Conexão MySql fechada!");
            conn.Close();
            MessageBox.Show("Alterações Feita!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return retorno;
        }
    }
}
