namespace JTSystem.Application.Tournaments.Queries.Common
{
    public class JudokaOutputModel
    {
        public JudokaOutputModel(string name, CategoryOutputModel category, int wins, int loses)
        {
            this.Name = name;
            this.Category = category;
            this.Wins = wins;
            this.Loses = loses;
        }

        public string Name { get; }

        public CategoryOutputModel Category { get; }

        public int Wins { get; }

        public int Loses { get; }
    }
}
