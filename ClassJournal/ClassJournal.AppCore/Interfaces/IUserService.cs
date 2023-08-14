using ClassJournal.AppCore.Models;

namespace ClassJournal.AppCore.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserModel> GetAll();
        UserModel Get(int id);
        void Add(UserModel entity);
        void Update(UserModel dbEntity, UserModel entity);
        void Delete(UserModel entity);
    }
}