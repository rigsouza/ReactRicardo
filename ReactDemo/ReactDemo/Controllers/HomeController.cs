using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ReactDemo.Models;
using ReactDemo.Negocios.Entidades;
using ReactDemo.Negocios.Componentes;
using System.Linq;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<Tarefa> _tarefas;

        static HomeController()
        {
            _tarefas = FabricaFluxo.Instancia.ObterTarefaFluxo().ObterTarefas().ToList();
        }

        public ActionResult Index()
        {
            return View(_tarefas);
        }

        [Route("tarefas")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Tarefas()
        {
            return Json(_tarefas);
        }

        [Route("tarefasFinalizadas")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult TarefasFinalizadas()
        {
            return Json(_tarefas.Where(f=>f.SituacaoTarefa == Comum.SituacaoTArefa.Finalizada));
        }

        [Route("tarefas/new")]
        [HttpPost]
        public ActionResult AddTarefa(Tarefa tarefa)
        {
            // Create a fake ID for this comment
            tarefa.SituacaoTarefa = Comum.SituacaoTArefa.Aberta;

            FabricaFluxo.Instancia.ObterTarefaFluxo().SalvarTarefa(tarefa);

            _tarefas.Add(tarefa);
            return Content("Success :)");
        }
    }
}