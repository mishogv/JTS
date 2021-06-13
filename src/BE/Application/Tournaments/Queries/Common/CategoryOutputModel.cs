namespace JTSystem.Application.Tournaments.Queries.Common
{
    using JTSystem.Domain.Tournaments.Models.Tournaments;

    public class CategoryOutputModel
    {
        public  CategoryOutputModel(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        public string Name { get; }

        public Gender Gender { get; }
    }
}
