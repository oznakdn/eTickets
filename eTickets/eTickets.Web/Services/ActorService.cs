using eTickets.Web.Data;
using eTickets.Web.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Web.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x=>x.Id==id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result=await _context.Actors.FirstOrDefaultAsync(x=>x.Id==id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
           
            _context.Actors.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }
}
