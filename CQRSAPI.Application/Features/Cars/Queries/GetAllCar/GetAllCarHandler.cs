using CQRSAPI.Persistence.Repositories;
using MediatR;

namespace CQRSAPI.Application.Features.Cars.Queries.GetAllCar
{
    public class GetAllCarHandler : IRequestHandler<GetAllCarRequest, IList<GetAllCarResponse>>
    {
        private readonly ReadRepository _readRepository;

        public GetAllCarHandler(ReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<IList<GetAllCarResponse>> Handle(GetAllCarRequest request, CancellationToken cancellationToken)
        {
            var cars = _readRepository.GetCars(); // Veritabanından Car nesnelerini alır

            var response = cars.Select(car => new GetAllCarResponse
            {
                // Örneğin, car nesnesinin özelliklerini GetAllCarResponse nesnesine kopyalayın

                Name = car.CAR_NAME,
                Model = car.CAR_MODEL,

                // Diğer alanlar...
            }).ToList();

            return response;
        }
    }
}
