using ClassJournal.AppCore.Models;

namespace ClassJournal.AppCore.Interfaces
{
    public interface IUserHandler
    {
        LoginResult Login(LoginCredentials credentials);
    }
}