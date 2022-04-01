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
using System.IO;

namespace MySql_Teste_Csharp
{
    public partial class menu_conta : Form
    {
        string server_Data = "datasource=" + Properties.Settings.Default.mysql_ip + ";username=" + Properties.Settings.Default.mysql_user + ";password=" + Properties.Settings.Default.mysql_pass + ";database=" + Properties.Settings.Default.mysql_database;
        Image image;
        string path_image = string.Empty;

        public menu_conta()
        {
            InitializeComponent();
            Console.WriteLine("Conta SubForm | Loaded!");
        }

        private void Conta_Load(object sender, EventArgs e)
        {
            loaded_setinfo();
            usrpfp_load();
            cargo_verify();
        }
        public void loaded_setinfo()
        {
            cargo_verify();


            txt_id.Text = Properties.Settings.Default.user_id;
            txt_email.Text = Properties.Settings.Default.user_email;
            txt_nome.Text = Properties.Settings.Default.user_name;
            Console.WriteLine("Conta SubForm | Informações Carregadas foi setado aos $txt_email$, $txt_nome$, $usr_foto$!");
        }
        public void cargo_verify()
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
        private void admin_button_Click(object sender, EventArgs e)
        {
            Form admin_panel = new admin_panel();
            admin_panel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //preview
            OpenFileDialog pfp_dialogo = new OpenFileDialog();
            pfp_dialogo.Filter = "Image Files (*.PNG, *.JPG) | *.PNG; *.JPG" + "|All files(*.*)|*.*";
            pfp_dialogo.CheckFileExists = true;
            pfp_dialogo.Multiselect = false;
            if (pfp_dialogo.ShowDialog() == DialogResult.OK)
            {

                path_image = pfp_dialogo.FileName.ToString();

                image = new Bitmap(pfp_dialogo.FileName);
                usr_foto.Image = (Image)image;
                usr_savepfp.Visible = true;
                string usr_pfp_location = string.Empty;
                usr_pfp_location = pfp_dialogo.FileName.ToString();

            }
        }

        public void usrpfp_load()
        {
            MySqlConnection conn = new MySqlConnection(server_Data);
            //UPDATE registro SET cargo = 'usuario', senha = 'teste2' WHERE id = '2';
            string comando = "use cadastro; select * from registro where email=@email;";
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            cmd.Parameters.AddWithValue("@email", Properties.Settings.Default.user_email);

            conn.Open();
            MySqlDataReader leitor = cmd.ExecuteReader();
            if (leitor.Read())
            {
                    var sempfp = leitor.GetString(6);
                    if (sempfp == "1")
                    {
                        Console.WriteLine("Conta Sub Form | Usuário sem Foto");
                    }
                    else
                    { 
                        byte[] img = (byte[])(leitor["foto"]);
                        MemoryStream ms = new MemoryStream(img);
                        usr_foto.Image = Image.FromStream(ms);
                    }
            }
            else
            {
                usr_foto.Image = Properties.Resources.Portrait_Placeholder;
            }


            conn.Close();
        }
        public void usrpfp_save()
        {
            //enviar foto para banco de dados
            byte[] img = null;
            FileStream Stream = new FileStream(path_image,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            img = brs.ReadBytes((int)Stream.Length);


            MySqlConnection conn = new MySqlConnection(server_Data);
            //UPDATE registro SET cargo = 'usuario', senha = 'teste2' WHERE id = '2';
            string comando = "use cadastro; UPDATE registro SET foto = @pfp, sempfp = '0' where email=@email;";
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            cmd.Parameters.AddWithValue("@pfp", img);
            cmd.Parameters.AddWithValue("@email", Properties.Settings.Default.user_email);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            usr_savepfp.Visible = false;
            MessageBox.Show("Foto alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void usr_savepfp_Click(object sender, EventArgs e)
        {
            usrpfp_save();

        }
    }
}
