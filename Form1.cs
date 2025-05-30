//Importa a biblioteca do MySql
using System.Data;
using System.Drawing.Text;
using System.Linq.Expressions;
using MySql.Data.MySqlClient;
namespace CRUD;


public partial class Form1 : Form
{
    //Variável que irá armazenar a conexão com o banco de dados
    MySqlConnection Conexao;

    //String de conexão com o banco de dados
    string connString = "datasource=localhost;username=root;password=;database=db_agenda";

    private void CarregarContatos()
    {
        try
        {
            //Cria uma conexão
            Conexao = new MySqlConnection(connString);

            //Cria a string SQL para selecionar todos os dados
            string sql = "SELECT * FROM contatos";

            //Cria o comando SQL
            MySqlCommand comando = new MySqlCommand(sql, Conexao);

            //Abre a conexão
            Conexao.Open();

            //Executa o comando
            MySqlDataReader reader = comando.ExecuteReader();

            //Limpa a lista
            lstContatos.Items.Clear();

            //Lê os dados retornados e adiciona ao listView
            while (reader.Read())
            {
                string[] row =
                {
                    reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[3].ToString()
                };

                //Cria um novo ListView com os dados lidos
                var linha_listview = new ListViewItem(row);

                //Adiciona o ListViewItem á lista
                lstContatos.Items.Add(linha_listview);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar contatos: " + ex.Message);
        }
        finally
        {
            //Fecha a conexão
            if (Conexao != null)
            {
                Conexao.Close();
            }
        }
    }
    public Form1()
    {
        InitializeComponent();
        lstContatos.View = View.Details;
        lstContatos.LabelEdit = true;
        lstContatos.AllowColumnReorder = true;
        lstContatos.FullRowSelect = true;
        lstContatos.GridLines = true;

        lstContatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
        lstContatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
        lstContatos.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
        lstContatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            //Cria uma conexão com o Mysql
            Conexao = new MySqlConnection(connString);

            //Abre a conexão
            Conexao.Open();

            //Cria o comando SQL
            MySqlCommand cmd = new MySqlCommand();

            //Define a conexão do comando
            cmd.Connection = Conexao;

            //Cria a string SQL para inserir os dados
            cmd.CommandText = "INSERT INTO Contatos (nome, email, telefone) " +
                                "Values " +
                                "(@nome, @email, @telefone)";

            //Adiciona os parâmetros
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

            //Adiciona o comando ao banco de dados
            cmd.Prepare();

            //Executa o comando 
            cmd.ExecuteNonQuery();

            MessageBox.Show("Contato salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpa os campos
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

            //Recarrega os contatos no ListView após salvar
            CarregarContatos();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Erro ao salvar o contato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            //Fecha a conexão
            if (Conexao != null)
            {
                Conexao.Close();
            }
        }

    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
        try
        {
            //Cria uma conexão com o Mysql
            Conexao = new MySqlConnection(connString);

            //Cria a string SQL para selecionar os dados
            Conexao.Open();

            //Cria o comando SQL
            MySqlCommand cmd = new MySqlCommand();

            //Define a conexão do comando
            cmd.Connection = Conexao;

            //Cria a string SQL para selecionar os dados
            cmd.CommandText = "SELECT * FROM contatos WHERE nome LIKE @query OR email LIKE @query";

            //Adiciona os parâmetros
            cmd.Parameters.AddWithValue("@query", "%" + txtLocalizar.Text + "%");

            //Adiciona o comando ao banco de dados
            MySqlDataReader reader = cmd.ExecuteReader();

            //Limpa a lista
            lstContatos.Items.Clear();

            //Lê os dados retornados e adiciona ao ListView
            while (reader.Read())
            {
                //Cria um array de strings com o número correto de colunas
                string[] row = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    //Garante que todos os valores sejam convertidos para string 
                    row[i] = reader.GetValue(i).ToString();
                }

                //Cria um novo ListViewItem com os dados lidos
                lstContatos.Items.Add(new ListViewItem(row));
            }
            //Fecha o reader após o uso
            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao consultar o registro no banco: " + ex.Message);
        }
        finally
        {
            //Fecha a conexão
            if (Conexao != null && Conexao.State == ConnectionState.Open)
            {
                Conexao.Close();
            }
        }
    }

}



