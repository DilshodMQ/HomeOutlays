using HomeOutlays.Enums;
using HomeOutlays.Models;

namespace HomeOutlays.Services
{
    public interface IOutlayService : IService<Outlay>
    {
        IEnumerable<Outlay> GetFilteredOutlays(OutlayTypeEnum outlayType);

    }
}
