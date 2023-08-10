using System.Runtime.Serialization;

namespace ClassJournal.API.Models
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