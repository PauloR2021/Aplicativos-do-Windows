using Agenda.Formulario;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Agenda
{
    
    public partial class Tela_Login : Form

    {
        Thread t1;
        
        MySqlConnection Conexao;

        public Tela_Login()
        {
            InitializeComponent();
        }

               

        private void login()
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=Pr_16112001;database=agenda";

                Conexao = new MySqlConnection(data_source);

                string nome = "'" + '%' + Txt_nome_login.Text + '%' + "'";
                string senha = "'" + '%' + Txt_senha_login.Text + '%' + "'";


                string sql_login = "SELECT * FROM login WHERE usuario LIKE" + nome + "AND senha LIKE" + senha;

                MySqlCommand comando = new MySqlCommand(sql_login, Conexao);



                Conexao.Open();

                MySqlDataReader dados = comando.ExecuteReader();

                string nome_usuario = Txt_nome_login.Text;
                string senha_usuario = Txt_senha_login.Text;

                
                if (nome_usuario== "" || senha_usuario == "")
                {
                    MessageBox.Show("Digite um Usuário e uma Senha !!");

                    Txt_nome_login.Clear();
                    Txt_senha_login.Clear();
                }
                else
                {
                    if (dados.Read())
                    {
                        Tela_Principal tela = new Tela_Principal();
                        tela.Show();
                        Conexao.Close();

                    }
                    else
                    {
                        MessageBox.Show("Dados Incorretos, Tente Novamente!");
                        Txt_nome_login.Clear();
                        Txt_senha_login.Clear();
                    }


                }




            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);

            }


        }


        private void Button_Login_Click(object sender, EventArgs e)
        { 

            login();

            this.Close();

            t1 = new Thread(tela_principal);

            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();



        }

        private void Txt_senha_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Botao_Criar_Cadastro_Click(object sender, EventArgs e)
        {

            this.Close();

            t1 = new Thread(novo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void novo()
        {

            Application.Run(new CadastroUsuario());
        }

        private void tela_principal()
        {
            Application.Run(new Tela_Principal());
        }

        
    }
}
