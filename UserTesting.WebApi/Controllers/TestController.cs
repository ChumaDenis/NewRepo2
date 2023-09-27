using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTesting.Application.Features.TestFeatures.CreateTest;
using UserTesting.Application.Features.UserFeatures.AddUser;
using UserTesting.Domain.Entities;

namespace UserTesting.WebApi.Controllers
{
    [Route("test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<CreateTestResponse>> CreateTest(Test  test, CancellationToken cancellationToken)
        {
            var responce = await _mediator.Send(new CreateTestRequest(test, cancellationToken));
            return Ok(responce);
        }

    }
}
