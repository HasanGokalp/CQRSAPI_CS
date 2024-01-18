using CQRSAPI.Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRSAPI.Persistence.Mappings
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.CAR_ID);

            builder.Property(x => x.CAR_ID).HasColumnName("CAR_ID");

            builder.Property(x => x.CAR_MODEL).HasColumnName("CAR_MODEL");

            builder.Property(x => x.CAR_NAME).HasColumnName("CAR_NAME");

        }
    }
}
