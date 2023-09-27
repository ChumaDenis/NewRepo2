using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Features.UserFeatures.AddUser;
using UserTesting.Application.Features.UserFeatures.GetByEmail;

namespace UserTesting.WebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<GetByEmailResponse>> GetUser(string email, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetByEmailRequest(email), cancellationToken);
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult<AddUserResponse>> AddUser(string email, string password, CancellationToken cancellationToken)
        {
            var responce = await _mediator.Send(new AddUserRequest(email, password), cancellationToken);
            return Ok(responce);
        }


    }
}
