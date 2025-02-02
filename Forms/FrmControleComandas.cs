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
        int tamanhoPagina = 32; 


        private void CarregarClientesAtivos()
        {
            panelComandasAbertas.Controls.Clear();

            Cliente cliente = new Cliente();

            DataTable dados = cliente.ClientesAtivos(tamanhoPagina, paginaAtual);
            
            foreach(DataRow comanda in dados.Rows)
            {
                int Id = Convert.ToInt32(comanda["Id"].ToString());
                string ativo = comanda["Ativo"].ToString();
                string nome = comanda["Nome"].ToString();
                string data = comanda["Data"].ToString();

                var userControlComanda = new UserControlComanda(Id, this);
                userControlComanda.SetComanda(nome, data, ativo);

                panelComandasAbertas.Controls.Add(userControlComanda);

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
            
            Cliente cliente = new Cliente();

            var dados = cliente.ClientesPorData(Data);

            foreach (DataRow comanda in dados.Rows)
            {
                int Id = Convert.ToInt32(comanda["Id"].ToString());
                string ativo = comanda["Ativo"].ToString();
                
                string nome = comanda["Nome"].ToString();
                string data = comanda["Data"].ToString();
                var userControlComanda = new UserControlComanda(Id, this);
                userControlComanda.SetComanda(nome, data, ativo);

                panelComandasFechadas.Controls.Add(userControlComanda);
            }
        }
        private void dtpDatasComandas_ValueChanged(object sender, EventArgs e)
        {
            string data = dtpDatasComandas.Value.Date.ToString("yyyy-MM-dd");
            CarregarClientesPorData(data);

            ValorTotalFinal(data);
        }

        private void ValorTotalFinal(string data)
        {
            Cliente cliente = new Cliente();
            DataTable dados =  cliente.ValorTotalComanda(data);
            DataRow linhas = dados.Rows[0];

            double totalGeral = linhas["TotalGeral"] != DBNull.Value? Convert.ToDouble(linhas["TotalGeral"]) : 0;

            lblValorFinal.Text = totalGeral.ToString("C", new CultureInfo("pt-BR")); 
        }

    }
}   
