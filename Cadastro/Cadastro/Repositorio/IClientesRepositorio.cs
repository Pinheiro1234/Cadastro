using Cadastro.Models;

namespace Cadastro.Repositorio
{
    public interface IClientesRepositorio
    {
        ContatoModel ListarPorId(int id);   
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel cliente);
        ContatoModel Atualizar(ContatoModel cliente);
        bool Apagar(int id);
    }
}
