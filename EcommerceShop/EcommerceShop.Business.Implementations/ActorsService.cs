using EcommerceShop.Business.Definitions.Data;
using EcommerceShop.Business.Definitions;
using Microsoft.EntityFrameworkCore;

namespace EcommerceShop.Business.Implementations
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) 
        { 
            _context = context;
            _context.Database.Migrate();
        }

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
