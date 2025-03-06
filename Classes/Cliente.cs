using GerenciadorDeComandas.Banco;
using GerenciadorDeComandas.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeComandas
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private DateTime date;
        private int ativo;

        private List<Comanda> comandas;

        public string Nome { get => nome; set => nome = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Ativo { get => ativo; set => ativo = value; }
        public List<Comanda> Comandas { get => comandas; set => comandas = value; }

        public string CriarCliente()
        {
            ConexaoBanco conexao = new ConexaoBanco();

            string query = $"INSERT INTO clientes (Nome, Data, Ativo) VALUES ('{Nome}', '{Date.ToString("yyyy-MM-dd")}', {Ativo})";

            string retorno = conexao.ExecutarComando(query);

            return retorno;

        }

        public DataTable ClientesAtivos(int tamanhoPagina, int paginaAtual)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            string query = $@"
                SELECT *
                FROM clientes
                WHERE Ativo = 1
                ORDER BY Id ASC
                LIMIT {tamanhoPagina} OFFSET {paginaAtual * tamanhoPagina};";

            
            DataTable dados = conexao.Select(query);

            return dados;
        }

        public DataTable ClientesPorData(string data)
        {
            ConexaoBanco conexao = new ConexaoBanco();

            string query = $"SELECT * FROM clientes WHERE Data = '{data}';";
            DataTable dados = conexao.Select(query);

            return dados;
        }

        public DataTable ValorTotalComanda(string data)
        {
            ConexaoBanco conexao = new ConexaoBanco();

            string query = $@"SELECT SUM(COALESCE(c.PrecoTotal, 0)) AS TotalGeral
                        FROM comandas c
                        JOIN clientes cl ON c.ClienteID = cl.Id
                        WHERE cl.Ativo = 0 AND cl.Data = '{data}'";
            DataTable dados = conexao.Select(query);

            return dados;
        }
    }


}
