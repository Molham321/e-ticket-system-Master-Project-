
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Definitions.Data.ViewModels;
using EcommerceShop.Business.Implementations.Base;

namespace EcommerceShop.Business.Implementations.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);


    }
}
