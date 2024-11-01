using HomeOutlays.Models;

namespace HomeOutlays.Repositories
{
    public class OutlayRepository : Repository<Outlay>, IOutlayRepository
    {
        public OutlayRepository(MyAppDbContext context) : base(context)
    {
    }
}
}
