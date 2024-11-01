using HomeOutlays.Enums;
using HomeOutlays.Models;
using System.ComponentModel.DataAnnotations;

namespace HomeOutlays.ViewModels
{
    public class EditOutlayVM
    {
        public EditOutlayVM()
        {
        }

        public EditOutlayVM(Outlay outlay)
        {
            Type = outlay.Type;
            Description = outlay.Description;
            Cost = outlay.Cost;
            Id = outlay.Id;
        }

        public Guid Id { get; set; }

        [Required]
        public OutlayTypeEnum Type { get; set; }
        [Required]
        public int Cost { get; set; }
        public string Description { get; set; } = string.Empty;

        public Outlay MapToModel()
        {
            return new Outlay()
            {
                Id = Id,
                Type = this.Type,
                Description = this.Description,
                Cost = this.Cost,
            };
        }
    }
}
