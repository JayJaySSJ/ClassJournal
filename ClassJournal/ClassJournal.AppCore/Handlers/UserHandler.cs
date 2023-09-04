using ClassJournal.AppCore.Interfaces;
using ClassJournal.AppCore.Models;

namespace ClassJournal.AppCore.Handlers
{
    internal class UserHandler : IUserHandler
    {
        private IUserService _userService;

        public UserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public LoginResult Login(LoginCredentials credentials)
        {
            var user = _userService.Get(credentials.Email);

            if (user == null || user.Password != credentials.Password)
            {
                return new LoginResult()
                {
                    User = null,
                    Message = "There is no such user in database",
                    IsSuccess = false,
                };
            }

            return new LoginResult()
            {
                User = user,
                Message = "Logged in successfully",
                IsSuccess = true
            };
        }
    }
}