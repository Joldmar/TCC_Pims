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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_servidor_sql = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_testar_conexao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_usuario_sql = new System.Windows.Forms.TextBox();
            this.tb_senha_sql = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_serverStatus = new System.Windows.Forms.Label();
            this.btn_criarBanco = new System.Windows.Forms.Button();
            this.lb_nomeDoBanco = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_setTempoScan = new System.Windows.Forms.Button();
            this.tb_tempoScan = new System.Windows.Forms.NumericUpDown();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tempoScan)).BeginInit();
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
            // 
            // ch_valor
            // 
            this.ch_valor.Text = "Valor";
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
            this.groupBox4.Size = new System.Drawing.Size(441, 200);
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
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(458, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ola";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuário";
            // 
            // tb_usuario_sql
            // 
            this.tb_usuario_sql.Location = new System.Drawing.Point(86, 72);
            this.tb_usuario_sql.Name = "tb_usuario_sql";
            this.tb_usuario_sql.Size = new System.Drawing.Size(156, 20);
            this.tb_usuario_sql.TabIndex = 12;
            this.tb_usuario_sql.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // lb_serverStatus
            // 
            this.lb_serverStatus.AutoSize = true;
            this.lb_serverStatus.Location = new System.Drawing.Point(83, 121);
            this.lb_serverStatus.Name = "lb_serverStatus";
            this.lb_serverStatus.Size = new System.Drawing.Size(10, 13);
            this.lb_serverStatus.TabIndex = 15;
            this.lb_serverStatus.Text = " ";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tempoScan);
            this.groupBox1.Controls.Add(this.btn_setTempoScan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(250, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor OPC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "ms";
            // 
            // btn_setTempoScan
            // 
            this.btn_setTempoScan.Location = new System.Drawing.Point(15, 57);
            this.btn_setTempoScan.Name = "btn_setTempoScan";
            this.btn_setTempoScan.Size = new System.Drawing.Size(99, 23);
            this.btn_setTempoScan.TabIndex = 10;
            this.btn_setTempoScan.Text = "Ok";
            this.btn_setTempoScan.UseVisualStyleBackColor = true;
            this.btn_setTempoScan.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tb_tempoScan
            // 
            this.tb_tempoScan.Location = new System.Drawing.Point(15, 32);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 376);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tempoScan)).EndInit();
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
        private System.Windows.Forms.Label label2;
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
    }
}

