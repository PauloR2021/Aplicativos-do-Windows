using MySql.Data.MySqlClient;
using Agenda.Formulario;
using System.Threading;

namespace Agenda
{
    public partial class Tela_Principal : Form

    {
        Thread t1;

             

        MySqlConnection Conexao;//Criando uma Conexação com Banco de dados
        public Tela_Principal()
        {
            InitializeComponent();

            colunas();


        }

        private void colunas()
        {
            
            Tela_Buscar.View = View.Details;
            Tela_Buscar.LabelEdit = true;
            Tela_Buscar.AllowColumnReorder = true;
            Tela_Buscar.FullRowSelect = true;
            Tela_Buscar.GridLines = true;


            Tela_Buscar.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            Tela_Buscar.Columns.Add("Sobrenome", 100, HorizontalAlignment.Left);
            Tela_Buscar.Columns.Add("Apelido", 100, HorizontalAlignment.Left);
            Tela_Buscar.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            Tela_Buscar.Columns.Add("Telefone II", 100, HorizontalAlignment.Left);
            Tela_Buscar.Columns.Add("Email", 100, HorizontalAlignment.Left);
            Tela_Buscar.Columns.Add("Email", 100, HorizontalAlignment.Left);

        }

        private void conexao_banco() // Criando uma Função para Adicionar os dados no Banco
        {
            //Criando a Conexão com o MySql
            string data_source = "datasource=localhost;username=root;password=Pr_16112001;database=agenda";

            //Validando a Conexão com o MySql
            Conexao = new MySqlConnection(data_source);

            //Inserindo os dados ao Banco 
            string sql = "INSERT INTO pessoas (nome,sobrenome,apelido,telefone,telefoneII,email,email_II)" +
                "VALUES ('" + TXT_Nome.Text + "','" + TXT_Segundo_Nome.Text + "','" + TXT_Apelido.Text + "'," +
                "'" + Telefone.Text + "','" + Telefone_II.Text+ "','" + TXT_Email.Text + "','" + TXT_Email_II.Text + "')";

            //Criando o Comando para Inserir os dados ao Banco
            MySqlCommand comando = new MySqlCommand(sql, Conexao);

            //Abrindo o Banco de dados
            Conexao.Open();

            //Executando a Tarefa de Inserir os dados
            comando.ExecuteReader();

            //Menssagem para Avisar se deu Certo
            MessageBox.Show("Dados Encerridos com Sucesso");
        }


        private void buscar_dados() // Criando uma Função para Buscar dados do Banco
        {
            //Criando a Conexão com o MySql
            string data_source = "datasource=localhost;username=root;password=Pr_16112001;database=agenda";

            //Validando a Conexão com o MySql
            Conexao = new MySqlConnection(data_source);

            //Criando uma Várivael de Buscar 
            string busca = "'" + '%' + TXT_Busca.Text + '%' + "'";

            //Buscando dados 
            string sql = "SELECT * FROM pessoas WHERE nome LIKE" + busca + "OR sobrenome LIKE" + busca +
                        "OR apelido LIKE" + busca + "OR telefone LIKE" + busca + "OR telefoneII LIKE" + busca +
                         "OR email LIKE" + busca + "OR email_II LIKE" + busca;



            //Abrindo o Banco de dados
            Conexao.Open();

            //Criando o Comando para Inserir os dados ao Banco
            MySqlCommand comando = new MySqlCommand(sql, Conexao);
            
            //Criadando uma váriravel para pesquisar dentro do banco
            MySqlDataReader reader = comando.ExecuteReader();

            //Limpando a tela de busca
            Tela_Buscar.Items.Clear();

            
 
            //Criando um Loop para passar por todas as linhas do Banco de dados
            while (reader.Read())
            {

                string[] row =
                {
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6), 
                };

                //Criando uma variavel para salvar os dados recuperados do Banco
                var linha_listview = new ListViewItem(row);

                //Mostrando os dados do Banco
                Tela_Buscar.Items.Add(linha_listview);


            }



        }

        private void limpar_TXT() // Limpando os dados das TXT_Box
        {
            TXT_Nome.Clear();
            TXT_Segundo_Nome.Clear();
            TXT_Apelido.Clear();
            TXT_Telefone.Clear();
            TXT_Telefone_II.Clear();
            TXT_Email.Clear();
            TXT_Email_II.Clear();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conexao_banco();  //Chamando a Função do Banco 

                limpar_TXT(); //Chamando a Função para Limpar as TXT_Box

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Fechando a Conexão com o Banco de Dados
                Conexao.Close();
            }

        }

        private void TXT_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TXT_Segundo_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_Apelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TXT_Busca_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {                
                buscar_dados();  
                TXT_Busca.Clear();
            }
            catch (Exception ex)
            {

               
                MessageBox.Show(ex.Message);
                MessageBox.Show("Erro na busca");
            }
            finally
            {
                //Fechando a Conexão com o Banco de Dados
                Conexao.Close();
            }
        }

        private void Tela_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Botao_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();

            t1 = new Thread(voltar_menu);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void voltar_menu()
        {
            Application.Run(new Tela_Login());
        }
    }
}