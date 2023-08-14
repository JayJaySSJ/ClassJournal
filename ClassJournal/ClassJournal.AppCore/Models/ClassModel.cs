using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassJournal.AppCore.Models
{
    [Table("Classes")]
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
                if (value is not null && value.Function == UserFunctionEnum.Trainer)
                {
                    Trainer = value;
                }
            }
        }
        public IEnumerable<UserModel> Students  //DOTO: 'value.Any()' to double-check in use
        { 
            get { return Students; }
            set
            {
                if (value is not null && value.Any() && value.All(x => x.Function == UserFunctionEnum.Student))
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