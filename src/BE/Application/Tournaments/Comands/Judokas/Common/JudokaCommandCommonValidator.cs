namespace JTSystem.Application.Tournaments.Comands.Judokas.Common
{
    using JTSystem.Application.Common;
    using FluentValidation;

    public class JudokaCommandCommonValidator<TCommand> : AbstractValidator<JudokaCommand<TCommand>>
           where TCommand : EntityCommand<int>
    {
        public JudokaCommandCommonValidator()
        {
            RuleFor(x => x.Name)
                .MinimumLength(2)
                .MaximumLength(40)
                .NotEmpty();

            RuleFor(x => x.CategoryId)
                .GreaterThan(0);
        }
    }
}
