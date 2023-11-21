
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Implementations.Base;

namespace EcommerceShop.Business.Implementations.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
