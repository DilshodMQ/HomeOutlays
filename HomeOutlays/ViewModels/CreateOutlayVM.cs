using HomeOutlays.Enums;
using HomeOutlays.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace HomeOutlays.ViewModels
{
    public class CreateOutlayVM
    {
        public CreateOutlayVM()
        {
                
        }

        [Required]
        public OutlayTypeEnum Type { get; set; }
        [Required]
        public int Cost { get; set; }
        public string Description { get; set; } = string.Empty;

        public Outlay MapToModel()
        {
            return new Outlay()
            {
                Type = this.Type,
                Description = this.Description,
                Cost = this.Cost,
            };
        }
    }
}
