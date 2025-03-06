using GerenciadorDeComandas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas
{
    public partial class UserControlComanda : UserControl
    {
        public int clienteId;
        string Nome;
        string Data;
        string Ativo;

        private FrmControleComandas controleComandas;

        public UserControlComanda(int Id, FrmControleComandas controleComandas)
        {
            InitializeComponent();
            this.clienteId = Id;
            this.controleComandas = controleComandas;


        }



        public void SetComanda(string Nome, String Data, string Ativo)
        {
            this.Nome = Nome;
            this.Data = Data;
            this.Ativo = Ativo;
            lblData.Text = Data;
            lblNome.Text = Nome;

            BackColorDinamica();
        }

        private void UserControlComanda_Load(object sender, EventArgs e)
        {

        }

        private void BackColorDinamica()
        {
            if (Ativo == "1")
            {
                this.BackColor = Color.Aqua;
            }

            if (Ativo == "0")
            {
                this.BackColor = Color.LightGreen;
            }
        }

        private void CarregarComanda()
        {
            if(Ativo == "1")
            {
                this.BackColor = Color.Aqua;


                FrmComanda comanda = new FrmComanda(clienteId, Nome, Data)
                {
                    Owner = controleComandas
                };
                comanda.ShowDialog();
            }

            if(Ativo == "0")
            {
                this.BackColor = Color.LightGreen;
                FrmComandaFechada comandaFechada = new FrmComandaFechada(clienteId, Nome, Data, controleComandas);
                comandaFechada.ShowDialog();
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            CarregarComanda();
        }

        private void lblData_Click(object sender, EventArgs e)
        {
            CarregarComanda();
        }

        private void UserControlComanda_MouseClick(object sender, MouseEventArgs e)
        {
            CarregarComanda();
        }
    }
}
