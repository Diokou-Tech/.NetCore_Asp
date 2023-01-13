namespace BethanysPieShop.Models
{
    public class UserRepository : IUserRepository
    {
        BethanysPieShopDbContext _context;

        public UserRepository(BethanysPieShopDbContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
           _context.Users.Add(user);
            _context.SaveChanges();
        }
        public IEnumerable<User> GetAll()
        {
            return _context.Users.OrderBy(u => u.Nom);

        }

        public void Remove(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId== id);
            if (user != null)
            {
           _context.Users.Remove(user);
            }
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
