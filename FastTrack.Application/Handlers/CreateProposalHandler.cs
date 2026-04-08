using FastTrack.Application.Commands;
using FastTrack.Domain.Entities;
using FastTrack.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FastTrack.Application.Handlers;

public class CreateProposalHandler
{
    private readonly AppDbContext _context;
    public CreateProposalHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Proposal> Handler(CreateProposalCommand command)
    {
        var proposal = new Proposal(
            command.Document,
            command.RequestedAmount,
            command.Installments
        );

        _context.Proposals.Add(proposal);
        await _context.SaveChangesAsync();
        return proposal;
    }
}