using GerenciadorDeComandas.Banco;
using GerenciadorDeComandas.Classes;
using GerenciadorDeComandas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas
{
    public partial class FrmComanda : Form
    {
        int IdCliente;
        string NomeCLiente;
        string Data;

        
        public FrmComanda(int Id, string Nome, string Data, List<Comanda> ProdutosPorComanda)
        {
            InitializeComponent();
            this.IdCliente = Id;
            this.NomeCLiente = Nome;
            this.Data = Data;
            lblNomeComanda.Text = Nome;
            
            List<Comanda> produtos = ProdutosPorComanda;
            CarregarProdutos();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void CarregarProdutos()
        {
            ConexaoBanco conexao = new ConexaoBanco();

            DataTable dados = conexao.SelectProdutos(this.IdCliente);
            dgvProdutos.DataSource = dados;

            // Configuração visual do GridView (opcional)
            dgvProdutos.Columns["ProdutoID"].Visible = false;
            dgvProdutos.Columns["ProdutoNome"].HeaderText = "Nome do Produto";
            dgvProdutos.Columns["PrecoUnitario"].Visible = false;
            dgvProdutos.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvProdutos.Columns["PrecoTotal"].Visible = false;

        }

        private void btnDecrementar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dgvProdutos.SelectedRows[0];

                if (linhaSelecionada.Cells["Quantidade"].Value == null || linhaSelecionada.Cells["Quantidade"].Value.ToString() == "")
                {
                    linhaSelecionada.Cells["Quantidade"].Value = 0; // Inicializa com 0, se estiver vazio
                }

                int quantidadeAtual = Convert.ToInt32(linhaSelecionada.Cells["Quantidade"].Value);
                linhaSelecionada.Cells["Quantidade"].Value = quantidadeAtual - 1;

                if (quantidadeAtual <= 0)
                {
                    linhaSelecionada.Cells["Quantidade"].Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para incrementar a quantidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dgvProdutos.SelectedRows[0];

                if (linhaSelecionada.Cells["Quantidade"].Value == null || linhaSelecionada.Cells["Quantidade"].Value.ToString() == "")
                {
                    linhaSelecionada.Cells["Quantidade"].Value = 0; // Inicializa com 0, se estiver vazio
                }

                int quantidadeAtual = Convert.ToInt32(linhaSelecionada.Cells["Quantidade"].Value);
                linhaSelecionada.Cells["Quantidade"].Value = quantidadeAtual + 1;
            }
            else
            {
                MessageBox.Show("Selecione uma linha para incrementar a quantidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSalvarComanda_Click(object sender, EventArgs e)
        {
            SalvarComanda();
            MessageBox.Show("Salvo com sucesso!");
            Close();
        }

        private void FrmComanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarComanda();
        }

        private void lblNomeComanda_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharComanda_Click(object sender, EventArgs e)
        {
            SalvarComanda();
            Close();
            FrmComandaFechada frmComandaFechada = new FrmComandaFechada(this.IdCliente, NomeCLiente, Data, (FrmControleComandas)this.Owner)
            {
                Owner = this.Owner
            };
            frmComandaFechada.ShowDialog();

        }

        private void SalvarComanda()
        {
            try
            {
                //foreach (DataGridViewRow row in dgvProdutos.Rows)
                foreach(DataGridViewRow row in dgvProdutos.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    if (row.Cells["Quantidade"].Value != null && int.TryParse(row.Cells["Quantidade"].Value.ToString(), out int quantidade))
                    {
                        if(row.Cells["ProdutoID"].Value != null && int.TryParse(row.Cells["ProdutoID"].Value.ToString(), out int produtoId) &&                   row.Cells["PrecoUnitario"].Value != null && double.TryParse(row.Cells["PrecoUnitario"].Value.ToString(), out double precoUnid))
                        {
                            double precoTotal = quantidade * precoUnid;

                            Comanda produto = ProdutosPorComanda.FirstOrDefault(c => c.ProdutoId == produtoId);
                            if(quantidade == 0)
                            {
                                ProdutosPorComanda.Remove(produto);
                            }

                            else if(quantidade > 0)
                            {
                                ProdutosPorComanda.Add(new Comanda
                                {
                                    ClienteId = IdCliente,
                                    ProdutoId = produtoId,
                                    Quantidade = quantidade,
                                    ValorTotal = precoTotal,
                                });
                            }

                        }

                    }
                }

                Comanda comanda = new Comanda();
                comanda.SalvarProdutosComandas(ProdutosPorComanda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        } 
    }

}
    
