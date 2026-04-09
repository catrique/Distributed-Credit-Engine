using FastTrack.Application.Queries;
using FastTrack.Domain.Entities;
using FastTrack.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FastTrack.Application.Handlers;

public class GetAllProposalsHandler
{
    private readonly AppDbContext _context;

    public GetAllProposalsHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Proposal>> Handle(GetAllProposalsQuery query)
    {
        return await _context.Proposals.AsNoTracking().ToListAsync();
    }
}