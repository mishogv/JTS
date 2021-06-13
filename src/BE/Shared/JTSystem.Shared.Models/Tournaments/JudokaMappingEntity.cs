namespace JTSystem.Shared.Models.Tournaments
{
    public class JudokaMappingEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public int Wins { get; set; }

        public int Loses { get; set; }

        public CategoryMappingEntity Category { get; set; } = default!;
    }
}
