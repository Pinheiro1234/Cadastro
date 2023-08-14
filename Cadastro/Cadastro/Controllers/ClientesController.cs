using Cadastro.Models;
using Cadastro.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientesRepositorio _clientesRepositorio;
        public ClientesController(IClientesRepositorio clientesRepositorio)
        {
            _clientesRepositorio = clientesRepositorio;
        }

        public IActionResult Index()
        {   
            var clientes = _clientesRepositorio.BuscarTodos();
            return View(clientes);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
          ContatoModel cliente =   _clientesRepositorio.ListarPorId(id);
            return View(cliente);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel cliente = _clientesRepositorio.ListarPorId(id);
            return View(cliente);
        }
        public IActionResult Apagar(int id)
        {
            _clientesRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel cliente)
        {
            if (ModelState.IsValid)
            {
                _clientesRepositorio.Adicionar(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
          
        }
        [HttpPost]
        public IActionResult Alterar(ContatoModel cliente)
        {
            _clientesRepositorio.Atualizar(cliente);
            return RedirectToAction("Index");
        }


    }
}
