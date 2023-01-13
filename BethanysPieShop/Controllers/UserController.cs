using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var data = _repo.GetAll();
            var userView = new UserViewModel(data);
            return View(userView);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
            _repo.Add(user);
            ViewBag.User = user;
            ViewBag.message = "Ajout d'un nouveau utilisateur avec succès !";
            return RedirectToAction("Success");
            }
            return View(user);
		}
        public IActionResult Remove(int id)
        {
            _repo.Remove(id);
			ViewBag.message = "Suppression d'un  utilisateur avec succès !";
			return RedirectToAction("Success");
		}
        public IActionResult Success()
        {
            return View();
        }
    }
}
