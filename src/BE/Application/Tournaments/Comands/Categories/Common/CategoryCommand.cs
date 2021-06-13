namespace JTSystem.Application.Tournaments.Comands.Categories.Common
{
    using JTSystem.Application.Common;

    public abstract class CategoryCommand<TCommand> : EntityCommand<int>
        where TCommand : EntityCommand<int>
    {
        public string Name { get; set; } = default!;

        public int Gender { get; set; } = default!;
    }
}
