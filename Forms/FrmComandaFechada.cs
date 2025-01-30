using GerenciadorDeComandas.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas.Forms
{
    public partial class FrmComandaFechada : Form
    {
        int IdCliente;
        string Data;
        string Nome;
        private FrmControleComandas controleComandas;

        public FrmComandaFechada(int Id, string Nome, string Data, FrmControleComandas controleComandas)
        {
            InitializeComponent();
            this.controleComandas = controleComandas;
            
            this.IdCliente = Id;
            this.Data = Data;
            lblNomeComanda.Text = Nome;
        }

        private void FrmComandaFechada_Load(object sender, EventArgs e)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            DataTable dados = conexao.SelectProdutosQuantidade(this.IdCliente);

            dgvProdutosComprados.DataSource = dados;

            dgvProdutosComprados.Columns["ProdutoID"].Visible = false;
            dgvProdutosComprados.Columns["ProdutoNome"].HeaderText = "Produto";
            dgvProdutosComprados.Columns["PrecoUnitario"].HeaderText = "Preço Unid.";
            dgvProdutosComprados.Columns["PrecoUnitario"].DefaultCellStyle.Format = "C2";
            dgvProdutosComprados.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvProdutosComprados.Columns["PrecoTotal"].Visible = false;


            double valorFinal = 0;

            foreach (DataRow row in dados.Rows)
            {
                if (row["PrecoTotal"] != DBNull.Value)
                {
                    valorFinal += Convert.ToDouble(row["PrecoTotal"]);
                }
            }

            lblValorTotal.Text = valorFinal.ToString("C", new CultureInfo("pt-BR"));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoBanco banco = new ConexaoBanco();

            string query = $"UPDATE clientes SET Ativo = '0' WHERE Id = {this.IdCliente}";

            banco.ExecutarComando(query);

            MessageBox.Show("Total Recebido! Comanda fechada!");

            controleComandas.AlterarAba(2);
            Close();
        }

        private void btnEditarComanda_Click(object sender, EventArgs e)
        {
            Close();
            FrmComanda comanda = new FrmComanda(IdCliente, Nome, Data)
            {
                Owner = controleComandas
            };
            comanda.ShowDialog();
        }
    }
}
