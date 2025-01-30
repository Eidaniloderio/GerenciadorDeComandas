using GerenciadorDeComandas.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GerenciadorDeComandas.Banco
{
    internal class ConexaoBanco
    {

        static string caminho = AppDomain.CurrentDomain.BaseDirectory;
        string connectionString = $"Data Source={caminho}\\Banco\\BancoComandas.db;Version=3;";

        SQLiteConnection conexao;
        SQLiteCommand comando;


        public ConexaoBanco() 
        { 
            conexao = new SQLiteConnection(connectionString);
            conexao.Open();

            comando = conexao.CreateCommand();

            IniciarTabelas();
        }

        private void IniciarTabelas()
        {
            string query = @"
            -- Tabela 'clientes'
            CREATE TABLE IF NOT EXISTS clientes (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                Data DATE NOT NULL,
                Ativo INTEGER NOT NULL DEFAULT 1
            );

            -- Tabela 'produtos'
            CREATE TABLE IF NOT EXISTS produtos (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                PrecoUnid REAL NOT NULL
            );

            -- Tabela 'comandas'
            CREATE TABLE IF NOT EXISTS comandas (
                ComandaId INTEGER PRIMARY KEY AUTOINCREMENT,
                ClienteID INTEGER NOT NULL,
                ProdutoID INTEGER NOT NULL,
                Quantidade INTEGER NOT NULL DEFAULT 0,
                PrecoTotal REAL NOT NULL DEFAULT 0,
                UNIQUE (ClienteID, ProdutoID)

                FOREIGN KEY (ClienteID) REFERENCES clientes (Id) ON DELETE CASCADE,
                FOREIGN KEY (ProdutoID) REFERENCES produtos (Id) ON DELETE CASCADE
            ); 

            INSERT OR IGNORE INTO produtos (Id, Nome, PrecoUnid)
                VALUES
                (1001, 'Heineken', 16.00),
                (1002, 'Original', 15.00),
                (1003, 'Brahma', 12.00),
                (1004, 'Skol', 12.00),
                (1005, 'Amstel', 12.00),
                (1006, 'Petra', 10.00),
                (1007, 'Itaipava litrão', 10.00),
                (1009, 'Antartica (boa)', 12.00),
                (1010, 'Latas', 5.50),
                (2001, 'Caipirinha', 15.00),
                (2002, 'Refrigerante', 5.50),
                (2003, 'Refrigerante 2l', 10.00),
                (2004, 'Coca-cola 2l', 15.00),
                (3001, 'Batata', 25.00),
                (3002, 'Calabresa acebolada', 30.00),
                (3003, 'Frango empanado', 35.00),
                (3004, 'Filé de tilápia', 50.00),
                (3005, 'Filé com fritas', 70.00),
                (4001, 'Aluguel kiosk', 100.00),
                (4002, 'Carvão', 20.00),
                (4003, 'Gelo 5kg', 15.00),
                (4004, 'Salgadinho', 4.00),
                (4005, 'Doce', 3.00),
                (4006, 'Bala Halls', 2.50);";

            comando.CommandText = query;

            comando.ExecuteNonQuery();

        }

        public string ExecutarComando(string pComando)
        {   
            comando.CommandText = pComando;

            try
            {
                comando.ExecuteNonQuery();
                conexao.Close();

                return "";
            }
            catch (Exception ex) 
            {
                   return ex.Message;
            }
        }

        public DataTable Select(string query)
        {
            DataTable dt = new DataTable();
            comando.CommandText = query;

            SQLiteDataAdapter adpter = new SQLiteDataAdapter(comando);
            adpter.Fill(dt); 

            return dt;
        } 

        public DataTable SelectProdutos(int Id)
        {
            DataTable dt = new DataTable();

            // Usando parâmetros em vez de interpolação de string
            comando.CommandText = @"
                SELECT 
                    p.Id AS ProdutoID, 
                    p.Nome AS ProdutoNome, 
                    p.PrecoUnid AS PrecoUnitario, 
                    COALESCE(c.Quantidade, 0) AS Quantidade, 
                    COALESCE(c.PrecoTotal, 0) AS PrecoTotal
                FROM 
                    produtos p
                LEFT JOIN 
                    comandas c ON p.Id = c.ProdutoID AND c.ClienteID = @ClienteID;
            ";


            // Adicionando o parâmetro
            comando.Parameters.AddWithValue("@ClienteID", Id);

            // Preenchendo o DataTable
            SQLiteDataAdapter adpter = new SQLiteDataAdapter(comando);
            adpter.Fill(dt);

            return dt;
        }

        public DataTable SelectProdutosQuantidade(int Id)
        {
            DataTable dt = new DataTable();

            string query = $@"
            SELECT 
                c.ProdutoID,
                p.Nome AS ProdutoNome,
                p.PrecoUnid AS PrecoUnitario,
                c.Quantidade,
                c.PrecoTotal
            FROM 
                comandas c
            JOIN 
                produtos p ON c.ProdutoID = p.Id
            WHERE 
                c.ClienteID = {Id} AND c.Quantidade > 0;";


            comando.CommandText = query;
            SQLiteDataAdapter adpter = new SQLiteDataAdapter(comando);
            adpter.Fill(dt);

            return dt;
        }

    }
}
