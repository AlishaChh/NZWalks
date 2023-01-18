using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.Domain
{
    public class Regions
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public double Area { get; set; }
        public double Lat { get; set; }

        public double Long { get; set; }
        public long Population { get; set; }

        // navigation property 
        public IEnumerable<Walks> walks { get; set; }
    }
}
