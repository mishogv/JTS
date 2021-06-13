namespace JTSystem.Application.Tournaments.Comands.Common
{
    using JTSystem.Application.Common;
    using FluentValidation;

    public class TournamentCommandCommonValidator<TCommand> : AbstractValidator<TournamentCommand<TCommand>>
           where TCommand : EntityCommand<int>
    {
        public TournamentCommandCommonValidator()
        {
            RuleFor(x => x.Name)
                .MinimumLength(2)
                .MaximumLength(40)
                .NotEmpty();

            RuleFor(x => x.WinPrize)
                .GreaterThan(1);

            RuleFor(x => x.StartDate)
                .LessThan(x => x.EndDate);

            RuleFor(x => x.Location)
                .NotEmpty();
        }
    }
}
