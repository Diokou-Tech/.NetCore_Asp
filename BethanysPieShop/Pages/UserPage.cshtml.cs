using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BethanysPieShop.Pages
{
    public class UserPageModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        private readonly IUserRepository _repo;

        public UserPageModel(IUserRepository repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
             Page();
        }
        public IActionResult OnPost(User user)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(user);
                return RedirectToPage("SuccessPage");
            }
            return Page();
        }
    }
}
