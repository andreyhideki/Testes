using ReactProject.Entities.Enum;

namespace ReactProject.Entities
{
    public class User
    {
        public User(Guid userId, string firstName, string lastName, DateTime birthDate, EGender gender)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public EGender Gender { get; set; }

    }
}
