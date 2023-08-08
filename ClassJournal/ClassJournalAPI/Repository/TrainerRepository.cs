using ClassJournal.API.DatabaseContext;
using ClassJournal.API.Models;

namespace ClassJournal.API.Repository
{
    public class TrainerRepository : IClassJournalRepository<TrainerModel>
    {
        private readonly TrainerContext _trainerContext;

        public TrainerRepository(TrainerContext trainerContext)
        {
            _trainerContext = trainerContext;
        }

        public void Add(TrainerModel entity)
        {
            _trainerContext.Trainers.Add(entity);
            _trainerContext.SaveChanges();
        }

        public void Delete(TrainerModel entity)
        {
            _trainerContext.Trainers.Remove(entity);
            _trainerContext.SaveChanges();
        }

        public TrainerModel Get(int id)
        {
            return _trainerContext.Trainers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TrainerModel> GetAll()
        {
            return _trainerContext.Trainers.ToList();
        }

        public void Update(TrainerModel dbEntity, TrainerModel entity)
        {
            dbEntity.Id = entity.Id;
            dbEntity.Name = entity.Name;
            dbEntity.Surname = entity.Surname;

            _trainerContext.SaveChanges();
        }
    }
}