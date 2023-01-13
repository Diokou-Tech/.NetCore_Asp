using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Models
{
    public class User : IdentityUser
    {
        public int UserId { set; get; }
        [Required (ErrorMessage = "SVP Veuillez entre votre nom ! ")]
		[Display(Name = "Nom")]
		[StringLength(20)]
        public string? Nom { set; get; }
		[Required(ErrorMessage = "SVP Veuillez entre votre Prenom ! ")]
		[Display(Name = "Prenom")]
		[StringLength(50)]
		public string? Prenom { set; get; }
		[Required(ErrorMessage = "SVP Veuillez entre votre Adresse ! ")]
		[Display(Name = "Adresse Domicile")]
		[StringLength(250)]
		public string? Adresse { set; get; }
		[Required(ErrorMessage = "SVP Veuillez entre votre Email ! ")]
		[Display(Name = "Adresse Email")]
		[EmailAddress]
		public string? Email { set; get; }
		public List<Order>? Order { set; get; }

    }
}
