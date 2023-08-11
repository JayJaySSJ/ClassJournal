using ClassJournal.API.Models;
using ClassJournal.API.RepositoryDependencies;

namespace ClassJournal.Repository.Repositories
{
    public class ClassRepository : IClassJournalRepository<ClassModel>
    {
        public void Add(ClassModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ClassModel entity)
        {
            throw new NotImplementedException();
        }

        public ClassModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClassModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ClassModel dbEntity, ClassModel entity)
        {
            throw new NotImplementedException();
        }
    }
}