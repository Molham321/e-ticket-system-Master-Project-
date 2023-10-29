
using EcommerceShop.Business.Definitions;

namespace EcommerceShop.Business.Implementations
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        Actor Update(int id, Actor newActor);

        void Delete(int id);
    }
}
