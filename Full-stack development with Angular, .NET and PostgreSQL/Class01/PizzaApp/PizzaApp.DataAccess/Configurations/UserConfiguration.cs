using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaApp.Domain.Entities;

namespace PizzaApp.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public const string AdminUserId = "35f77525-e83b-4389-ab7e-f38711dc39ce";
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                Id = AdminUserId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@pizzaapp.local",
                NormalizedEmail = "ADMIN@PIZZAAPP.LOCAL",

                PasswordHash = "AQAAAAIAAYagAAAAEORMNJTSPwqrmb2GKtm5oxli8mkCddIShGuomTmTzpYUfNBuyB9YyZyhymbYQOXTMA==",
                SecurityStamp = "7faf82b5-10c8-4718-97ac-0c2bc0204f05",
                ConcurrencyStamp = "53ffa93f-02ce-4e3f-ac04-113823f80290"

            });
        }
    }
}
