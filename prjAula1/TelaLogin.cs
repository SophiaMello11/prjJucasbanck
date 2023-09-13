using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Numerics;
using prjAula1.Classes;
using DTO;

namespace prjAula1
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var menu = new TelaCadastrar();
            //this.Hide();
            //menu.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnacessar_Click(object sender, EventArgs e)
        {
            try
            {
                //Criando uma conex�o
                SqlConnection conexao =
                new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.strConexao"].ToString());

                SqlDataReader leitor; //declarando uma vari�vel do tipo leitor de dados

                //Criando um comando
                SqlCommand cmd = new SqlCommand();

                //criando texto do comando, tipo e conex�o que ser� usada
                cmd.CommandText = "psValidaLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //passando par�metros necess�rios
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("cpf", txtcpf.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                conexao.Open(); //abrindo conex�o

                leitor = cmd.ExecuteReader();  //igualando o leitor ao resultado de BD

                if (leitor.HasRows) //se o leitor encontrar linhas de dados
                {
                    leitor.Read();
                    //leitor.GetInt32(0);    
                    UsuarioLogado.IdCliente = leitor.GetInt32(0);
                    UsuarioLogado.NomeCliente = leitor.GetString(1);
                    UsuarioLogado.DataNascimento = leitor.GetDateTime(5);
                    UsuarioLogado.Cidade = leitor.GetString(6);
                    UsuarioLogado.Estado = leitor.GetString(7);
                    UsuarioLogado.Cpf = leitor.GetString(2);
                    UsuarioLogado.Senha = leitor.GetString(4);
                    UsuarioLogado.Email = leitor.GetString(3);

                    //fechando leitor
                    leitor.Close();

                    //criando texto do comando, tipo e conex�o que ser� usada
                    cmd.CommandText = "ps_buscaContasPorIdCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //passando os par�metros necess�rios
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);


                    leitor = cmd.ExecuteReader();

                    //verificar se h� linhas retornadas do leitor
                    if (leitor.HasRows)
                    {
                        //repete a leitura e enquanto h� linhas segue na estrutura
                        //de repeti��o
                        while (leitor.Read())
                        {
                            //cria uma conta na mem�ria
                            Conta conta = new Conta();

                            //passa os dados do leitor para a conta na mem�ria - objeto conta
                            conta.IdConta = leitor.GetInt32(0);
                            conta.IdCliente = leitor.GetInt32(1);
                            conta.DataAbertura = leitor.GetDateTime(5);
                            conta.Saldo = leitor.GetDecimal(2);
                            conta.TipoConta = leitor.GetString(3);
                            conta.Status = leitor.GetString(4);
                            conta.SenhaConta = leitor.GetString(6);

                            //adiciona a conta rec�m criada na mem�ria para a colection de contas
                            UsuarioLogado.Contas.Add(conta);
                        }
                    }
                    leitor.Close(); //fecha leitor

                    conexao.Close(); //fecha conexao com BD

                    Form telaPrincipal = Application.OpenForms["TelaInicial"];
                    //acessando o formul�rio aberto atrav�s da vari�vel janelaPrincipal
                    MenuStrip menuPrincipal = (MenuStrip)telaPrincipal.Controls[0];
                    menuPrincipal.Items[0].Text = "Logout";
                    menuPrincipal.Items[1].Visible = false;
                    menuPrincipal.Items[2].Visible = true;


                    MessageBox.Show($"Ol�,{UsuarioLogado.NomeCliente}!\n" +
                        $"Voc� foi logado na conta {UsuarioLogado.Contas[0].IdCliente.ToString()}\n" +
                        $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");
                    //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +
                    //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +
                    //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Usuario ou senha invalidos");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}