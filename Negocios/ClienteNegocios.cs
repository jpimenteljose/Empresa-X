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
    public class ClienteNegocios
    {
        //Instanciar - Criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Cliente cliente)
        {
            try
            { 
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Cpf", cliente.Cpf);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", cliente.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Endereco", cliente.Endereco);
                acessoDadosSqlServer.AdicionarParametros("@Email", cliente.Email);

                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spClienteInserir").ToString();

                return idCliente;

            }catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Atualizar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Cpf", cliente.Cpf);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", cliente.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Endereco", cliente.Endereco);
                acessoDadosSqlServer.AdicionarParametros("@Email", cliente.Email);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spClienteAlterar").ToString();

                return cliente.IdCliente.ToString();

            }catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spClienteExcluir");

                return cliente.IdCliente.ToString();
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

       public ClienteCollection ConsultarPorNome(string nome)
       {
            try
            {
                ClienteCollection clienteColecao = new ClienteCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spClienteConsultarPorNome");

                foreach(DataRow row in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(row["IdCliente"]);
                    cliente.Nome = Convert.ToString(row["Nome"]);
                    cliente.Cpf= Convert.ToString(row["Cpf"]);
                    cliente.Telefone = Convert.ToString(row["Telefone"]);
                    cliente.Endereco = Convert.ToString(row["Endereco"]);
                    cliente.Email = Convert.ToString(row["Email"]);

                    clienteColecao.Add(cliente);
                }


                return clienteColecao;
            }catch(Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por nome. Detalhes:" + ex.Message);
            }
       }
   
        
       public ClienteCollection ConsultarPorId(int id)
       {
            try
            {
                ClienteCollection clienteColecao = new ClienteCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idCliente", id);
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spClienteConsultarPorID");

                foreach (DataRow row in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(row["idCliente"]);
                    cliente.Nome = Convert.ToString(row["Nome"]);
                    cliente.Cpf = Convert.ToString(row["Cpf"]);
                    cliente.Telefone = Convert.ToString(row["Telefone"]);
                    cliente.Endereco = Convert.ToString(row["Endereco"]);
                    cliente.Email = Convert.ToString(row["Email"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;

            }catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por código. Detalhes:" + ex.Message);
            }
       }

        public string ConsultarNome(int id)
        {
            try
            {
                ClienteCollection clienteColecao = new ClienteCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idCliente", id);
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spClienteConsultarPorID");

                string nomeCliente = string.Empty;

                foreach (DataRow row in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(row["idCliente"]);
                    cliente.Nome = Convert.ToString(row["Nome"]);
                    cliente.Cpf = Convert.ToString(row["Cpf"]);
                    cliente.Telefone = Convert.ToString(row["Telefone"]);
                    cliente.Endereco = Convert.ToString(row["Endereco"]);
                    cliente.Email = Convert.ToString(row["Email"]);

                    clienteColecao.Add(cliente);

                    nomeCliente = cliente.Nome;
                }

                return nomeCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente pelo código. Detalhes:" + ex.Message);
            }
        }

        public ClienteCollection ConsultarTodos()
        {
            try
            {
                ClienteCollection clienteColecao = new ClienteCollection();

                acessoDadosSqlServer.LimparParametros();
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "spClienteConsultarTodos");

                foreach (DataRow row in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(row["idCliente"]);
                    cliente.Nome = Convert.ToString(row["Nome"]);
                    cliente.Cpf = Convert.ToString(row["Cpf"]);
                    cliente.Telefone = Convert.ToString(row["Telefone"]);
                    cliente.Endereco = Convert.ToString(row["Endereco"]);
                    cliente.Email = Convert.ToString(row["Email"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os clientes. Detalhes:" + ex.Message);
            }
        }
    }
}
