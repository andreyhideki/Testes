namespace ReactProject.Entities
{
    public class Profile
    {
        public Profile(Guid profileId, string name)
        {
            ProfileId = profileId;
            Name = name;
        }

        public Guid ProfileId { get; set; }
        public string Name { get; set; }

    }
}
