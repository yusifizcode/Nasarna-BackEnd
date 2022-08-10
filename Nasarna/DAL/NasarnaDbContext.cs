using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.Models;

namespace Nasarna.DAL
{
    public class NasarnaDbContext : DbContext
    {
        public NasarnaDbContext(DbContextOptions<NasarnaDbContext> options):base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
    }
}
