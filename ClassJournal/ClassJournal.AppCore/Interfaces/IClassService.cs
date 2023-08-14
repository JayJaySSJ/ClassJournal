using ClassJournal.AppCore.Models;

namespace ClassJournal.AppCore.Interfaces
{
    public interface IClassService
    {
        IEnumerable<ClassModel> GetAll();
        ClassModel Get(int id);
        void Add(ClassModel entity);
        void Update(ClassModel dbEntity, ClassModel entity);
        void Delete(ClassModel entity);
    }
}