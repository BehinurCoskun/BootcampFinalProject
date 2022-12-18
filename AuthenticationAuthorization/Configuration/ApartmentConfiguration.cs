using AuthenticationAuthorization.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthenticationAuthorization.Configuration
{
    public class ApartmentConfiguration : IEntityTypeConfiguration<ApartmentModel>
    {
        public void Configure(EntityTypeBuilder<ApartmentModel> builder)
        {
            //builder.HasOne(o => o.Owner)
            //    .WithOne(p => p.Apartment)
            //    .HasForeignKey<ApplicationUser>(x => x.ApartmentId);
        }
    }
}
