using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CadastrarCliente.Data
{
    internal static class Conexao
    {
        static MySqlConnection? _conexao;
        static string strconexao = "server=localhost;database=POO;uid=root;password=Yasmin_123";

        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(strconexao);
                _conexao.Open();
                Console.WriteLine("Conexão feita com sucesso!");
                return _conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar, tente novamente mais tarde." + ex.Message);
            }
        }
    }
}
