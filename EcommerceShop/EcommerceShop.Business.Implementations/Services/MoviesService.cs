
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Definitions.Data;
using EcommerceShop.Business.Implementations.Base;

namespace EcommerceShop.Business.Implementations.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context)
        {
        }
    }
}
