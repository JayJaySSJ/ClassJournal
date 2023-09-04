using ClassJournal.AppCore.Models;

namespace ClassJournal.AppCore.RepositoryDependencies
{
    public interface IUserRepository : IRepositoryBase<UserModel>
    {
        UserModel Get(string email);
    }
}