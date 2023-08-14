using System.Runtime.Serialization;

namespace ClassJournal.AppCore.Models
{
    public enum UserFunctionEnum
    {
        [EnumMember]
        Admin = 0,
        [EnumMember]
        Trainer = 1,
        [EnumMember]
        Student = 2,
    }
}