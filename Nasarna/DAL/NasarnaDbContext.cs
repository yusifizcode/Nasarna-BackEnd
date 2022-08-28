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
        public DbSet<Message> Messages { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Mission> Missions { get; set; }
    }
}
