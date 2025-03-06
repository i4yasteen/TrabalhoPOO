using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarCliente.Interface
{
    internal class IDAO1
    {
        public interface IDAO<Cliente>
        {
            void Salvar(Cliente entidade);
            void Deletar(int id);
            void Atualizar(Cliente entidade);

            List<Cliente> ListarTodos();
        }
    }
}
