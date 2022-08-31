using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Formulario;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Agenda.Formulario
{
    public partial class CadastroUsuario : Form
    {

        Thread t1;

        MySqlConnection Conexao;
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void cadastro_usuario()
        {
           
            string data_source = "datasource=localhost;username=root;password=Pr_16112001;database=agenda";

            
            Conexao = new MySqlConnection(data_source);

            string nome = Txt_nome.Text;
            string email = Txt_email.Text;
            string usuario = Txt_nome_usuario.Text;
            string senha = Txt_senha.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Por Favor! Preencha os Campos Nome para Usuário e Senha...");
            }
            else
            {
                string sql = "INSERT INTO login (nome,email,usuario,senha)" +
                "VALUES ('" + nome + "','" + email + "','" + usuario + "','" + senha + "')";


                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                Conexao.Open();




                comando.ExecuteReader();


                MessageBox.Show("Dados Encerridos com Sucesso");

            }

            

            

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Botao_cadastrar_Click(object sender, EventArgs e)
        {
            cadastro_usuario();
        }

        private void Botao_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();

            t1 = new Thread(voltar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }
        private void voltar()
        {
            Application.Run(new Tela_Login());
        }
    }
}
