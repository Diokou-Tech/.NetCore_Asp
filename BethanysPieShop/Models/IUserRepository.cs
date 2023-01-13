namespace BethanysPieShop.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        void Add(User user);
        void Remove(int id);
        void Update(User user);
    }
}