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
            var turma = _context.Turmas.FirstOrDefault(x => x.TurmaId == turmaId);

            int? professorId = HttpContext.Session.GetInt32("ProfessorId");

            if (professorId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var professor = _context.Professors.Find(professorId);

            ViewBag.NomeProfessor = professor!.Nome;
             

            ViewBag.NomeTurma = turma!.Nome;
            ViewBag.TurmaId = turmaId;

            var atividade = _context.Atividades.Where(x => x.TurmaId == turmaId).ToList();

            return View(atividade);
        }

        [HttpPost]
        public IActionResult CadastrarAtividade(string nomeAtividade, int turmaId)
        {
            var turma = _context.Turmas.FirstOrDefault(t => t.TurmaId == turmaId);

            if (turma == null)
            {
                return View();
            }

            var novaAtividade = new Atividade
            {
                TurmaId = turmaId,
                Descricao = nomeAtividade
            };

            _context.Atividades.Add(novaAtividade);

            _context.SaveChanges();

            return RedirectToAction("Index", "Atividade", new {turmaId});
        }
    }
}
