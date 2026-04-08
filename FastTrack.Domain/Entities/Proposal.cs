using FastTrack.Domain.Enums;

namespace FastTrack.Domain.Entities;

public class Proposal
{
    public Guid Id { get; private set; }
    public string Document { get; private set; }
    public decimal RequestedAmount { get; private set; }
    public int Installments { get; private set; }
    public ProposalStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Proposal(string document, decimal requestedAmount, int installments)
    {
        if (string.IsNullOrWhiteSpace(document) || document.Length != 11)
            throw new ArgumentException("CPF deve ter 11 dígitos");
        if (requestedAmount < 100 || requestedAmount > 100000)
            throw new ArgumentException("O valor soliciado deve estar entre R$ 100 e R$100.000");
            if(installments < 1 || installments > 48)
            throw new ArgumentException("O parcelamento deve ser entre 1 e 48 meses.");

            Id = Guid.NewGuid();
            Document = document;
            RequestedAmount = requestedAmount;
            Installments = installments;
            Status = ProposalStatus.Pending;
            CreatedAt = DateTime.UtcNow;
    }
public void Approve() => Status = ProposalStatus.Approved;
    public void Reject() => Status = ProposalStatus.Rejected;

}