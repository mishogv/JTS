namespace JTSystem.Application.Tournaments.Comands.Categories.Create
{
    public class CreateCategoryOutputModel
    {
        public CreateCategoryOutputModel(int id)
            => this.Id = id;

        public int Id { get; }
    }
}
