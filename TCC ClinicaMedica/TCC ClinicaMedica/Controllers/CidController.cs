using Servicos.Contratos;
using System.Web.Mvc;
using TCC_ClinicaMedica.Infrastructure.Mapeadores.Cid;
using TCC_ClinicaMedica.Models;

namespace TCC_ClinicaMedica.Controllers
{
    public class CidController : Controller
    {
		private readonly ICidService _cidService;
        private readonly ICidMapeador _cidMapeador;

        public CidController(ICidService cidService, ICidMapeador cidMapeador)
        {
            _cidService = cidService;
            _cidMapeador = cidMapeador;
        }

        public ActionResult Listar()
        {
            return View(_cidMapeador.Map(_cidService.Listar()));
        }

        public ActionResult Incluir()
        {
            return View(new CidViewModel());
        }

        [HttpPost]
        public JsonResult Incluir(CidViewModel cidViewModel)
        {
            return Json(new
            {
                resultado = _cidService.Incluir(_cidMapeador.Map(cidViewModel), out var mensagem),
                mensagem
            });
        }

        [HttpPost]
        public JsonResult Alterar(CidViewModel cidViewModel)
        {
            return Json(new
            {
                resultado = _cidService.Alterar(_cidMapeador.Map(cidViewModel), out var mensagem),
                mensagem
            });
        }

        public ActionResult Alterar(int codigoCid)
        {
            return View(_cidMapeador.Map(_cidService.Buscar(codigoCid)));
        }

        [HttpPost]
        public JsonResult Excluir(int codigoCid)
        {
            var resultado = _cidService.Excluir(codigoCid, out var mensagem);
            return Json(new { resultado, mensagem });
        }
    }
}
