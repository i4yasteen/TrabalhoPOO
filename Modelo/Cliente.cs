using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarCliente.Modelo
{
    internal class Cliente
    {
        public object Id_cliente {  get; internal set; }
        public object Nome { get; internal set; }
        public object CpfCnpj { get; internal set; }
        public object TipoCliente { get; internal set; }
        public object Desconto { get; internal set; }

        public class Clientes : Pessoa
        {
            public string TipoCliente { get; set; } // Pessoa Física ou Jurídica
            public decimal Desconto { get; set; }

            public Clientes(string nome, string cpfCnpj, string tipoCliente, decimal desconto)
            {
                TipoCliente = tipoCliente;
                Desconto = desconto;
            }

            public virtual void ExibirDados()
            {
                ExibirDados();
                Console.WriteLine($"Tipo: {TipoCliente} | Desconto: {Desconto}%");
            }
        }
    }
}
