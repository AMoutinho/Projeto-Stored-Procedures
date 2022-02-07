namespace CRUDSP
{
    partial class frmCRUDSP
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNomeFormulario = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.txtbxIdade = new System.Windows.Forms.TextBox();
            this.txtbxContato = new System.Windows.Forms.TextBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.gpbDadosFunc = new System.Windows.Forms.GroupBox();
            this.cbxPretensaoSalarial = new System.Windows.Forms.ComboBox();
            this.lblPreSalarial = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.tTlpControles = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegistrarFuncionario = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCarregarRegistro = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tStpDesenvolvedor = new System.Windows.Forms.ToolStrip();
            this.tSLblDesenvolvedor = new System.Windows.Forms.ToolStripLabel();
            this.gpbDadosFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.tStpDesenvolvedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFormulario
            // 
            this.lblNomeFormulario.AutoSize = true;
            this.lblNomeFormulario.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFormulario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNomeFormulario.Location = new System.Drawing.Point(209, 4);
            this.lblNomeFormulario.Name = "lblNomeFormulario";
            this.lblNomeFormulario.Size = new System.Drawing.Size(432, 38);
            this.lblNomeFormulario.TabIndex = 0;
            this.lblNomeFormulario.Text = "CRUD - Stored Procedures";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblid.Location = new System.Drawing.Point(6, 40);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(123, 19);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID Funcionário";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblnome.Location = new System.Drawing.Point(298, 39);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(59, 19);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome ";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblcidade.Location = new System.Drawing.Point(6, 78);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(63, 19);
            this.lblcidade.TabIndex = 3;
            this.lblcidade.Text = "Cidade";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblidade.Location = new System.Drawing.Point(587, 39);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(51, 19);
            this.lblidade.TabIndex = 4;
            this.lblidade.Text = "Idade";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblgenero.Location = new System.Drawing.Point(298, 78);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(67, 19);
            this.lblgenero.TabIndex = 5;
            this.lblgenero.Text = "Gênero";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblContato.Location = new System.Drawing.Point(587, 76);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(72, 19);
            this.lblContato.TabIndex = 7;
            this.lblContato.Text = "Contato";
            // 
            // txtbxID
            // 
            this.txtbxID.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxID.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtbxID.Location = new System.Drawing.Point(131, 33);
            this.txtbxID.Multiline = true;
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(161, 29);
            this.txtbxID.TabIndex = 8;
            // 
            // txtbxNome
            // 
            this.txtbxNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxNome.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtbxNome.Location = new System.Drawing.Point(355, 33);
            this.txtbxNome.Multiline = true;
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(209, 29);
            this.txtbxNome.TabIndex = 9;
            // 
            // txtbxIdade
            // 
            this.txtbxIdade.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxIdade.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtbxIdade.Location = new System.Drawing.Point(644, 33);
            this.txtbxIdade.Multiline = true;
            this.txtbxIdade.Name = "txtbxIdade";
            this.txtbxIdade.Size = new System.Drawing.Size(182, 29);
            this.txtbxIdade.TabIndex = 11;
            // 
            // txtbxContato
            // 
            this.txtbxContato.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxContato.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtbxContato.Location = new System.Drawing.Point(661, 70);
            this.txtbxContato.Multiline = true;
            this.txtbxContato.Name = "txtbxContato";
            this.txtbxContato.Size = new System.Drawing.Size(165, 29);
            this.txtbxContato.TabIndex = 12;
            // 
            // cbxCidade
            // 
            this.cbxCidade.BackColor = System.Drawing.SystemColors.Info;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "Santos",
            "São Vicente",
            "Guaruja",
            "Praia Grande",
            "Itanhaem",
            "Peruíbe",
            "Bertioga",
            "São Paulo"});
            this.cbxCidade.Location = new System.Drawing.Point(75, 75);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(217, 27);
            this.cbxCidade.TabIndex = 13;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Arial", 12.25F);
            this.rdbMasculino.Location = new System.Drawing.Point(371, 76);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(100, 23);
            this.rdbMasculino.TabIndex = 14;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Font = new System.Drawing.Font("Arial", 12.25F);
            this.rdbFeminino.Location = new System.Drawing.Point(470, 76);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(94, 23);
            this.rdbFeminino.TabIndex = 15;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // gpbDadosFunc
            // 
            this.gpbDadosFunc.Controls.Add(this.cbxPretensaoSalarial);
            this.gpbDadosFunc.Controls.Add(this.lblPreSalarial);
            this.gpbDadosFunc.Controls.Add(this.lblCargo);
            this.gpbDadosFunc.Controls.Add(this.cbxCargo);
            this.gpbDadosFunc.Controls.Add(this.lblContato);
            this.gpbDadosFunc.Controls.Add(this.lblid);
            this.gpbDadosFunc.Controls.Add(this.rdbFeminino);
            this.gpbDadosFunc.Controls.Add(this.lblnome);
            this.gpbDadosFunc.Controls.Add(this.rdbMasculino);
            this.gpbDadosFunc.Controls.Add(this.lblcidade);
            this.gpbDadosFunc.Controls.Add(this.cbxCidade);
            this.gpbDadosFunc.Controls.Add(this.lblidade);
            this.gpbDadosFunc.Controls.Add(this.txtbxContato);
            this.gpbDadosFunc.Controls.Add(this.lblgenero);
            this.gpbDadosFunc.Controls.Add(this.txtbxIdade);
            this.gpbDadosFunc.Controls.Add(this.txtbxNome);
            this.gpbDadosFunc.Controls.Add(this.txtbxID);
            this.gpbDadosFunc.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.gpbDadosFunc.Location = new System.Drawing.Point(5, 45);
            this.gpbDadosFunc.Name = "gpbDadosFunc";
            this.gpbDadosFunc.Size = new System.Drawing.Size(836, 151);
            this.gpbDadosFunc.TabIndex = 17;
            this.gpbDadosFunc.TabStop = false;
            this.gpbDadosFunc.Text = "Dados Cadastrais";
            // 
            // cbxPretensaoSalarial
            // 
            this.cbxPretensaoSalarial.BackColor = System.Drawing.SystemColors.Info;
            this.cbxPretensaoSalarial.FormattingEnabled = true;
            this.cbxPretensaoSalarial.Items.AddRange(new object[] {
            "R$ 1.800 à R$ 2.000",
            "R$ 2.500 à R$ 3.000",
            "R$ 4.500"});
            this.cbxPretensaoSalarial.Location = new System.Drawing.Point(160, 114);
            this.cbxPretensaoSalarial.Name = "cbxPretensaoSalarial";
            this.cbxPretensaoSalarial.Size = new System.Drawing.Size(197, 27);
            this.cbxPretensaoSalarial.TabIndex = 20;
            // 
            // lblPreSalarial
            // 
            this.lblPreSalarial.AutoSize = true;
            this.lblPreSalarial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPreSalarial.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblPreSalarial.Location = new System.Drawing.Point(6, 117);
            this.lblPreSalarial.Name = "lblPreSalarial";
            this.lblPreSalarial.Size = new System.Drawing.Size(151, 19);
            this.lblPreSalarial.TabIndex = 19;
            this.lblPreSalarial.Text = "Pretensão Salarial";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblCargo.Location = new System.Drawing.Point(367, 117);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(57, 19);
            this.lblCargo.TabIndex = 17;
            this.lblCargo.Text = "Cargo";
            // 
            // cbxCargo
            // 
            this.cbxCargo.BackColor = System.Drawing.SystemColors.Info;
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Design UX/UI",
            "Desenvolvedor Full Stack",
            "Infraestrutura TI",
            "Cientista de Dados"});
            this.cbxCargo.Location = new System.Drawing.Point(430, 114);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(229, 27);
            this.cbxCargo.TabIndex = 18;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(7, 202);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(834, 292);
            this.dgvFuncionarios.TabIndex = 22;
            // 
            // btnRegistrarFuncionario
            // 
            this.btnRegistrarFuncionario.BackgroundImage = global::CRUDSP.Properties.Resources.Registrar_Funcionario;
            this.btnRegistrarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarFuncionario.Location = new System.Drawing.Point(7, 501);
            this.btnRegistrarFuncionario.Name = "btnRegistrarFuncionario";
            this.btnRegistrarFuncionario.Size = new System.Drawing.Size(59, 59);
            this.btnRegistrarFuncionario.TabIndex = 23;
            this.tTlpControles.SetToolTip(this.btnRegistrarFuncionario, "Registrar um Funcionário(a)");
            this.btnRegistrarFuncionario.UseVisualStyleBackColor = true;
            this.btnRegistrarFuncionario.Click += new System.EventHandler(this.BtnRegistrarFuncionario_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackgroundImage = global::CRUDSP.Properties.Resources.Deletar;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDeletar.Location = new System.Drawing.Point(583, 501);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(55, 59);
            this.btnDeletar.TabIndex = 20;
            this.tTlpControles.SetToolTip(this.btnDeletar, "Deletar Funcionário(a)");
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::CRUDSP.Properties.Resources.Atualizar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAtualizar.Location = new System.Drawing.Point(386, 501);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(58, 59);
            this.btnAtualizar.TabIndex = 19;
            this.tTlpControles.SetToolTip(this.btnAtualizar, "Editar Funcionário(a)");
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnCarregarRegistro
            // 
            this.btnCarregarRegistro.BackgroundImage = global::CRUDSP.Properties.Resources.Buscar;
            this.btnCarregarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregarRegistro.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCarregarRegistro.Location = new System.Drawing.Point(782, 501);
            this.btnCarregarRegistro.Name = "btnCarregarRegistro";
            this.btnCarregarRegistro.Size = new System.Drawing.Size(59, 59);
            this.btnCarregarRegistro.TabIndex = 21;
            this.tTlpControles.SetToolTip(this.btnCarregarRegistro, "Carregar Registro de Funcionário(a)");
            this.btnCarregarRegistro.UseVisualStyleBackColor = true;
            this.btnCarregarRegistro.Click += new System.EventHandler(this.BtnCarregarRegistro_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::CRUDSP.Properties.Resources.Inserir;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.Font = new System.Drawing.Font("Arial", 12F);
            this.btnInserir.Location = new System.Drawing.Point(205, 501);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(57, 59);
            this.btnInserir.TabIndex = 18;
            this.tTlpControles.SetToolTip(this.btnInserir, "Inserir Funcionário(a)");
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // tStpDesenvolvedor
            // 
            this.tStpDesenvolvedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tStpDesenvolvedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLblDesenvolvedor});
            this.tStpDesenvolvedor.Location = new System.Drawing.Point(0, 580);
            this.tStpDesenvolvedor.Name = "tStpDesenvolvedor";
            this.tStpDesenvolvedor.Size = new System.Drawing.Size(848, 25);
            this.tStpDesenvolvedor.TabIndex = 24;
            // 
            // tSLblDesenvolvedor
            // 
            this.tSLblDesenvolvedor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tSLblDesenvolvedor.ForeColor = System.Drawing.Color.Blue;
            this.tSLblDesenvolvedor.Name = "tSLblDesenvolvedor";
            this.tSLblDesenvolvedor.Size = new System.Drawing.Size(249, 22);
            this.tSLblDesenvolvedor.Text = "Desenvolvido por André Moutinho";
            // 
            // frmCRUDSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 605);
            this.Controls.Add(this.tStpDesenvolvedor);
            this.Controls.Add(this.btnRegistrarFuncionario);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.gpbDadosFunc);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCarregarRegistro);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblNomeFormulario);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCRUDSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Stored Procedures";
            this.Load += new System.EventHandler(this.FrmCRUDSP_Load);
            this.gpbDadosFunc.ResumeLayout(false);
            this.gpbDadosFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.tStpDesenvolvedor.ResumeLayout(false);
            this.tStpDesenvolvedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFormulario;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.TextBox txtbxIdade;
        private System.Windows.Forms.TextBox txtbxContato;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.GroupBox gpbDadosFunc;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCarregarRegistro;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Label lblPreSalarial;
        private System.Windows.Forms.ComboBox cbxPretensaoSalarial;
        private System.Windows.Forms.ToolTip tTlpControles;
        private System.Windows.Forms.Button btnRegistrarFuncionario;
        private System.Windows.Forms.ToolStrip tStpDesenvolvedor;
        private System.Windows.Forms.ToolStripLabel tSLblDesenvolvedor;
    }
}

