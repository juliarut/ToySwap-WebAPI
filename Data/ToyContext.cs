using Microsoft.EntityFrameworkCore;
using ToySwap.Models;

namespace ToySwap.Data
{
    public class ToyContext : DbContext
    {
        public ToyContext(DbContextOptions<ToyContext> options) : base(options) { }

        public DbSet<Toy> Toys { get; set; }
    }
}