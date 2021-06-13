namespace JTSystem.Application.Tournaments.Comands.Judokas.Edit
{
    using FluentValidation;
    using Common;

    public class EditJudokaCommandValidator<TCommand> : AbstractValidator<EditJudokaCommand>
    {
        public EditJudokaCommandValidator()
            => this.Include(new JudokaCommandCommonValidator<EditJudokaCommand>());
    }
}
