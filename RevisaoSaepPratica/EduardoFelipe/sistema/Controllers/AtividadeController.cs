using Microsoft.AspNetCore.Mvc;
using sistema.Contexts;
using sistema.Models;

namespace sistema.Controllers
{
    public class AtividadeController : Controller
    {
        private readonly SistemaContext _context;

        public AtividadeController(SistemaContext context)
        {
            _context = context;
        }

        public IActionResult Index(int turmaId)
        {

            var atividade = _context.Atividades.Where(x => x.TurmaId == turmaId).ToList();

            return View(atividade);
        }
    }
}
