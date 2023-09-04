using ClassJournal.AppCore.Interfaces;
using ClassJournal.AppCore.Models;
using ClassJournal.AppCore.RepositoryDependencies;

namespace ClassJournal.AppCore.Services
{
    public class ClassService : IClassService
    {
        private readonly IRepositoryBase<ClassModel> _classJournalRepository;

        public ClassService(IRepositoryBase<ClassModel> classJournalRepository)
        {
            _classJournalRepository = classJournalRepository;
        }

        public void Add(ClassModel entity)
        {
            _classJournalRepository.Add(entity);
        }

        public void Delete(ClassModel entity)
        {
            _classJournalRepository.Delete(entity);
        }

        public ClassModel Get(int id)
        {
            return _classJournalRepository.Get(id);
        }

        public IEnumerable<ClassModel> GetAll()
        {
            return _classJournalRepository.GetAll();
        }

        public void Update(ClassModel dbEntity, ClassModel entity)
        {
            _classJournalRepository.Update(dbEntity, entity);
        }
    }
}