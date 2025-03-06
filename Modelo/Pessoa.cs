using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarCliente.Modelo
{
    internal class Pessoa
    {
        public class Pessoas
        {
            public int Id_cliente { get; set; }
            public string Nome { get; set; }
            public string CpfCnpj { get; set; }

            public Pessoas(string nome, string cpfCnpj)
            {
                Nome = nome;
                CpfCnpj = cpfCnpj;
            }

            public virtual void ExibirDados()
            {
                Console.WriteLine($"Nome: {Nome} | CPF/CNPJ: {CpfCnpj}");
            }
        }
    }
}
