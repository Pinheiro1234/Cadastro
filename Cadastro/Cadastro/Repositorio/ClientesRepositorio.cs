using Cadastro.Data;
using Cadastro.Models;

namespace Cadastro.Repositorio
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly BancoContex _bancoContex;
        public ClientesRepositorio(BancoContex bancoContex)
        {
            _bancoContex = bancoContex;
        }
        public ContatoModel ListarPorId(int Id)
        {
            return _bancoContex.Clientes.FirstOrDefault(x => x.id == Id);

        }
        public List<ContatoModel> BuscarTodos()
        {
           return _bancoContex.Clientes.ToList();
        }
        public ContatoModel Adicionar(ContatoModel cliente)
        {
            _bancoContex.Clientes.Add(cliente);
            _bancoContex.SaveChanges();
            return cliente;
        }

        public ContatoModel Atualizar(ContatoModel cliente)
        {
            ContatoModel clienteDB = ListarPorId(cliente.id);

            if (clienteDB == null) throw new Exception("Houve um erro na atualização do contato!");
            clienteDB.Nome = cliente.Nome;
            clienteDB.Email = cliente.Email;
            clienteDB.Celular = cliente.Celular;

            _bancoContex.Clientes.Update(clienteDB);
            _bancoContex.SaveChanges();
            return clienteDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel clienteDB = ListarPorId(id);

            if (clienteDB == null) throw new Exception("Houve um erro na Deleção do contato!");

            _bancoContex.Clientes.Remove(clienteDB);
            _bancoContex.SaveChanges();

            return true;
        }
    }
}
