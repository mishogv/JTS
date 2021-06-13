namespace JTSystem.Application.Tournaments.Comands.Create
{
    public class CreateTournamentOutputModel
    {
        public CreateTournamentOutputModel(int id)
            => this.Id = id;

        public int Id { get; }
    }
}
