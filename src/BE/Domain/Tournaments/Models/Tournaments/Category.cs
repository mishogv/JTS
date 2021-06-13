namespace JTSystem.Domain.Tournaments.Models.Tournaments
{
    using Common.Models;

    public class Category : Entity<int>
    {
        public Category(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        private Category(string name)
        {
            this.Name = name;
            this.Gender = default!;
        }

        public string Name { get; private set; }

        public Gender Gender { get; private set; }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateGender(Gender gender)
        {
            this.Gender = gender;
        }
    }
}
