using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.Domain
{
    public class WalkDifficulty
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }

    }
}
