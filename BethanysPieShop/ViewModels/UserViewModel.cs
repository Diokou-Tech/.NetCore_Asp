using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
	public class UserViewModel
	{
		public IEnumerable<User> Users { get; set; }

		public UserViewModel(IEnumerable<User> users)
		{
			Users = users;
		}
	}
}
