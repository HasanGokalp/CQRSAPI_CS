using MediatR;

namespace CQRSAPI.Application.Features.Cars.Queries.GetAllCar
{
    public class GetAllCarRequest : IRequest<IList<GetAllCarResponse>>
    {

    }
}
