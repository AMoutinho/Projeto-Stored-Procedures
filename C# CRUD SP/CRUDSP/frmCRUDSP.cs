using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSP
{
    public partial class frmCRUDSP : Form
    {
        public frmCRUDSP()
        {
            InitializeComponent();
            cbxCidade.Text = "Cidade...";
            cbxCargo.Text = "Cargo...";
            cbxPretensaoSalarial.Text = "Pretensão Salarial...";
        }

        #region String de Conexão
        SqlConnection conexao = new SqlConnection(@"Data Source=MOUTINHO-PC\SQLEXPRESS;Initial Catalog=CRUDSP;Integrated Security=True");
        #endregion

        #region Inserção de Funcionário
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            int ID_funcionario = int.Parse(txtbxID.Text);
            string Nome_funcionario = txtbxNome.Text, Cidade = cbxCidade.Text, Contato = txtbxContato.Text, Cargo = cbxCargo.Text, Genero = "", PretensaoS = cbxPretensaoSalarial.Text;
            double Idade = double.Parse(txtbxIdade.Text);  
            if (rdbMasculino.Checked == true)
            {
                Genero = "Masculino";
            }
            else
            {
                Genero = "Feminino";
            }
            conexao.Open();
            SqlCommand cnx = new SqlCommand("exec InserirFuncionarioSP '" + ID_funcionario + "', '" + Nome_funcionario + "', '" + Cidade + "', '" + Idade + "', '" + Genero + "', '" + Contato + "', '" + Cargo + "','" + PretensaoS + "'", conexao);
            cnx.ExecuteNonQuery();
            MessageBox.Show("Funcionário(a) inserido(a) com sucesso !", "Inserção | CRUD Stored Procedures",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ObterListagemFuncionarios();
        }
        #endregion

        #region Método de Obter Listagem de Funcionários
        void ObterListagemFuncionarios()
        {
            SqlCommand cnx = new SqlCommand("exec ListarFuncionarioSP", conexao);
            SqlDataAdapter sd = new SqlDataAdapter(cnx);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvFuncionarios.DataSource = dt;
        }
        #endregion

        #region Carregamento do Formulário
        private void FrmCRUDSP_Load(object sender, EventArgs e)
        {
            ObterListagemFuncionarios();

            btnRegistrarFuncionario.Enabled = true;
            btnInserir.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCarregarRegistro.Enabled = false;
            txtbxID.Enabled = true;
            txtbxNome.Enabled = false;
            txtbxIdade.Enabled = false;
            txtbxContato.Enabled = false;
            cbxCidade.Enabled = false;
            cbxCargo.Enabled = false;
            cbxPretensaoSalarial.Enabled = false;
            rdbMasculino.Enabled = false;
            rdbFeminino.Enabled = false;
        }
        #endregion

        #region Atualizar Funcionário
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int ID_funcionario = int.Parse(txtbxID.Text);
            string Nome_funcionario = txtbxNome.Text, Cidade = cbxCidade.Text, Contato = txtbxContato.Text, Cargo = cbxCargo.Text, Genero = "", PretensaoS = cbxPretensaoSalarial.Text;
            double Idade = double.Parse(txtbxIdade.Text);
            if (rdbMasculino.Checked == true)
            {
                Genero = "Masculino";
            }
            else
            {
                Genero = "Feminino";
            }
            conexao.Open();
            SqlCommand cnx = new SqlCommand("exec EditarFuncionarioSP '" + ID_funcionario + "', '" + Nome_funcionario + "', '" + Cidade + "', '" + Idade + "', '" + Genero + "', '" + Contato + "', '" + Cargo + "','" + PretensaoS + "'", conexao);
            cnx.ExecuteNonQuery();
            MessageBox.Show("Funcionário(a) atualizado(a) com sucesso !", "Atualização | CRUD Stored Procedures",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ObterListagemFuncionarios();
        }
        #endregion

        #region Deletar Funcionário
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja deletar o funcionário(a) do sistema ?", "Exclusão | CRUD Stored Procedures", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID_funcionario = int.Parse(txtbxID.Text);
                conexao.Open();
                SqlCommand cnx = new SqlCommand("exec DeletarFuncionarioSP '" + ID_funcionario + "'", conexao);
                cnx.ExecuteNonQuery();
                MessageBox.Show("Funcionário(a) excluído(a) com sucesso !", "Exclusão | CRUD Stored Procedures",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObterListagemFuncionarios();
            }           
        }
        #endregion

        #region Carregar Registro
        private void BtnCarregarRegistro_Click(object sender, EventArgs e)
        {
            int ID_funcionario = int.Parse(txtbxID.Text);            
            SqlCommand cnx = new SqlCommand("exec CarregarEspecificacoesFunc'" + ID_funcionario + "'", conexao);
            SqlDataAdapter sd = new SqlDataAdapter(cnx);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvFuncionarios.DataSource = dt;
        }
        #endregion

        #region Registrar Funcionário
        private void BtnRegistrarFuncionario_Click(object sender, EventArgs e)
        {
            btnRegistrarFuncionario.Enabled = false;
            btnInserir.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
            btnCarregarRegistro.Enabled = true;
            txtbxID.Enabled = true;
            txtbxNome.Enabled = true;
            txtbxIdade.Enabled = true;
            txtbxContato.Enabled = true;
            cbxCidade.Enabled = true;
            cbxCargo.Enabled = true;
            cbxPretensaoSalarial.Enabled = true;
            rdbMasculino.Enabled = true;
            rdbFeminino.Enabled = true;
        }
        #endregion
    }
}
