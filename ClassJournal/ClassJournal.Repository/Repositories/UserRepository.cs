using ClassJournal.Repository.DatabaseContext;
using ClassJournal.AppCore.Models;
using ClassJournal.AppCore.RepositoryDependencies;

namespace ClassJournal.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public void Add(UserModel entity)
        {
            _userContext.Users.Add(entity);
            _userContext.SaveChanges();
        }

        public void Delete(UserModel entity)
        {
            _userContext.Users.Remove(entity);
            _userContext.SaveChanges();
        }

        public UserModel Get(int id)
        {
            return _userContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public UserModel Get(string email)
        {
            return _userContext.Users.FirstOrDefault(x => x.Email == email);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _userContext.Users.Where(x => x.Function != UserFunctionEnum.Admin).ToList();
        }

        public void Update(UserModel dbEntity, UserModel entity)
        {
            dbEntity.Name = entity.Name;
            dbEntity.Surname = entity.Surname;

            _userContext.SaveChanges();
        }
    }
}