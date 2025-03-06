using CadastrarCliente.DAO;
using CadastrarCliente.Modelo;
using System;
using System.Collections.Generic;

public class Programm
{
    static void Main()
    {
        Cliente a = new Cliente();
        clienteDAO clienteDAO = new clienteDAO();
        clienteDAO.Salvar(a);

        Console.WriteLine("1 - Adicionar Cliente");
        Console.WriteLine("2 - Listar Clientes");
        Console.WriteLine("3 - Atualizar Cliente");
        Console.WriteLine("4 - Remover Cliente");
        Console.Write("Escolha uma opção: ");
        int opMenu = 0;

        switch (opMenu)
        {
            case 1:
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("CPF/CNPJ: ");
                string cpfCnpj = Console.ReadLine();

                Console.Write("Tipo (Física/Jurídica): ");
                string tipo = Console.ReadLine().ToLower();

                decimal desconto = (tipo == "juridica") ? 5 : 0;
                Cliente novoCliente = new Cliente(nome, cpfCnpj, tipo, desconto);

                clienteDAO.Salvar(a);
                Console.WriteLine("Cliente adicionado!");
                break;

            case 2:
                Console.Write("Digite o ID do cliente para atualizar: ");
                a.Id_cliente = Convert.ToInt32(Console.ReadLine());
                
                clienteDAO.Atualizar(a);
                break;

            case 3:
                Console.Write("Digite o ID do cliente para remover: ");
                a.Id_cliente = Convert.ToInt32(Console.ReadLine());

                int af = Console.Read();
                clienteDAO.Deletar(a);
                Console.WriteLine("Cliente removido!");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}