
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Definitions.Data;
using EcommerceShop.Business.Implementations.Base;

namespace EcommerceShop.Business.Implementations.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}