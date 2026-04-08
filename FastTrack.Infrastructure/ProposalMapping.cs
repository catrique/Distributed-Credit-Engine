using FastTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastTrack.Infrastructure.Mappings;

public class ProposalMapping : IEntityTypeConfiguration<Proposal>
{
    public void Configure(EntityTypeBuilder<Proposal> builder)
    {
        builder.ToTable("Proposals");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Document).HasColumnType("TEXT").HasMaxLength(11).IsRequired();
        builder.Property(p => p.RequestedAmount).HasColumnType("DECIMAL(18,2)").IsRequired();
        builder.Property(p => p.Installments).IsRequired();
        builder.Property(p => p.Status).HasColumnType("DECIMAL(18,2)").IsRequired();
        builder.Property(p => p.Status).HasConversion<string>().HasMaxLength(30).IsRequired();
        builder.Property(p => p.CreatedAt).IsRequired();
    }

}