using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.Domain
{
    public class Walks
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        public Regions Region { get; set; }
        public WalkDifficulty walkDifficulty { get; set; }

    }
}
