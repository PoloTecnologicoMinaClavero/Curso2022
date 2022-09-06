using IntroduccionMVC.Data;
using IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var ctx = new ApplicationDbContext();

            var usuarios = ctx.Users.ToList();

            List<UserViewModel> models = new List<UserViewModel>();

            foreach (var item in usuarios)
            {
                UserViewModel user = new UserViewModel()
                {
                    Id = item.Id,
                    UserName = item.UserName
                };

                models.Add(user);
            }

            return View(models);

            //Para devolver una vista especifica segun su nombre
            //return View("Ejemplo");

        }


        public IActionResult Detalle(string id)
        {
            var ctx = new ApplicationDbContext();

            var usuario = ctx.Users.FirstOrDefault(x => x.Id == id);

            UserViewModel model = new UserViewModel()
            {
                Id = usuario.Id,
                UserName = usuario.UserName
            };

            return View(model);

            //Para devolver una vista especifica segun su nombre
            //return View("Ejemplo");

        }
    }
}
