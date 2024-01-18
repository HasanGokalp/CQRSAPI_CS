using CQRSAPI.Domain.Concrete;
using CQRSAPI.Persistence.DAOs;

namespace CQRSAPI.Persistence.Repositories
{
    public class ReadRepository
    {
        private readonly CQRSAPICtx _ctx;
        public ReadRepository(CQRSAPICtx ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Car> GetCars()
        {
            return _ctx.Cars;
        }
    }
}
