using GerenciadorContatos.Models;
using GerenciadorContatos.Repositorio.Contratos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GerenciadorContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            this._contatoRepositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
            var contatos = this._contatoRepositorio.Buscar();

            return View(contatos);
        }


        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Cadastro(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                ViewData["MSG_S"] = "Contato cadastrado!";

                return RedirectToAction(nameof(Index));
            }

            ViewData["MSG_E"] = ModelState.Values;
            return View();

        }


        [HttpGet]
        public IActionResult Edicao(Contato contato)
        {
            return View(contato);
        }

        [HttpPost]
        public IActionResult EdicaoPost([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                //Fazer Edicao
                _contatoRepositorio.Atualizar(contato);
                TempData["MSG_S"] = "Contato editado!";

                return RedirectToAction(nameof(Index));
            }

            ViewData["MSG_E"] = "Erro ao editar o contato, revise os campos";
            return View(nameof(Edicao));
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            _contatoRepositorio.Excluir(id);
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
