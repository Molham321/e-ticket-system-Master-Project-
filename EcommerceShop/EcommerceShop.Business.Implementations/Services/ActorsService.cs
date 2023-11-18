
using EcommerceShop.Business.Definitions.Data;
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Implementations.Base;

namespace EcommerceShop.Business.Implementations.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}