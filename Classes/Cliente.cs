using GerenciadorDeComandas.Banco;
using System;
using System.Collections.Generic;
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

        public string Nome { get => nome; set => nome = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Ativo { get => ativo; set => ativo = value; }

        public string CriarCliente()
        {
            ConexaoBanco conexao = new ConexaoBanco();

            string query = $"INSERT INTO clientes (Nome, Data, Ativo) VALUES ('{Nome}', '{Date.ToString("yyyy-MM-dd")}', {Ativo})";

            string retorno = conexao.ExecutarComando(query);

            return retorno;

        }
    }


}
