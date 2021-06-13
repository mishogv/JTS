namespace JTSystem.Application.Tournaments.Comands.Categories.Common
{
    using JTSystem.Application.Common;
    using FluentValidation;

    public class CategoryCommandCommonValidator<TCommand> : AbstractValidator<CategoryCommand<TCommand>>
           where TCommand : EntityCommand<int>
    {
        public CategoryCommandCommonValidator()
        {
            RuleFor(x => x.Name)
                .MinimumLength(2)
                .MaximumLength(40)
                .NotEmpty();

            RuleFor(x => x.Gender)
                .InclusiveBetween(1, 2);
        }
    }
}
