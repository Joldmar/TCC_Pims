using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OPCDA.NET;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TesteOPC
{
    public partial class Form1 : Form
    {
        string shortcut = "[TCC__]";
        bool lerTag = false;
        string servidorOpc = "";
        List<String> tags = new List<string>();
        string[] itensValor;
        int tempoScan;
        SqlConnection conexao;



        OpcServer srv = new OpcServer();
        OpcGroup oGrp = null;
        OPCItemDef[] items = null;
        OPCItemResult[] addRslt = null;
        int[] err = null;
        object[] val = null;
        OPCItemState[] rslt = null;
        int[] iHnd = null;

        int rtc;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iloggerDataSet1.tblUsuarios' table. You can move, or remove it, as needed.
            //this.iloggerDataSet1.tblUsuarios.DefaultView.RowFilter = "status = 1";

            this.tblUsuariosTableAdapter1.Fill(this.iloggerDataSet1.tblUsuarios);


            // TODO: This line of code loads data into the 'iloggerDataSetUsuarios.tblUsuarios' table. You can move, or remove it, as needed.
            //this.iloggerDataSetUsuarios.Tables[0].Select("SELECT id, nome, login, senha, data_criacao,  cargo, status FROM [Ilogger].[dbo].[tblUsuarios] WHERE status = 1");
            // this.tblUsuariosTableAdapter.Fill(this.iloggerDataSetUsuarios.tblUsuarios);
            // TODO: This line of code loads data into the 'iloggerDataSet.tblCargos' table. You can move, or remove it, as needed.
            this.tblCargosTableAdapter.Fill(this.iloggerDataSet.tblCargos);
            tb_tempoScan.Text = "1000";
            Int32.TryParse(tb_tempoScan.Text, out tempoScan);
            cb_Servidores.SelectedIndex = 0;
            cb_Cargo.SelectedIndex = 0;
            tb_servidor_sql.SelectedIndex = 0;

            // setInvisible();

        }
        /*
        private void setInvisible()
        {
            for (int i = 1; i < dG_Usuarios.RowCount - 1; i++)
            {

                
                //int b = (int)dG_Usuarios.Rows[i].Cells[5].Value;

                try
                {
                    dG_Usuarios.Rows[i].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show(" erro");
                    throw;
                }
           
                    int index = dG_Usuarios.Rows[i].Index;
                    MessageBox.Show("valor do indice: " + index);

                

                MessageBox.Show("valor do i: " + i);

            }


        }
        */
        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            //Cadastra os subcampos da lista na tela com as variáveis do array de resultados
            itensValor = new string[tags.Count];
            for (int i = 0; i < tags.Count; i++)
            {
                itensValor[i] = i.ToString();
                lv_tagList.Items[i].SubItems.Add(itensValor[i]);
            }

            lerTag = true;

            if (servidorOpc == "")
            {
                MessageBox.Show("Nenhum servidor OPC cadastrado");
                return;
            }
            float deadBand = 0.0F;

            try
            {
                //Adicionar um grupo (pasta em que o tag será lido):
                oGrp = srv.AddGroup("Grp1", true, 500, ref deadBand, 0, 0);
            }
            catch
            {
                MessageBox.Show("Erro ao tentar adicionar grupo OPC.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Configurar item para leitura (array)
            items = new OPCItemDef[tags.Count];
            //string tagsArray[55] = tags.ToArray;
            for (int i = 0; i < tags.Count; i++)
            {
                items[i] = new OPCItemDef(tags[i], true, 0, System.Runtime.InteropServices.VarEnum.VT_BSTR);
            }
            addRslt = new OPCItemResult[tags.Count];
            //Adicionar este(s) ite(ns) ao grupo criado anteriormente:
            rtc = oGrp.AddItems(items, out addRslt);
            if (rtc != 0)
            {
                //Se desse erro, o valor de RTC será diferente de 0, aqui dentro poderia ter algum tratamento
            }



            iHnd = new Int32[tags.Count];

            for (int i = 0; i < tags.Count; i++)
            {
                iHnd[i] = addRslt[i].HandleServer;
            }

            //Esse aqui é o evento em paralelo a execução do botão, que faz a leitura contínua do tag:]
            //O seu código está no método logo abaixo, chamado bwLer_DoWork
            if (bwLer.IsBusy == false)
            {
                bwLer.RunWorkerAsync();
            }
        }

        private void bwLer_DoWork(object sender, DoWorkEventArgs e)
        {


            //Esse loop fica em verdadeiro (rodando sempre) quando clico no botão de leitura:
            while (lerTag)
            {
                //Esse método abaixo faz a leitura OPC de todos os tags que eu tiver cadastrado
                rtc = oGrp.Read(OPCDA.OPCDATASOURCE.OPC_DS_CACHE, iHnd, out rslt);


                for (int i = 0; i < tags.Count; i++)
                {
                    //Isso aqui é só um tratamento para ver se não veio dado vazio, se vier, escrever erro na tela:
                    if (rslt[i].DataValue == null)
                    {
                        //Condição de erro de leitura
                        this.Invoke(new MethodInvoker(delegate
                        {

                        }));
                    }
                    else
                    {
                        //Se estiver OK o valor, escreve seu valor lido na tela:
                        this.Invoke(new MethodInvoker(delegate
                        {
                            lv_tagList.Items[i].SubItems[1].Text = rslt[i].DataValue.ToString();
                            itensValor[i] = rslt[i].DataValue.ToString();

                            string nomeTabela = "tbValor_" + tags[i].Substring(shortcut.Length);

                            insertDb(nomeTabela, rslt[i].DataValue.ToString());

                        }));

                    }
                }
                System.Threading.Thread.Sleep(tempoScan);
            }
            //Esse método abaixo faz a desconexão com o OPC Server.
            srv.Disconnect();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //Quando clica para parar de ler, joga o boleano que faz rodar o código contínuo para zero, parando o loop infinito:
            lerTag = false;
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lbTagLeitura_Click(object sender, EventArgs e)
        {

        }
        private void lbServidor_Click(object sender, EventArgs e)
        {

        }

        private void lbServidor_Click_1(object sender, EventArgs e)
        {

        }

        private void tbServidor_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            servidorOpc = cb_Servidores.Text;
            try
            {
                //Tenta conectar no servidor cadastrado
                rtc = srv.Connect("Localhost", servidorOpc);
                MessageBox.Show("Servidor " + servidorOpc + " cadastrado com sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbServidor.Text = servidorOpc;
            }
            catch
            {
                //Se der erro, envio mensagem na tela:
                MessageBox.Show("Erro ao tentar conexão OPC.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtc = 12;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (criarTabelaValor(tb_tag.Text))
            //{
            //adiciona o tag na view list e na lista de tags
            criarTabelaValor(tb_tag.Text);
            lv_tagList.Items.Add(new ListViewItem(tb_tag.Text));
            tags.Add(shortcut + tb_tag.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Erro ao criar tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbValorLe_Click(object sender, EventArgs e)
        {

        }

        private void lbValorLe2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_servidor_sql_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //==============================================================================================
        // Persistência (banco de dados)

        private int int_criar_tblUsuario = 0;
        private int int_criar_tblServidores = 0;
        private int int_criar_tblItens = 0;


        private bool insertDb(string nomeTabela, string valor)
        {
            try
            {
                string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                SqlConnection con2 = new SqlConnection(connectionString2);
                SqlCommand cmd2 = new SqlCommand("INSERT INTO [Ilogger].[dbo].[" + nomeTabela + "] (valor) VALUES (" + valor + ");", con2);
                SqlDataReader myReader2;
                con2.Open();
                myReader2 = cmd2.ExecuteReader();
                con2.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        //====================================================================================================================================================================
        private void btn_testar_conexao_Click(object sender, EventArgs e)// cria conexão com o banco de dados
        {
            criar_conexao();
            /*
            string connectionString = @"Data Source=" + tb_servidor_sql.Text + ";" +
          "User ID=" + tb_usuario_sql.Text + ";" +
          "Password=" + tb_senha_sql.Text;

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                lb_serverStatus.Text = "Conexão Realizada com Sucesso!";
                lb_serverStatus.ForeColor = Color.Green;
                con.Close();
            }
            catch (Exception)
            {
                lb_serverStatus.Text = "Falhou Conexão";
                lb_serverStatus.ForeColor = Color.Red;
            }
            */
        }
        //====================================================================================================================================================================
        private void criar_conexao()// Método para criar conexão com o banco de dados
        {
            string connectionString = @"Data Source=" + tb_servidor_sql.Text + ";" +
          "User ID=" + tb_usuario_sql.Text + ";" +
          "Password=" + tb_senha_sql.Text;

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                lb_serverStatus.Text = "Conexão Realizada com Sucesso!";
                lb_serverStatus.ForeColor = Color.Green;
                con.Close();
                conexao = con;
            }
            catch (Exception)
            {
                lb_serverStatus.Text = "Falhou Conexão";
                lb_serverStatus.ForeColor = Color.Red;
                conexao = null;
            }
        }
        //====================================================================================================================================================================
        private bool abrir_conexao()// Método para abrir a conexão com o banco de dados
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Open();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show(" Não foi possível abrir a conexão!");
                    return false;
                }
            }
            else
            {
                return false;
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //====================================================================================================================================================================
        private void button6_Click(object sender, EventArgs e) //Cria o banco de dados
        {
            string connectionString = @"Data Source=" + tb_servidor_sql.Text + ";User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
            SqlConnection con1 = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand("create database Ilogger;", con1);

            SqlDataReader myReader;
            try
            {
                con1.Open();
                myReader = cmd1.ExecuteReader();
                con1.Close();
                MessageBox.Show("O banco de dados Ilogger foi criado com sucesso!");
                lb_nomeDoBanco.Text = "Ilogger";


                try // Criando a Tabela  Usuários
                {
                    string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                    SqlConnection con2 = new SqlConnection(connectionString2);
                    SqlCommand cmd2 = new SqlCommand("CREATE TABLE [dbo].[tblUsuarios]([id] [int] identity (1,1), [nome] [varchar](45) NOT NULL, [login] [varchar](50) NOT NULL, [senha] [varchar](25) NOT NULL, [data_criacao] [date] NOT NULL, [cargo] [INT] NOT NULL, [status] [INT], CONSTRAINT [PK_tblUsuarios] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY]; SET ANSI_PADDING OFF; ALTER TABLE [dbo].[tblUsuarios] ADD  CONSTRAINT [DF_tblUsuarios_data_criacao]  DEFAULT (getdate()) FOR [data_criacao]; ", con2);

                    SqlDataReader myReader2;

                    con2.Open();
                    myReader2 = cmd2.ExecuteReader();
                    con2.Close();
                    int_criar_tblUsuario = 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("A tabela Usuários não foi criada.");
                } // Fim da criação da Tabela Usuários

                try // Criando a Tabela  de Cargos
                {
                    string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                    SqlConnection con2 = new SqlConnection(connectionString2);
                    SqlCommand cmd2 = new SqlCommand("CREATE TABLE [dbo].[tblCargos]([id] [int] identity (1,1), [nome] [varchar](45) NOT NULL, [nivel] [INT] NOT NULL, CONSTRAINT [PK_tblCargos] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY]; ", con2);

                    SqlDataReader myReader2;

                    con2.Open();
                    myReader2 = cmd2.ExecuteReader();
                    con2.Close();
                    int_criar_tblUsuario = 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("A tabela Cargos não foi criada.");
                } // Fim da criação da Tabela Cargos


                try // Criando a Tabela Servidores
                {
                    string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                    SqlConnection con2 = new SqlConnection(connectionString2);
                    SqlCommand cmd2 = new SqlCommand("CREATE TABLE [dbo].[tblServidores]([nome_servidor] [varchar](100) NOT NULL, [status_conexao] [int] NULL, CONSTRAINT [PK_tblServidores] PRIMARY KEY CLUSTERED ([nome_servidor] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]", con2);
                    SqlDataReader myReader2;

                    con2.Open();
                    myReader2 = cmd2.ExecuteReader();
                    con2.Close();
                    int_criar_tblUsuario = 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("A tabela Servidores não foi criada.");
                } // Fim da criação da Tabela Servidores


                try // Criando a Tabela TAGs
                {
                    string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                    SqlConnection con2 = new SqlConnection(connectionString2);
                    SqlCommand cmd2 = new SqlCommand("CREATE TABLE [dbo].[tblTag]([id] [int] IDENTITY(1,1) NOT NULL, [grupo] [varchar](45) NOT NULL,[tag] [varchar](45) NOT NULL, [servidor] [varchar](45) NOT NULL, CONSTRAINT [PK_tblTag] PRIMARY KEY CLUSTERED ([id] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]", con2);
                    SqlDataReader myReader2;

                    con2.Open();
                    myReader2 = cmd2.ExecuteReader();
                    con2.Close();
                    int_criar_tblUsuario = 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("A tabela Tag não foi criada.");
                } // Fim da criação da Tabela Tags

            
             try // Criando a Tabela Tag_valor
            {
                string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                SqlConnection con2 = new SqlConnection(connectionString2);
                SqlCommand cmd2 = new SqlCommand("CREATE TABLE [dbo].[tblTag_valor]([id] [int] IDENTITY(1,1) NOT NULL, [tag] [int] NOT NULL, [valor] [varchar](20) NOT NULL, [dataAtu] [date] NOT NULL, CONSTRAINT [PK_tblTag_valor] PRIMARY KEY CLUSTERED ([id] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]", con2);
                SqlDataReader myReader2;

                con2.Open();
                myReader2 = cmd2.ExecuteReader();
                con2.Close();
                //int_criar_tblUsuario = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("A tabela Tag_valor não foi criada.");
            } // Fim da criação da Tabela Tag_valor

        }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível criar o banco de dados.");
            }

            criarTabelasDinamicas();
            //MessageBox.Show("Foram criadas as tabelas: " + verificaTabelas());
        }

        //====================================================================================================================================================================
        private void criarTabelasDinamicas()//criando as tabelas dinamicamente de acordo com as variáveis previamente cadastradas
        {
            foreach (string tag in tags)
            {
                criarTabelaValor(tag.Substring(shortcut.Length));
            }
        }


        private bool criarTabelaValor(string nomeTabela)
        {

            try
            {

                string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                SqlConnection con2 = new SqlConnection(connectionString2);

                // SqlCommand cmd = conexao.CreateCommand();
                SqlCommand cmd2 = new SqlCommand("CREATE TABLE [dbo].[tbValor_" + nomeTabela + "]([data_time] [datetime] NOT NULL,[valor] [varchar](20) NOT NULL) ON [PRIMARY]; ALTER TABLE [dbo].[tbValor_" + nomeTabela + "] ADD  CONSTRAINT [tbValor_" + nomeTabela + "_data_time]  DEFAULT (getdate()) FOR [data_time];", con2);
                SqlDataReader myReader2;
                con2.Open();
                myReader2 = cmd2.ExecuteReader();
                con2.Close();

                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível criar a tabela: " + nomeTabela);
                return false;
                throw;
            }

        }

        private string verificaTabelas()
        {
            try
            {

                string connectionString2 = @"Data Source=" + tb_servidor_sql.Text + ";Initial Catalog=Ilogger;User ID=" + tb_usuario_sql.Text + ";Password=" + tb_senha_sql.Text;
                SqlConnection con2 = new SqlConnection(connectionString2);
                SqlCommand cmd2 = new SqlCommand("use Ilogger;select TABLE_NAME from INFORMATION_SCHEMA.TABLES", con2);
                SqlDataReader myReader2;
                con2.Open();
                myReader2 = cmd2.ExecuteReader();
                con2.Close();
                return myReader2.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao verificar tabelas");
                return null;
                throw;
            }
        }

        //=====================================================================================================================================================================
        private void add_usuario()//Adiciona Usuarios ao sistema 
        {
            if (!abrir_conexao())
            {
                return;

            }

            string loginUsuario = Regex.Replace(tb_add_usuario.Text, @"\s+", "");

            if (loginUsuario != "")
            {

                if (tb_senha_usuario.Text.Length >= 6)
                {
                    if (cb_Cargo.SelectedIndex != 0)
                    {

                        try
                        {
                            SqlCommand cmd = conexao.CreateCommand();
                            string teste = "INSERT INTO[Ilogger].[dbo].[tblUsuarios]([nome],[login],[senha],[cargo],[status])VALUES('" + tb_nome_usuario.Text + "','" + loginUsuario + "','" + tb_senha_usuario.Text + "','" + cb_Cargo.Text + "',1)";
                            cmd.CommandText = teste;

                            try
                            {
                                cmd.ExecuteNonQuery();
                                lb_addUser.Text = "Usuário Adicionado!";
                                MessageBox.Show("Usuário adicionado com sucesso!");
                            }
                            catch (Exception)
                            {
                                lb_addUser.Text = "Não foi possível adicionar o usuário.";
                                MessageBox.Show("Esse Login JÁ EXISTE. Tente outro login!");
                            }
                        }
                        catch (Exception)
                        {
                            lb_addUser.Text = "Deu errado.";
                            MessageBox.Show("Erro SQL ao tentar adicionar o usuário.");
                        }

                        tb_nome_usuario.Text = "";
                        tb_add_usuario.Text = "";
                        tb_senha_usuario.Text = "";
                        cb_Cargo.SelectedIndex = 0;
                        conexao.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não é possível adicionar um usuário sem CARGO válido. Preencha esse campo!");
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível adicionar um usuário sem SENHA válida. Preencha esse campo com no minímo 6 caracteres!");
                }
            }
            else
            {
                MessageBox.Show("Não é possível adicionar um usuário sem LOGIN válido. Preencha esse campo!");
            }

        }

        //=====================================================================================================================================================================
        private void add_cargo()//Adiciona Cargos ao sistema 
        {
            if (!abrir_conexao())
            {
                return;

            }

            string cargo = Regex.Replace(tb_cad_cargo.Text, @"\s+", "");

            if (tb_cad_nivel.Text != "")
            {

                if (tb_cad_cargo.Text.Length >= 3)
                {
                    {

                        try
                        {

                            SqlCommand cmd = conexao.CreateCommand();
                            cmd.CommandText = "INSERT INTO[Ilogger].[dbo].[tblCargos]([nome],[nivel])VALUES('" + cargo + "'," + tb_cad_nivel.Text + ")";

                            try
                            {
                                cmd.ExecuteNonQuery();
                                lb_addUser.Text = "Cargo Adicionado!";
                                MessageBox.Show("Cargo adicionado com sucesso!");


                            }
                            catch (Exception)
                            {
                                lb_addUser.Text = "Não foi possível adicionar o cargo.";
                                MessageBox.Show("Esse cargo JÁ EXISTE. Tente outro!");
                            }
                        }
                        catch (Exception)
                        {
                            lb_addUser.Text = "Deu errado.";
                            MessageBox.Show("Erro SQL ao tentar adicionar o cargo.");
                        }

                        tb_cad_nivel.Text = "";
                        tb_cad_cargo.Text = "";

                    }

                }
                else
                {
                    MessageBox.Show("Não é possível adicionar um cargo. Preencha esse campo com no minímo 3 caracteres!");

                }
            }
            else
            {
                MessageBox.Show("Não é possível adicionar um cargo sem definir seu nível. Este campo deve ser preenchido com valores de 1 a 5, sendo 5 maior nível hierárquico!");
            }
            conexao.Close();
        }
        //=====================================================================================================================================
        private void deletarCargo(string id)// Exclui cargo da lista de cargos
        {
            if (!abrir_conexao())
            {
                return;

            }

            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = "DELETE FROM[Ilogger].[dbo].[tblCargos] WHERE id = " + id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cargo deletado com sucesso!");


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível deletar o cargo");
            }
            conexao.Close();
        }
        //=====================================================================================================================================
        private void atualizaDataGridCargo()// atualiza a lista de cargos
        {
            if (!abrir_conexao())
            {
                MessageBox.Show("Erro ao abrir conexão com o banco de dados");
                return;
            }
            string strSQL = "SELECT id, nome, nivel FROM [Ilogger].[dbo].[tblCargos]";
            SqlCommand objcommand = new SqlCommand(strSQL, conexao);

            try
            {

                SqlDataAdapter objAdp = new SqlDataAdapter(objcommand);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dgCargo.DataSource = dtLista;

            }
            catch (Exception)
            {
                MessageBox.Show("erro");
            }
            conexao.Close();
        }
        //=====================================================================================================================================
        private void deletarUsuario(string id)// Excluir usuário do banco de dados
        {
            if (!abrir_conexao())
            {
                return;

            }

            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = "UPDATE [Ilogger].[dbo].[tblUsuarios]SET [status] = 0 WHERE id =" + id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário deletado com sucesso!");


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível deletar o usuário");
            }
            conexao.Close();
        }
        //================================================================================================================================================================
        private void atualizaDataGridUsuario()// Atualiza a lista de usuários
        {
            if (!abrir_conexao())
            {
                MessageBox.Show("Erro ao abrir conexão com o banco de dados");
                return;
            }
            string strSQL = "SELECT id, nome, login, senha, data_criacao,  cargo, status FROM [Ilogger].[dbo].[tblUsuarios] WHERE status = 1";
            SqlCommand objcommand = new SqlCommand(strSQL, conexao);

            try
            {

                SqlDataAdapter objAdp = new SqlDataAdapter(objcommand);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dG_Usuarios.DataSource = dtLista;

            }
            catch (Exception)
            {
                MessageBox.Show("erro");
            }
            conexao.Close();
        }
        //================================================================================================================================================================
        private void alterasenha(string id)// Redefinir senha do usuário
        {
            if (!abrir_conexao())
            {
                return;

            }

            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = "UPDATE [Ilogger].[dbo].[tblUsuarios] SET[senha] =('" + tb_nova_senha_usuario.Text + "')  WHERE id =" + id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Senha alterada com sucesso!");


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível alterar senha do usuário");
            }
            conexao.Close();
        }
        //=====================================================================================================================================


        private void label9_Click(object sender, EventArgs e)
        {


        }

        private void tb_tempoScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Int32.TryParse(tb_tempoScan.Text, out tempoScan);
        }

        private void tb_tempoScan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_tag_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_usuario_Click_1(object sender, EventArgs e)
        {
            add_usuario();
        }

        private void tb_add_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_senha_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cad_cargo_Click(object sender, EventArgs e)
        {
            add_cargo();
            atualizaDataGridCargo();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblCargosTableAdapter.FillBy(this.iloggerDataSet.tblCargos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgCargo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        //====================================================================================================================================================================
        private void button7_Click(object sender, EventArgs e)//Criado apenas para a fase de testes. Para conectar mais rápido ao banco
        {
            tb_servidor_sql.SelectedIndex = 1;
            tb_usuario_sql.Text = "sa";
            tb_senha_sql.Text = "PlantPAx4";
            criar_conexao();
        }
        //====================================================================================================================================================================
        private void btn_excluir_cargo_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dgCargo.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgCargo.Rows[selectedrowindex];

            string id = Convert.ToString(selectedRow.Cells[0].Value);


            deletarCargo(id);
            atualizaDataGridCargo();
        }

        private void btn_excluir_usuario_Click(object sender, EventArgs e)
        {

            int selectedrowindex = dG_Usuarios.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dG_Usuarios.Rows[selectedrowindex];

            string id = Convert.ToString(selectedRow.Cells[0].Value);


            deletarUsuario(id);
            atualizaDataGridUsuario();
        }

        private void btn_altera_senha_Click_1(object sender, EventArgs e)
        {
            int selectedrowindex = dG_Usuarios.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dG_Usuarios.Rows[selectedrowindex];

            string id = Convert.ToString(selectedRow.Cells[0].Value);


            alterasenha(id);

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tblUsuariosTableAdapter.FillBy(this.iloggerDataSetUsuarios.tblUsuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.tblUsuariosTableAdapter1.FillBy(this.iloggerDataSet1.tblUsuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dG_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            //setInvisible();
        }


    }
}






