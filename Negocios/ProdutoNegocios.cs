using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ProdutoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Nome", produto.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", produto.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Preco", produto.Preco);
                acessoDadosSqlServer.AdicionarParametros("@Estoque", produto.Estoque);

                string IdProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spProdutoInserir").ToString();

                return IdProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Atualizar(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", produto.IdProduto);
                acessoDadosSqlServer.AdicionarParametros("@Nome", produto.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", produto.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Preco", Convert.ToDecimal(produto.Preco));
                acessoDadosSqlServer.AdicionarParametros("@Estoque", Convert.ToInt32(produto.Estoque));

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spProdutoAlterar").ToString();

                return produto.IdProduto.ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idProduto", produto.IdProduto);
                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spProdutoExcluir").ToString();

                return produto.IdProduto.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ProdutoCollection ConsultarPorNome(string nome)
        {
            try
            {
                ProdutoCollection produtoColecao = new ProdutoCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spProdutoConsultarPorNome");

                foreach (DataRow row in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(row["IdProduto"]);
                    produto.Nome = Convert.ToString(row["Nome"]);
                    produto.Descricao = Convert.ToString(row["Descricao"]);
                    produto.Preco = Convert.ToString(row["Preco"]);
                    produto.Estoque = Convert.ToString(row["Estoque"]);

                    produtoColecao.Add(produto);
                }

                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o produto por nome. Detalhes:" + ex.Message);
            }
        }

        public ProdutoCollection ConsultarPorId(int id)
        {
            try
            {
                ProdutoCollection produtoColecao = new ProdutoCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idProduto", id);
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spProdutoConsultarPorID");

                foreach (DataRow row in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(row["IdProduto"]);
                    produto.Nome = Convert.ToString(row["Nome"]);
                    produto.Descricao = Convert.ToString(row["Descricao"]);
                    produto.Preco = Convert.ToString(row["Preco"]);
                    produto.Estoque = Convert.ToString(row["Estoque"]);

                    produtoColecao.Add(produto);
                }

                return produtoColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o produto por código. Detalhes:" + ex.Message);
            }
        }

        public string ConsultarDerscricao(int id)
        {
            try
            {
                ProdutoCollection produtoColecao = new ProdutoCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idProduto", id);
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spProdutoConsultarPorId");

                string descricaoProduto = string.Empty;

                foreach (DataRow row in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(row["idProduto"]);
                    produto.Nome = Convert.ToString(row["Nome"]);
                    produto.Descricao = Convert.ToString(row["Descricao"]);
                    produto.Preco = Convert.ToString(row["Preco"]);
                    produto.Estoque = Convert.ToString(row["Estoque"]);

                    produtoColecao.Add(produto);

                    descricaoProduto = produto.Descricao;
                }

                return descricaoProduto;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o produto pelo código. Detalhes:" + ex.Message);
            }
        }

        public string ConsultarEstoquePorId(int id)
        {
            try
            {
                ProdutoCollection produtoColecao = new ProdutoCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idProduto", id);
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spProdutoConsultarPorId");

                string estoqueProduto = string.Empty;  

                foreach (DataRow row in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(row["idProduto"]);
                    produto.Nome = Convert.ToString(row["Nome"]);
                    produto.Descricao = Convert.ToString(row["Descricao"]);
                    produto.Preco = Convert.ToString(row["Preco"]);
                    produto.Estoque = Convert.ToString(row["Estoque"]);

                    produtoColecao.Add(produto);

                    estoqueProduto = produto.Estoque.ToString();
                }

                return estoqueProduto;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o estoqye do produto. Detalhes:" + ex.Message);
            }
        }

        public ProdutoCollection ConsultarTodos()
        {
            try
            {
                ProdutoCollection produtoColecao = new ProdutoCollection();

                acessoDadosSqlServer.LimparParametros();
                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spProdutoConsultarTodos");

                foreach (DataRow row in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(row["idProduto"]);
                    produto.Nome = Convert.ToString(row["Nome"]);
                    produto.Descricao = Convert.ToString(row["Descricao"]);
                    produto.Preco = Convert.ToString(row["Preco"]);
                    produto.Estoque = Convert.ToString(row["Estoque"]);

                    produtoColecao.Add(produto);
                }

                return produtoColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os produtos. Detalhes:" + ex.Message);
            }
        }

    }
}
