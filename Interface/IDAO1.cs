
namespace CadastrarCliente.Interface
{
    public interface IDAO1<T>
    {
        void Adicionar(T obj);
        void Atualizar(T obj);
        T BuscarPorId(int id);
        List<T> ListarTodos();
        void Remover(T obj);
    }
}