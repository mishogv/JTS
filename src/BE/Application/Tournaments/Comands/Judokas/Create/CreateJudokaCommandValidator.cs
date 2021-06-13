namespace JTSystem.Application.Tournaments.Comands.Judokas.Create
{
    using FluentValidation;
    using JTSystem.Application.Tournaments.Comands.Judokas.Common;

    public class CreateJudokaCommandValidator<TCommand> : AbstractValidator<CreateJudokaCommand>
    {
        public CreateJudokaCommandValidator()
            => this.Include(new JudokaCommandCommonValidator<CreateJudokaCommand>());
    }
}
