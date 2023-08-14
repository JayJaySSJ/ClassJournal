using ClassJournal.AppCore.Interfaces;
using ClassJournal.AppCore.Models;
using ClassJournal.AppCore.RepositoryDependencies;

namespace ClassJournal.AppCore.Services
{
    public class UserService : IUserService
    {
        private readonly IClassJournalRepository<UserModel> _classJournalRepository;

        public UserService(IClassJournalRepository<UserModel> classJournalRepository)
        {
            _classJournalRepository = classJournalRepository;
        }

        public void Add(UserModel entity)
        {
            _classJournalRepository.Add(entity);
        }

        public void Delete(UserModel entity)
        {
            _classJournalRepository.Delete(entity);
        }

        public UserModel Get(int id)
        {
            return _classJournalRepository.Get(id);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _classJournalRepository.GetAll();
        }

        public void Update(UserModel dbEntity, UserModel entity)
        {
            _classJournalRepository.Update(dbEntity, entity);
        }
    }
}