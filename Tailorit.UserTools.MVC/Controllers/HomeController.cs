using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Linq;
using Tailorit.UserTools.MVC.Models;
using Tailorit.UserTools.MVC.Utils;
using TailorIT.UserTools.Domain.Entities;
using TailorIT.UserTools.Domain.Repositories;

namespace Tailorit.UserTools.MVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
            => _userRepository = userRepository;


        [HttpGet("usuario/lista")]
        public IActionResult GetAllUser()
        {
            var users = _userRepository.GetAllUsers().Select(c => new UserViewModel
            {
                Name = c.Name,
                BirthDate = c.BirthDate,
                Email = c.Email,
               // DescriptionSexo = c.IdSexo == 1 ? "Masculino" : "Feminino",
                DescriptionActive = c.Active ? "Sim" : "Não"

            });

            return View(users);
        }

        [HttpPost("usuario/lista")]
        public IActionResult GetAllUser(string name, string ativo)
        {
            var users = _userRepository.GetUserbyName(name, ativo == "Sim" ? true : false).Select(c => new UserViewModel
            {
                Name = c.Name,
                BirthDate = c.BirthDate,
                Email = c.Email,
               // DescriptionSexo = c.IdSexo == 1 ? "Masculino" : "Feminino",
                DescriptionActive = c.Active ? "Sim" : "Não"

            });

            return View(users);
        }

        [HttpGet("usuario/novoUsuario")]
        public IActionResult AddUser()
        {
            ViewBag.Sexo = new SelectList(Constants.Sexo(), "IdSexo", "DescriptionSexo");
            return View();
        }

        [HttpPost("usuario/novoUsuario")]
        public IActionResult AddUser(UserViewModel user)
        {
            if (ModelState.IsValid)
            {

                if (user.ValidatePassword())
                {
                    _userRepository.AddUser(new User
                    {
                        Name = user.Name,
                        BirthDate = user.BirthDate,
                        Email = user.Email,
                       // IdSexo = user.IdSexo,
                        Active = user.Active,
                        Senha = user.Password

                    });

                    return RedirectToAction(nameof(GetAllUser));
                }

                ViewBag.ErrorPassword = Constants.validatePassword;
                ViewBag.Sexo = new SelectList(Constants.Sexo(), "IdSexo", "DescriptionSexo");
            }

            return  View(nameof(AddUser));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            return View();
        }





    }


}
