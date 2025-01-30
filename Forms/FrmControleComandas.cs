using GerenciadorDeComandas.Banco;
using GerenciadorDeComandas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GerenciadorDeComandas
{
    public partial class FrmControleComandas : Form
    {
        public FrmControleComandas()
        {
            InitializeComponent();
            CarregarClientesAtivos();

            mtxtDataHoje.Text = DateTime.Now.ToString();
        }

        
        public void AlterarAba(int indice)
        {
            tabControlComandas.SelectedIndex = indice;

            if (tabControlComandas.SelectedIndex == 0)
            {
                CarregarClientesAtivos();

            }

            if (tabControlComandas.SelectedIndex == 2)
            {
                string data = dtpDatasComandas.Value.Date.ToString("yyyy-MM-dd");
                CarregarClientesPorData(data);
            }
        }

        private void btnAbrirComanda_Click(object sender, EventArgs e)
        {
            Cliente  cliente = new Cliente();

            if (string.IsNullOrEmpty(txtNomeCliente.Text))
            {
                MessageBox.Show("Por Favor, adicione um nome para a comanda!");
                return; 
            }
            cliente.Nome = txtNomeCliente.Text;
            cliente.Date = DateTime.Now;
            cliente.Ativo = 1;
            string retorno = cliente.CriarCliente();

            if(retorno == "")
            {
                tabControlComandas.SelectedIndex = 0;
            }
        }

        private void tabControlComandas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlComandas.SelectedIndex == 0)
            {
                CarregarClientesAtivos();

            }

            if(tabControlComandas.SelectedIndex == 2)
            {
                string data = dtpDatasComandas.Value.Date.ToString("yyyy-MM-dd");
                CarregarClientesPorData(data);

                ValorTotalFinal(data);
            }

            
        }

        int paginaAtual = 0; 
        int tamanhoPagina = 34; 


        private void CarregarClientesAtivos()
        {
            panelComandasAbertas.Controls.Clear();

            ConexaoBanco conexao = new ConexaoBanco();
            string query = $@"
                SELECT *
                FROM clientes
                ORDER BY Id ASC
                LIMIT {tamanhoPagina} OFFSET {paginaAtual * tamanhoPagina};";

            DataTable dados = conexao.Select(query);
            
            
            foreach(DataRow comanda in dados.Rows)
            {
                int Id = Convert.ToInt32(comanda["Id"].ToString());
                string ativo = comanda["Ativo"].ToString();
                if ( ativo != "0")
                {
                    string nome = comanda["Nome"].ToString();
                    string data = comanda["Data"].ToString();


                    var userControlComanda = new UserControlComanda(Id, this);
                    userControlComanda.SetComanda(nome, data, ativo);

                    panelComandasAbertas.Controls.Add(userControlComanda);
                }

            }

            btnIncrementarPag.Enabled = dados.Rows.Count == tamanhoPagina;

            btnDecrementarPag.Enabled = paginaAtual > 0;
        }

        private void btnIncrementarPag_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            CarregarClientesAtivos();
        }

        private void btnDecrementarPag_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 0)
            {
                paginaAtual--;
                CarregarClientesAtivos();
            }
        }

        private void CarregarClientesPorData(string Data)
        {
            panelComandasFechadas.Controls.Clear();

            ConexaoBanco conexao = new ConexaoBanco();

            string query = $"SELECT * FROM clientes WHERE Data = '{Data}';";
            DataTable dados = conexao.Select(query);


            foreach (DataRow comanda in dados.Rows)
            {
                int Id = Convert.ToInt32(comanda["Id"].ToString());
                string ativo = comanda["Ativo"].ToString();
                if (ativo == "0")
                {
                    string nome = comanda["Nome"].ToString();
                    string data = comanda["Data"].ToString();


                    var userControlComanda = new UserControlComanda(Id, this);
                    userControlComanda.SetComanda(nome, data, ativo);

                    panelComandasFechadas.Controls.Add(userControlComanda);
                }

            }
        }

        private void ValorTotalFinal(string data)
        {

            ConexaoBanco conexao = new ConexaoBanco();

            string query = $@"SELECT SUM(COALESCE(c.PrecoTotal, 0)) AS TotalGeral
                        FROM comandas c
                        JOIN clientes cl ON c.ClienteID = cl.Id
                        WHERE cl.Ativo = 0   AND cl.Data = '{data}'";
            DataTable dados = conexao.Select(query);
            DataRow linhas = dados.Rows[0];

            double totalGeral = linhas["TotalGeral"] != DBNull.Value? Convert.ToDouble(linhas["TotalGeral"]) : 0;


            lblValorFinal.Text = totalGeral.ToString("C", new CultureInfo("pt-BR")); 


        }

        private void dtpDatasComandas_ValueChanged(object sender, EventArgs e)
        {
            string data = dtpDatasComandas.Value.Date.ToString("yyyy-MM-dd");
            CarregarClientesPorData(data);

            ValorTotalFinal(data);
        }
    }
}   
