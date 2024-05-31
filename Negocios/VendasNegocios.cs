using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Negocios
{
    public class VendasNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Vendas vendas)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Cliente", vendas.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@Produto", vendas.IdProduto);
                acessoDadosSqlServer.AdicionarParametros("@Quantidade", vendas.Quantidade);

                string IdVendas = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spVendasInserir").ToString();

                return IdVendas;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Atualizar(Vendas vendas)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdVendas", vendas.IdVenda);
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", vendas.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", vendas.IdProduto);
                acessoDadosSqlServer.AdicionarParametros("@Quantidade", vendas.Quantidade);

                string IdVendas = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spVendasAlterar").ToString();

                return IdVendas;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Vendas vendas)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdVenda", vendas.IdVenda);
                string IdVenda = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spVendasExcluir").ToString();

                return IdVenda;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public VendasCollection ConsultarPorNome(string nome)
        {
            /*
            try
            {
                VendasCollection vendasColecao = new VendasCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                DataTable dataTableVendas = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spVendasConsultarPorNome");

                foreach (DataRow row in dataTableVendas.Rows)
                {
                    Vendas vendas = new Vendas();
                    vendas.IdVenda = Convert.ToInt32(row["IdVenda"]);
                    vendas.IdCliente = Convert.ToInt32(row["IdCliente"]);
                    vendas.IdProduto = Convert.ToInt32(row["IdProduto"]);
                    vendas.Quantidade = int.Parse(row["Quantidade"]);

                    vendasColecao.Add(vendas);
                }

                return vendasColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a venda por nome. Detalhes:" + ex.Message);
            }
            */

            VendasCollection vendasColecao = new VendasCollection();
            return vendasColecao;
        }

        public VendasCollection ConsultarPorId(int id)
        {
            /*
            try
            {
                VendasCollection vendasColecao = new VendasCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idVenda", id);
                DataTable dataTableVendas = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spVendasConsultarPorID");

                foreach (DataRow row in dataTableVendas.Rows)
                {
                    Vendas vendas = new Vendas();
                    vendas.IdVenda = Convert.ToInt32(row["IdVenda"]);
                    vendas.IdCliente = Convert.ToInt32(row["IdCliente"]);
                    vendas.IdProduto = Convert.ToInt32(row["IdProduto"]);
                    vendas.Quantidade = int.Parse(row["Quantidade"]);


                    vendasColecao.Add(vendas);
                }

                return vendasColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a venda por código. Detalhes:" + ex.Message);
            }
            */

            VendasCollection vendasColecao = new VendasCollection();
            return vendasColecao;

        }

        public VendasCollection ConsultarTodas()
        {
            try
            {
                VendasCollection vendasColecao = new VendasCollection();

                acessoDadosSqlServer.LimparParametros();
                DataTable dataTableVendas = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spVendasConsultarTodas");

                foreach (DataRow row in dataTableVendas.Rows)
                {
                    Vendas vendas = new Vendas();
                    vendas.IdVenda = Convert.ToInt32(row[0]);
                    vendas.IdCliente = Convert.ToInt32(row[1]);
                    vendas.Cliente = Convert.ToString(row[2]);
                    vendas.IdProduto = Convert.ToInt32(row[3]);
                    vendas.Produto = Convert.ToString(row[4]);
                    vendas.Quantidade = Convert.ToInt32(row[5]);

                    vendasColecao.Add(vendas);
                }

                return vendasColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as vendas. Detalhes:" + ex.Message);
            }
        }
    }
}
