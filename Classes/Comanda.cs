using GerenciadorDeComandas.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeComandas.Classes
{
    internal class Comanda
    {
        private int clienteId;
        private int produtoId;
        private int quantidade;
        private double valorTotal;

        public int ClienteId { get => clienteId; set => clienteId = value; }
        public int ProdutoId { get => produtoId; set => produtoId = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }


        public void SalvarProdutosComandas(List<Comanda> ProdutosPorComanda)
        {
            
            foreach(Comanda comanda in ProdutosPorComanda)
            {
                ConexaoBanco conexao = new ConexaoBanco();
                string query = $@"
                                INSERT INTO comandas (ClienteID, ProdutoID, Quantidade, PrecoTotal) 
                                VALUES ({comanda.clienteId}, {comanda.produtoId}, {comanda.quantidade}, {comanda.valorTotal.ToString().Replace(",", ".")}) 
                                ON CONFLICT(ClienteID, ProdutoID) DO UPDATE 
                                SET Quantidade = {comanda.quantidade}, PrecoTotal = {comanda.valorTotal.ToString().Replace(",", ".")}";
                conexao.ExecutarComando(query);
            }

        }
    }
}
