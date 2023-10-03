using Actividad_1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Actividad_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            IndexViewModel vm = new()
            {
                NombreMateria = "Programación web",
                Nombre = "David Ailton Gonzalez",
                Periodo = "Agosto - Diciembtre 2023",
                Semestre = "Noveno",
            };
            return View(vm);
        }

        public IActionResult Perfil()
        {
            PerfilViewModel vm = new()
            {
                Nombre = "David Ailton",
                Apellido = "Gonzalez",
                NumeroControl = "191G0251",
                Semestre = "Noveno",
                Carrera = "Ing. Sistemas Computacionales",
                Telefono = "8641005790"
            };
            return View(vm);
        }
    }
}
