using HomeOutlays.Enums;
using System.ComponentModel.DataAnnotations;

namespace HomeOutlays.Models
{
    public class Outlay
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public OutlayTypeEnum Type { get; set; }
        [Required]
        public int Cost { get; set; }
        public string Description { get; set; }
    }
}
