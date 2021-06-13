namespace JTSystem.Application.Tournaments.Comands.Judokas.Create
{
    public class CreateJudokaOutputModel
    {
        public CreateJudokaOutputModel(int id)
            => this.Id = id;

        public int Id { get; }
    }
}
