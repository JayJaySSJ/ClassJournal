using ClassJournal.AppCore.Models;
using ClassJournal.AppCore.RepositoryDependencies;
using ClassJournal.Repository.DatabaseContext;

namespace ClassJournal.Repository.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly ClassContext _classContext;

        public ClassRepository(ClassContext classContext)
        { 
            _classContext = classContext;
        }

        public void Add(ClassModel entity)
        {
            _classContext.Classes.Add(entity);
            _classContext.SaveChanges();
        }

        public void Delete(ClassModel entity)
        {
            _classContext.Classes.Remove(entity);
            _classContext.SaveChanges();
        }

        public ClassModel Get(int id)
        {
            return _classContext.Classes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<ClassModel> GetAll()
        {
            return _classContext.Classes.ToList();
        }

        public void Update(ClassModel dbEntity, ClassModel entity)
        {
            dbEntity.Name = entity.Name;
            dbEntity.BeginDate = entity.BeginDate;
            dbEntity.Trainer = entity.Trainer;
            dbEntity.Students = entity.Students;
            dbEntity.AttendancePassigThreshold = entity.AttendancePassigThreshold;
            dbEntity.HomeworkPassigThreshold = entity.HomeworkPassigThreshold;
            dbEntity.TestPassingThreshold = entity.TestPassingThreshold;

            _classContext.SaveChanges();
        }
    }
}