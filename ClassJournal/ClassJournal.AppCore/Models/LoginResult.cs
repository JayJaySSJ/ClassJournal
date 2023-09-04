namespace ClassJournal.AppCore.Models
{
    public class LoginResult
    {
        public UserModel? User { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}