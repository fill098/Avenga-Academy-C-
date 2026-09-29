using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaApp.Domain.Constatns;

namespace PizzaApp.DataAccess.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public const string AdminRolId = "d5e60f31-45b3-4905-9f26-f130dba5d731";
        public const string CostumerRoleId = "bbe182af-2a38-4532-a741-026c166e96eb";
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {   Id = AdminRolId,
                    Name = Roles.Admin,
                    NormalizedName = Roles.Admin.ToUpperInvariant(),
                    ConcurrencyStamp = "49b128a4-427e-4450-89da-48cecba586bb"

                },
                new IdentityRole
                {
                    Id = CostumerRoleId,
                    Name = Roles.Customer,
                    NormalizedName = Roles.Customer.ToUpperInvariant(),
                    ConcurrencyStamp = "3aa84a4c-0a92-4baf-96bd-93e93031925a"

                }
            );


        }
    }
}
