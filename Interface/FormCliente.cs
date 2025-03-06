using CadastrarCliente.DAO;
using CadastrarCliente.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarCliente.Interface
{
    internal class FormCliente
    {
        public partial class FormCliente : Form
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            public FormCliente()
            {
                InitializeComponent();
                AtualizarLista();
            }

            private void btnAdicionar_Click(object sender, EventArgs e)
            {
                string nome = txtNome.Text;
                string cpfCnpj = txtCpfCnpj.Text;
                string tipo = cbTipoCliente.SelectedItem.ToString().ToLower();
                decimal desconto = (tipo == "juridica") ? 5 : 0;

                Cliente cliente = new Cliente(nome, cpfCnpj, tipo, desconto);
                clienteDAO.Adicionar(cliente);

                MessageBox.Show("Cliente adicionado!");
                AtualizarLista();
            }

            private void btnRemover_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(txtId.Text);
                clienteDAO.Remover(id);
                MessageBox.Show("Cliente removido!");
                AtualizarLista();
            }

            private void btnAtualizar_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(txtId.Text);
                Cliente cliente = clienteDAO.BuscarPorId(id);

                if (cliente != null)
                {
                    cliente.Nome = txtNome.Text;
                    cliente.CpfCnpj = txtCpfCnpj.Text;
                    clienteDAO.Atualizar(cliente);
                    MessageBox.Show("Cliente atualizado!");
                    AtualizarLista();
                }
            }

            private void AtualizarLista()
            {
                dgvClientes.DataSource = clienteDAO.ListarTodos();
            }
        }
    }
}
