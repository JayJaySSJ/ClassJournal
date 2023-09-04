using ClassJournal.AppCore.Interfaces;
using ClassJournal.AppCore.Models;
using ClassJournal.AppCore.RepositoryDependencies;

namespace ClassJournal.AppCore.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryBase<UserModel> _repositoryBase;
        private readonly IUserRepository _userRepository;

        public UserService(IRepositoryBase<UserModel> classJournalRepository, IUserRepository userRepository)
        {
            _repositoryBase = classJournalRepository;
            _userRepository = userRepository;
        }

        public void Add(UserModel entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(UserModel entity)
        {
            _repositoryBase.Delete(entity);
        }

        public UserModel Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public UserModel Get(string email)
        {
            return _userRepository.Get(email);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Update(UserModel dbEntity, UserModel entity)
        {
            _repositoryBase.Update(dbEntity, entity);
        }
    }
}