namespace JTSystem.Shared.Models.Tournaments
{
    public class FightMappingEntity
    {
        public FightMappingEntity(JudokaMappingEntity firstJudoka, JudokaMappingEntity secondJudoka, CategoryMappingEntity category, int firstJudokaScores, int secondJudokaScores)
        {
            this.FirstJudoka = firstJudoka;
            this.SecondJudoka = secondJudoka;
            this.Category = category;
            this.FirstJudokaScores = firstJudokaScores;
            this.SecondJudokaScores = secondJudokaScores;
        }

        public int Id { get; set; }

        public JudokaMappingEntity FirstJudoka { get; set; }

        public JudokaMappingEntity SecondJudoka { get; set; }

        public int FirstJudokaScores { get; set; }

        public int SecondJudokaScores { get; set; }

        public CategoryMappingEntity Category { get; set; }
    }
}
