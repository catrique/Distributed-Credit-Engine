namespace FastTrack.Application.Commands;
public record CreateProposalCommand(string Document, decimal RequestedAmount, int Installments);