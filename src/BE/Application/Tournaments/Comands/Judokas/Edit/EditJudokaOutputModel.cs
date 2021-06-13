namespace JTSystem.Application.Tournaments.Comands.Judokas.Edit
{
    using JTSystem.Domain.Tournaments.Models.Tournaments;

    public class EditJudokaOutputModel
    {
        public EditJudokaOutputModel(int id, string name, Category category)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
        }

        public int Id { get; }

        public string Name { get; }

        public Category Category { get; }
    }
}
