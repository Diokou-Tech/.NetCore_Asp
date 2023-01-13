using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BethanysPieShop.Pages
{
    public class SuccessPageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Ajout avec succès";
        }
    }
}
