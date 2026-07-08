using Domain.Products;
using Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .HasConversion(
                       id => id.Value,
                       value => new ProductId(value));

            builder.OwnsOne(c => c.Money, money =>
            {
                money.Property(c => c.Amount);
                money.Property(c => c.Currency);
            });
            builder.Property(x => x.Status)
                   .HasConversion<string>();
        }
    }
}
