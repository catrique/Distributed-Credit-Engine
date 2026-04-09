using Microsoft.AspNetCore.Mvc;
using FastTrack.Application.Handlers;
using FastTrack.Application.Commands;
using FastTrack.Application.Queries;

namespace FastTrack.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProposalController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateProposalCommand command,
        [FromServices] CreateProposalHandler handler)
    {
        var result = await handler.Handler(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromServices] GetAllProposalsHandler handler)
    {
        var result = await handler.Handle(new GetAllProposalsQuery());
        return Ok(result);
    }
}