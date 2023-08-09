using System.ComponentModel.DataAnnotations;

namespace ClassJournal.API.Models
{
    public class ClassModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public UserModel Trainer 
        { 
            get { return Trainer; } 
            set 
            {
                if (value is not null && value.UserFunction == UserFunctionEnum.Trainer)
                {
                    Trainer = value;
                }
            }
        }
        public IEnumerable<UserModel> Students
        { 
            get { return Students; }
            set
            {
                if (value is not null && value.All(x => x.UserFunction == UserFunctionEnum.Student))
                {
                    Students = value;
                }    
            }
        }
        public int AttendancePassigThreshold { get; set; }
        public int HomeworkPassigThreshold { get; set;}
        public int TestPassingThreshold { get; set;}
    }
}