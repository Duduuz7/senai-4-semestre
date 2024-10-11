using Microsoft.AspNetCore.Mvc;
using sistema.Contexts;

namespace sistema.Controllers
{
    public class LoginController : Controller
    {
        private readonly SistemaContext _context;

        public LoginController(SistemaContext context)
        {
           _context = context; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logar(string email, string senha) 
        {
            var professor = _context.Professors.FirstOrDefault(p => p.Email == email && p.Senha == senha);

            if (professor != null)
            {
                HttpContext.Session.SetInt32("ProfessorId", professor.ProfessorId);

                HttpContext.Session.SetString("Nome", professor.Nome!);

                return RedirectToAction("Index", "Professor");
            }


            TempData["Mensagem"] = "Email ou senha incorretos !!!";

            return RedirectToAction("Index", "Login");

        }
    }
}
