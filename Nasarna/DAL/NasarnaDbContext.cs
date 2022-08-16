using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.Models;

namespace Nasarna.DAL
{
    public class NasarnaDbContext : IdentityDbContext
    {
        public NasarnaDbContext(DbContextOptions<NasarnaDbContext> options):base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cause> Causes { get; set; }
        public DbSet<CauseComment> CauseComments { get; set; }
        public DbSet<CauseImage> CauseImages { get; set; }
        public DbSet<CauseTag> CauseTags { get; set; }
        public DbSet<Payment> Payments { get; set; }
        /*        public DbSet<Donation> Donations { get; set; }
        */
    }
}
