namespace JTSystem.Application.Tournaments.Comands.Common
{
    using FluentValidation;
    using Create;

    public class CreateTournamentCommandValidator<TCommand> : AbstractValidator<CreateTournamentCommand>
    {
        public CreateTournamentCommandValidator()
            => this.Include(new TournamentCommandCommonValidator<CreateTournamentCommand>());
    }
}
