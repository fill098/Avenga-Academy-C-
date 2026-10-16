using Mapster;
using PizzaApp.Domain.Entities;
using PizzaApp.Dtos.User;

namespace PizzaApp.Mappers.Configurations;

public class UserMappingConfig
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<User, UserDto>()
            .Ignore(dest => dest.Roles);
    }
}
