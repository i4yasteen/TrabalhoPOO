using CadastrarCliente.Data;
using CadastrarCliente.Interface;
using CadastrarCliente.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CadastrarCliente.Interface.IDAO1;

namespace CadastrarCliente.DAO
{
    internal class clienteDAO : IDAO<Cliente>
    {
        public void Salvar(Cliente cliente)
        {
            try
            {
                string sql = "INSERT INTO clientes (nome, cpf_cnpj, tipoCliente, desconto)" +
                    "VALUES (@nome, @cpf_cnpj, @tipoCliente, @desconto)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf_cnpj", cliente.CpfCnpj);
                comando.Parameters.AddWithValue("@tipoCliente", cliente.TipoCliente);
                comando.Parameters.AddWithValue("@desconto", cliente.Desconto);
                comando.ExecuteNonQuery();

                Console.WriteLine("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar o cliente, tente novamente.");
            }
        }
        public void Deletar(int id)
        {
            try
            {
                string sql = "DELETE FROM clientes WHERE" +
                    "Id_cliente = @id_cliente";

                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@id_cliente", id);
                command.ExecuteNonQuery();
                Console.WriteLine("O cliente foi deletado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o cliente, tente novamente mais tarde.");
            }
        }
        public void Atualizar(Cliente cliente)
        {
            try
            {
                string sql = "UPDATE clientes SET _nome = @nome, _cpfcnpj = @cpfcnpj, _tipoCliente = @tipoCliente, _desconto = @desconto" +
                    "WHERE Id_cliente = @id_cliente";

                MySqlCommand command = new MySqlCommand( sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@cpfcnpj", cliente.CpfCnpj);
                command.Parameters.AddWithValue("@tipoCliente", cliente.TipoCliente);
                command.Parameters.AddWithValue("@desconto", cliente.Desconto);

                Console.WriteLine("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o cliente.");
            }
        }
        public List<Cliente> ListarTodos()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();

                string sql = "SELECT * FROM clientes ORDER BY nome";
                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id_cliente = reader.GetInt32("Id_cliente");
                    cliente.Nome = reader.GetInt32("nome");
                    cliente.CpfCnpj = reader.GetInt32("cpf_cnpj");
                    cliente.TipoCliente = reader.GetInt32("tipoCliente");
                    cliente.Desconto = reader.GetInt32("desconto");
                    clientes.Add(cliente);
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

