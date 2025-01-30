using GerenciadorDeComandas.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas.Forms
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarProdutos()
        {
            ConexaoBanco conexao = new ConexaoBanco();

            string query = "SELECT * FROM produtos;";
            DataTable dados = conexao.Select(query);

            dgvProdutosCadastro.DataSource = dados;

            dgvProdutosCadastro.Columns["Id"].HeaderText = "Id";
            dgvProdutosCadastro.Columns["Nome"].HeaderText = "Nome do Produto";
            dgvProdutosCadastro.Columns["PrecoUnid"].HeaderText = "Preço";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()){
                return;
            }


            ConexaoBanco conexao = new ConexaoBanco();

            string query = $@"INSERT INTO produtos (Id, Nome, PrecoUnid)
                VALUES ({numIdProduto.Value}, '{txtNomeProduto.Text}', '{numPreco.Value.ToString().Replace(",",".")}')
                ON CONFLICT(Id) 
                DO UPDATE SET 
                Nome = excluded.Nome, 
                PrecoUnid = excluded.PrecoUnid;";
            
            string retorno = conexao.ExecutarComando(query);

            if(retorno == "")
            {
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                MessageBox.Show(retorno);
            }
            
            CarregarProdutos();
            LimparCampos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dgvProdutosCadastro.SelectedRows[0];

            numIdProduto.Value = Convert.ToInt32(linha.Cells["Id"].Value);
            txtNomeProduto.Text = linha.Cells["Nome"].Value.ToString();
            numPreco.Value = Convert.ToInt32(linha.Cells["PrecoUnid"].Value);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dgvProdutosCadastro.SelectedRows[0];
            int Id = Convert.ToInt32(linha.Cells["Id"].Value);
            string Nome = linha.Cells["Nome"].Value.ToString();

            DialogResult resultado = MessageBox.Show($"Deseja realmente deletar o produto: {Nome}?",
                                             "Confirmação",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if(resultado == DialogResult.No)
            {
                return;
            }
            ConexaoBanco conexao = new ConexaoBanco();


            string query = $"DELETE FROM produtos WHERE Id = {Id};";

            string retorno = conexao.ExecutarComando(query);

            if (retorno == "")
            {
                MessageBox.Show("Deletado com sucesso!");
            }
            else
            {
                MessageBox.Show(retorno);
            }
            

            CarregarProdutos();
        }

        private void LimparCampos()
        {
            numIdProduto.Value = 0;
            numPreco.Value = 0;
            txtNomeProduto.Clear();
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNomeProduto.Text))
            {
                MessageBox.Show("Por favor, insira o nome do produto.");
                return false;
            }

            if (numPreco.Value == 0 || numPreco == null)
            {
                MessageBox.Show("Por favor, insira o preço do produto.");
                return false;
            }

            if (numIdProduto.Value == 0 || numIdProduto == null)
            {
                MessageBox.Show(@"Por favor, insira o Id do produto. Siga a tabela para adicionar novos produtos: 
                                    cerveja = 10
                                    bebidas = 20
                                    Porcoes = 30
                                    Outros = 40 
                                 Para os 2 primeiros digitos e os outros siga a ordem na tabela!");
                return false;
            }

            return true;
        }
    }
}
