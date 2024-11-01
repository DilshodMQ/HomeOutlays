using HomeOutlays.Enums;
using HomeOutlays.Models;
using HomeOutlays.Repositories;
using System.Security.Policy;

namespace HomeOutlays.Services
{
    public class OutlayService : Service<Outlay>, IOutlayService
    {
        private readonly IOutlayRepository _outlayRepository;
        public OutlayService(IOutlayRepository outlayRepository) : base(outlayRepository)
        {
            _outlayRepository = outlayRepository;
        }

        public override void Add(Outlay outlay)
        {
            outlay.Id = Guid.NewGuid();
            base.Add(outlay);
        }

        public IEnumerable<Outlay> GetFilteredOutlays(OutlayTypeEnum outlayType)
        {
            var outlys = _outlayRepository.GetAll();
            var fOutlays = outlys
                .Where(o => o.Type == outlayType).ToList();
            return fOutlays;
        }
    }
}
