namespace JTSystem.Application.Tournaments.Comands.Judokas.Common
{
    using JTSystem.Application.Common;
    using JTSystem.Domain.Tournaments.Models.Tournaments;

    public abstract class JudokaCommand<TCommand> : EntityCommand<int>
        where TCommand : EntityCommand<int>
    {
        public string Name { get; set; } = default!;

        public int CategoryId { get; set; } = default!;
    }
}
