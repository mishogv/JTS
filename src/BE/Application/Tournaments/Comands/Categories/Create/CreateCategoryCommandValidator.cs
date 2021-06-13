namespace JTSystem.Application.Tournaments.Comands.Categories.Create
{
    using FluentValidation;
    using JTSystem.Application.Tournaments.Comands.Categories.Common;

    public class CreateCategoryCommandValidator<TCommand> : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
            => this.Include(new CategoryCommandCommonValidator<CreateCategoryCommand>());
    }
}
