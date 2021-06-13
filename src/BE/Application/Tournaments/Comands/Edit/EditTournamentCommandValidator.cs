namespace JTSystem.Application.Tournaments.Comands.Edit
{
    using FluentValidation;
    using JTSystem.Application.Tournaments.Comands.Common;

    public class EditTournamentCommandValidator<TCommand> : AbstractValidator<EditTournamentCommand>
    {
        public EditTournamentCommandValidator()
            => this.Include(new TournamentCommandCommonValidator<EditTournamentCommand>());
    }
}
