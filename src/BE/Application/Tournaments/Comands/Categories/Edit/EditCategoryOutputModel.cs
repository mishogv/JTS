namespace JTSystem.Application.Tournaments.Comands.Categories.Edit
{
    using JTSystem.Domain.Tournaments.Models.Tournaments;

    public class EditCategoryOutputModel
    {
        public EditCategoryOutputModel(int id, string name, Gender gender)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
        }

        public int Id { get; }

        public string Name { get; }

        public Gender Gender { get; }
    }
}
