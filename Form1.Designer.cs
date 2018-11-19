namespace TesteOPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bwLer = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Servidores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbServidor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lv_tagList = new System.Windows.Forms.ListView();
            this.ch_tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tempoScan = new System.Windows.Forms.NumericUpDown();
            this.btn_setTempoScan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.lb_nomeDoBanco = new System.Windows.Forms.Label();
            this.btn_criarBanco = new System.Windows.Forms.Button();
            this.lb_serverStatus = new System.Windows.Forms.Label();
            this.tb_senha_sql = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_usuario_sql = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_testar_conexao = new System.Windows.Forms.Button();
            this.tb_servidor_sql = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_nome_usuario = new System.Windows.Forms.TextBox();
            this.lb_addUser = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.tblCargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iloggerDataSet = new TesteOPC.IloggerDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_senha_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_usuario = new System.Windows.Forms.Button();
            this.tb_add_usuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgCargo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_excluir_cargo = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_cad_cargo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_cad_cargo = new System.Windows.Forms.Button();
            this.tb_cad_nivel = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lb_altera_Senha = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_nova_senha_usuario = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_altera_senha = new System.Windows.Forms.Button();
            this.btn_excluir_usuario = new System.Windows.Forms.Button();
            this.dG_Usuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iloggerDataSet1 = new TesteOPC.IloggerDataSet1();
            this.tblUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iloggerDataSetUsuarios = new TesteOPC.IloggerDataSetUsuarios();
            this.tblCargosTableAdapter = new TesteOPC.IloggerDataSetTableAdapters.tblCargosTableAdapter();
            this.tblUsuariosTableAdapter = new TesteOPC.IloggerDataSetUsuariosTableAdapters.tblUsuariosTableAdapter();
            this.tblUsuariosTableAdapter1 = new TesteOPC.IloggerDataSet1TableAdapters.tblUsuariosTableAdapter();
            this.tblCargosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tempoScan)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCargosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloggerDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargo)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloggerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloggerDataSetUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCargosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "Parar Leitura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ler Valor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bwLer
            // 
            this.bwLer.WorkerReportsProgress = true;
            this.bwLer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLer_DoWork);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_Servidores);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbServidor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 105);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servidor OPC";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cb_Servidores
            // 
            this.cb_Servidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Servidores.FormattingEnabled = true;
            this.cb_Servidores.Items.AddRange(new object[] {
            "Selecione",
            "RSlinx OPC Server"});
            this.cb_Servidores.Location = new System.Drawing.Point(70, 44);
            this.cb_Servidores.Name = "cb_Servidores";
            this.cb_Servidores.Size = new System.Drawing.Size(156, 21);
            this.cb_Servidores.TabIndex = 8;
            this.cb_Servidores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Servidor:";
            // 
            // lbServidor
            // 
            this.lbServidor.AutoSize = true;
            this.lbServidor.Location = new System.Drawing.Point(67, 15);
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.Size = new System.Drawing.Size(0, 13);
            this.lbServidor.TabIndex = 4;
            this.lbServidor.Click += new System.EventHandler(this.lbServidor_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Servidor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar Servidor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lv_tagList
            // 
            this.lv_tagList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_tag,
            this.ch_valor});
            this.lv_tagList.Location = new System.Drawing.Point(162, 19);
            this.lv_tagList.Name = "lv_tagList";
            this.lv_tagList.Size = new System.Drawing.Size(262, 166);
            this.lv_tagList.TabIndex = 7;
            this.lv_tagList.UseCompatibleStateImageBehavior = false;
            this.lv_tagList.View = System.Windows.Forms.View.Details;
            this.lv_tagList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ch_tag
            // 
            this.ch_tag.Text = "Tag";
            this.ch_tag.Width = 99;
            // 
            // ch_valor
            // 
            this.ch_valor.Text = "Valor";
            this.ch_valor.Width = 86;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.tb_tag);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lv_tagList);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(3, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 200);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tags de Leitura";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tag:";
            // 
            // tb_tag
            // 
            this.tb_tag.Location = new System.Drawing.Point(6, 40);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.Size = new System.Drawing.Size(150, 20);
            this.tb_tag.TabIndex = 5;
            this.tb_tag.TextChanged += new System.EventHandler(this.tb_tag_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 26);
            this.button5.TabIndex = 8;
            this.button5.Text = "Remover";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 26);
            this.button4.TabIndex = 0;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(11, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 359);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conf.OPC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tempoScan);
            this.groupBox1.Controls.Add(this.btn_setTempoScan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(250, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempo de atualização Servidor OPC";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_tempoScan
            // 
            this.tb_tempoScan.Location = new System.Drawing.Point(15, 44);
            this.tb_tempoScan.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tb_tempoScan.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tb_tempoScan.Name = "tb_tempoScan";
            this.tb_tempoScan.Size = new System.Drawing.Size(99, 20);
            this.tb_tempoScan.TabIndex = 11;
            this.tb_tempoScan.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tb_tempoScan.ValueChanged += new System.EventHandler(this.tb_tempoScan_ValueChanged);
            // 
            // btn_setTempoScan
            // 
            this.btn_setTempoScan.Location = new System.Drawing.Point(15, 71);
            this.btn_setTempoScan.Name = "btn_setTempoScan";
            this.btn_setTempoScan.Size = new System.Drawing.Size(118, 26);
            this.btn_setTempoScan.TabIndex = 10;
            this.btn_setTempoScan.Text = "Ok";
            this.btn_setTempoScan.UseVisualStyleBackColor = true;
            this.btn_setTempoScan.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.lb_nomeDoBanco);
            this.tabPage2.Controls.Add(this.btn_criarBanco);
            this.tabPage2.Controls.Add(this.lb_serverStatus);
            this.tabPage2.Controls.Add(this.tb_senha_sql);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_usuario_sql);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_testar_conexao);
            this.tabPage2.Controls.Add(this.tb_servidor_sql);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conf.ODBC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(285, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Testar Conexão";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lb_nomeDoBanco
            // 
            this.lb_nomeDoBanco.AutoSize = true;
            this.lb_nomeDoBanco.Location = new System.Drawing.Point(83, 249);
            this.lb_nomeDoBanco.Name = "lb_nomeDoBanco";
            this.lb_nomeDoBanco.Size = new System.Drawing.Size(10, 13);
            this.lb_nomeDoBanco.TabIndex = 18;
            this.lb_nomeDoBanco.Text = " ";
            this.lb_nomeDoBanco.Click += new System.EventHandler(this.label9_Click);
            // 
            // btn_criarBanco
            // 
            this.btn_criarBanco.Location = new System.Drawing.Point(84, 276);
            this.btn_criarBanco.Name = "btn_criarBanco";
            this.btn_criarBanco.Size = new System.Drawing.Size(158, 23);
            this.btn_criarBanco.TabIndex = 16;
            this.btn_criarBanco.Text = "Criar Banco de Dados";
            this.btn_criarBanco.UseVisualStyleBackColor = true;
            this.btn_criarBanco.Click += new System.EventHandler(this.button6_Click);
            // 
            // lb_serverStatus
            // 
            this.lb_serverStatus.AutoSize = true;
            this.lb_serverStatus.Location = new System.Drawing.Point(83, 121);
            this.lb_serverStatus.Name = "lb_serverStatus";
            this.lb_serverStatus.Size = new System.Drawing.Size(10, 13);
            this.lb_serverStatus.TabIndex = 15;
            this.lb_serverStatus.Text = " ";
            // 
            // tb_senha_sql
            // 
            this.tb_senha_sql.Location = new System.Drawing.Point(86, 98);
            this.tb_senha_sql.Name = "tb_senha_sql";
            this.tb_senha_sql.PasswordChar = '*';
            this.tb_senha_sql.Size = new System.Drawing.Size(156, 20);
            this.tb_senha_sql.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Senha";
            // 
            // tb_usuario_sql
            // 
            this.tb_usuario_sql.Location = new System.Drawing.Point(86, 72);
            this.tb_usuario_sql.Name = "tb_usuario_sql";
            this.tb_usuario_sql.Size = new System.Drawing.Size(156, 20);
            this.tb_usuario_sql.TabIndex = 12;
            this.tb_usuario_sql.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuário";
            // 
            // btn_testar_conexao
            // 
            this.btn_testar_conexao.Location = new System.Drawing.Point(84, 140);
            this.btn_testar_conexao.Name = "btn_testar_conexao";
            this.btn_testar_conexao.Size = new System.Drawing.Size(158, 23);
            this.btn_testar_conexao.TabIndex = 10;
            this.btn_testar_conexao.Text = "Testar Conexão";
            this.btn_testar_conexao.UseVisualStyleBackColor = true;
            this.btn_testar_conexao.Click += new System.EventHandler(this.btn_testar_conexao_Click);
            // 
            // tb_servidor_sql
            // 
            this.tb_servidor_sql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_servidor_sql.FormattingEnabled = true;
            this.tb_servidor_sql.Items.AddRange(new object[] {
            "Selecione",
            "EWS01\\FTVIEWX64TAGDB"});
            this.tb_servidor_sql.Location = new System.Drawing.Point(86, 36);
            this.tb_servidor_sql.Name = "tb_servidor_sql";
            this.tb_servidor_sql.Size = new System.Drawing.Size(156, 21);
            this.tb_servidor_sql.TabIndex = 9;
            this.tb_servidor_sql.SelectedIndexChanged += new System.EventHandler(this.tb_servidor_sql_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(458, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conf.Usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.tb_nome_usuario);
            this.groupBox2.Controls.Add(this.lb_addUser);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cb_Cargo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_senha_usuario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_add_usuario);
            this.groupBox2.Controls.Add(this.tb_add_usuario);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 119);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar Usuários";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Nome:";
            // 
            // tb_nome_usuario
            // 
            this.tb_nome_usuario.Location = new System.Drawing.Point(4, 34);
            this.tb_nome_usuario.Name = "tb_nome_usuario";
            this.tb_nome_usuario.Size = new System.Drawing.Size(350, 20);
            this.tb_nome_usuario.TabIndex = 23;
            // 
            // lb_addUser
            // 
            this.lb_addUser.AutoSize = true;
            this.lb_addUser.Location = new System.Drawing.Point(3, 99);
            this.lb_addUser.Name = "lb_addUser";
            this.lb_addUser.Size = new System.Drawing.Size(10, 13);
            this.lb_addUser.TabIndex = 16;
            this.lb_addUser.Text = " ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(226, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Cargo:";
            // 
            // cb_Cargo
            // 
            this.cb_Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cargo.FormattingEnabled = true;
            this.cb_Cargo.Location = new System.Drawing.Point(229, 75);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(125, 21);
            this.cb_Cargo.TabIndex = 20;
            this.cb_Cargo.SelectedIndexChanged += new System.EventHandler(this.cb_Cargo_SelectedIndexChanged);
            // 
            // tblCargosBindingSource
            // 
            this.tblCargosBindingSource.DataMember = "tblCargos";
            this.tblCargosBindingSource.DataSource = this.iloggerDataSet;
            // 
            // iloggerDataSet
            // 
            this.iloggerDataSet.DataSetName = "IloggerDataSet";
            this.iloggerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Senha:";
            // 
            // tb_senha_usuario
            // 
            this.tb_senha_usuario.Location = new System.Drawing.Point(131, 76);
            this.tb_senha_usuario.Name = "tb_senha_usuario";
            this.tb_senha_usuario.PasswordChar = '*';
            this.tb_senha_usuario.Size = new System.Drawing.Size(92, 20);
            this.tb_senha_usuario.TabIndex = 9;
            this.tb_senha_usuario.TextChanged += new System.EventHandler(this.tb_senha_usuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login:";
            // 
            // btn_add_usuario
            // 
            this.btn_add_usuario.Location = new System.Drawing.Point(360, 72);
            this.btn_add_usuario.Name = "btn_add_usuario";
            this.btn_add_usuario.Size = new System.Drawing.Size(83, 26);
            this.btn_add_usuario.TabIndex = 0;
            this.btn_add_usuario.Text = "Adicionar";
            this.btn_add_usuario.UseVisualStyleBackColor = true;
            this.btn_add_usuario.Click += new System.EventHandler(this.btn_add_usuario_Click_1);
            // 
            // tb_add_usuario
            // 
            this.tb_add_usuario.Location = new System.Drawing.Point(4, 76);
            this.tb_add_usuario.Name = "tb_add_usuario";
            this.tb_add_usuario.Size = new System.Drawing.Size(121, 20);
            this.tb_add_usuario.TabIndex = 5;
            this.tb_add_usuario.TextChanged += new System.EventHandler(this.tb_add_usuario_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.dgCargo);
            this.tabPage4.Controls.Add(this.btn_excluir_cargo);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(458, 333);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cad.Cargos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgCargo
            // 
            this.dgCargo.AllowUserToOrderColumns = true;
            this.dgCargo.AutoGenerateColumns = false;
            this.dgCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn});
            this.dgCargo.DataSource = this.tblCargosBindingSource;
            this.dgCargo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgCargo.Location = new System.Drawing.Point(6, 6);
            this.dgCargo.MultiSelect = false;
            this.dgCargo.Name = "dgCargo";
            this.dgCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCargo.Size = new System.Drawing.Size(443, 150);
            this.dgCargo.TabIndex = 26;
            this.dgCargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCargo_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            // 
            // btn_excluir_cargo
            // 
            this.btn_excluir_cargo.Location = new System.Drawing.Point(366, 189);
            this.btn_excluir_cargo.Name = "btn_excluir_cargo";
            this.btn_excluir_cargo.Size = new System.Drawing.Size(83, 26);
            this.btn_excluir_cargo.TabIndex = 25;
            this.btn_excluir_cargo.Text = "Excluir";
            this.btn_excluir_cargo.UseVisualStyleBackColor = true;
            this.btn_excluir_cargo.Click += new System.EventHandler(this.btn_excluir_cargo_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.tb_cad_cargo);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.btn_cad_cargo);
            this.groupBox7.Controls.Add(this.tb_cad_nivel);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Location = new System.Drawing.Point(6, 221);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(449, 106);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cadastro de Cargos";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Cargo:";
            // 
            // tb_cad_cargo
            // 
            this.tb_cad_cargo.Location = new System.Drawing.Point(4, 34);
            this.tb_cad_cargo.Name = "tb_cad_cargo";
            this.tb_cad_cargo.Size = new System.Drawing.Size(121, 20);
            this.tb_cad_cargo.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = " ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Nível:";
            // 
            // btn_cad_cargo
            // 
            this.btn_cad_cargo.Location = new System.Drawing.Point(140, 70);
            this.btn_cad_cargo.Name = "btn_cad_cargo";
            this.btn_cad_cargo.Size = new System.Drawing.Size(83, 26);
            this.btn_cad_cargo.TabIndex = 0;
            this.btn_cad_cargo.Text = "Adicionar";
            this.btn_cad_cargo.UseVisualStyleBackColor = true;
            this.btn_cad_cargo.Click += new System.EventHandler(this.btn_cad_cargo_Click);
            // 
            // tb_cad_nivel
            // 
            this.tb_cad_nivel.Location = new System.Drawing.Point(4, 76);
            this.tb_cad_nivel.Name = "tb_cad_nivel";
            this.tb_cad_nivel.Size = new System.Drawing.Size(121, 20);
            this.tb_cad_nivel.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(67, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Controls.Add(this.btn_excluir_usuario);
            this.tabPage5.Controls.Add(this.dG_Usuarios);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(458, 333);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hist. Usuário";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lb_altera_Senha);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.tb_nova_senha_usuario);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.btn_altera_senha);
            this.groupBox6.Location = new System.Drawing.Point(6, 262);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(236, 68);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alterar Senha";
            // 
            // lb_altera_Senha
            // 
            this.lb_altera_Senha.AutoSize = true;
            this.lb_altera_Senha.Location = new System.Drawing.Point(6, 63);
            this.lb_altera_Senha.Name = "lb_altera_Senha";
            this.lb_altera_Senha.Size = new System.Drawing.Size(10, 13);
            this.lb_altera_Senha.TabIndex = 20;
            this.lb_altera_Senha.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = " ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Nova Senha:";
            // 
            // tb_nova_senha_usuario
            // 
            this.tb_nova_senha_usuario.Location = new System.Drawing.Point(7, 32);
            this.tb_nova_senha_usuario.Name = "tb_nova_senha_usuario";
            this.tb_nova_senha_usuario.Size = new System.Drawing.Size(92, 20);
            this.tb_nova_senha_usuario.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(67, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 4;
            // 
            // btn_altera_senha
            // 
            this.btn_altera_senha.Location = new System.Drawing.Point(120, 28);
            this.btn_altera_senha.Name = "btn_altera_senha";
            this.btn_altera_senha.Size = new System.Drawing.Size(83, 26);
            this.btn_altera_senha.TabIndex = 0;
            this.btn_altera_senha.Text = "Alterar";
            this.btn_altera_senha.UseVisualStyleBackColor = true;
            this.btn_altera_senha.Click += new System.EventHandler(this.btn_altera_senha_Click_1);
            // 
            // btn_excluir_usuario
            // 
            this.btn_excluir_usuario.Location = new System.Drawing.Point(361, 302);
            this.btn_excluir_usuario.Name = "btn_excluir_usuario";
            this.btn_excluir_usuario.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_usuario.TabIndex = 11;
            this.btn_excluir_usuario.Text = "Excluir";
            this.btn_excluir_usuario.UseVisualStyleBackColor = true;
            this.btn_excluir_usuario.Click += new System.EventHandler(this.btn_excluir_usuario_Click);
            // 
            // dG_Usuarios
            // 
            this.dG_Usuarios.AllowUserToOrderColumns = true;
            this.dG_Usuarios.AutoGenerateColumns = false;
            this.dG_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn,
            this.datacriacaoDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dG_Usuarios.DataSource = this.tblUsuariosBindingSource1;
            this.dG_Usuarios.Location = new System.Drawing.Point(2, 0);
            this.dG_Usuarios.Name = "dG_Usuarios";
            this.dG_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dG_Usuarios.Size = new System.Drawing.Size(450, 256);
            this.dG_Usuarios.TabIndex = 10;
            this.dG_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_Usuarios_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // datacriacaoDataGridViewTextBoxColumn
            // 
            this.datacriacaoDataGridViewTextBoxColumn.DataPropertyName = "data_criacao";
            this.datacriacaoDataGridViewTextBoxColumn.HeaderText = "data_criacao";
            this.datacriacaoDataGridViewTextBoxColumn.Name = "datacriacaoDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tblUsuariosBindingSource1
            // 
            this.tblUsuariosBindingSource1.DataMember = "tblUsuarios";
            this.tblUsuariosBindingSource1.DataSource = this.iloggerDataSet1;
            // 
            // iloggerDataSet1
            // 
            this.iloggerDataSet1.DataSetName = "IloggerDataSet1";
            this.iloggerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsuariosBindingSource
            // 
            this.tblUsuariosBindingSource.DataMember = "tblUsuarios";
            this.tblUsuariosBindingSource.DataSource = this.iloggerDataSetUsuarios;
            // 
            // iloggerDataSetUsuarios
            // 
            this.iloggerDataSetUsuarios.DataSetName = "IloggerDataSetUsuarios";
            this.iloggerDataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCargosTableAdapter
            // 
            this.tblCargosTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsuariosTableAdapter
            // 
            this.tblUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsuariosTableAdapter1
            // 
            this.tblUsuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // tblCargosBindingSource1
            // 
            this.tblCargosBindingSource1.DataMember = "tblCargos";
            this.tblCargosBindingSource1.DataSource = this.iloggerDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(134, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 26);
            this.button6.TabIndex = 24;
            this.button6.Text = "Adicionar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 366);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tempoScan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCargosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloggerDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCargo)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloggerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloggerDataSetUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCargosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker bwLer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbServidor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lv_tagList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader ch_tag;
        private System.Windows.Forms.ColumnHeader ch_valor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tag;
        private System.Windows.Forms.ComboBox cb_Servidores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox tb_servidor_sql;
        private System.Windows.Forms.Button btn_testar_conexao;
        private System.Windows.Forms.TextBox tb_usuario_sql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_senha_sql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_serverStatus;
        private System.Windows.Forms.Button btn_criarBanco;
        private System.Windows.Forms.Label lb_nomeDoBanco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_setTempoScan;
        private System.Windows.Forms.NumericUpDown tb_tempoScan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_senha_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_add_usuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_add_usuario;
        private System.Windows.Forms.Label lb_addUser;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_Cargo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_nome_usuario;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_cad_cargo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_cad_cargo;
        private System.Windows.Forms.TextBox tb_cad_nivel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_excluir_cargo;
        private IloggerDataSet iloggerDataSet;
        private System.Windows.Forms.BindingSource tblCargosBindingSource;
        private IloggerDataSetTableAdapters.tblCargosTableAdapter tblCargosTableAdapter;
        private IloggerDataSetUsuarios iloggerDataSetUsuarios;
        private System.Windows.Forms.BindingSource tblUsuariosBindingSource;
        private IloggerDataSetUsuariosTableAdapters.tblUsuariosTableAdapter tblUsuariosTableAdapter;
        private System.Windows.Forms.DataGridView dgCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_excluir_usuario;
        private IloggerDataSet1 iloggerDataSet1;
        private System.Windows.Forms.BindingSource tblUsuariosBindingSource1;
        private IloggerDataSet1TableAdapters.tblUsuariosTableAdapter tblUsuariosTableAdapter1;
        private System.Windows.Forms.DataGridView dG_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lb_altera_Senha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_nova_senha_usuario;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_altera_senha;
        private System.Windows.Forms.BindingSource tblCargosBindingSource1;
        private System.Windows.Forms.Button button6;
    }
}

