namespace JTSystem.Application.Tournaments.Comands.Categories.Edit
{
    using FluentValidation;
    using Common;

    public class EditCategoryCommandValidator<TCommand> : AbstractValidator<EditCategoryCommand>
    {
        public EditCategoryCommandValidator()
            => this.Include(new CategoryCommandCommonValidator<EditCategoryCommand>());
    }
}
