using CQRSAPI.Application.Features.Cars.Queries.GetAllCar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSAPI.Api.Controllers
{
    [Route("/Car")]
    public class CarController : Controller
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Get_ArabalariGetir")]
        public async Task<IActionResult> GetAllCar()
        {
            var result = await _mediator.Send(new GetAllCarRequest());
            return Ok(result);
        }
    }
}
