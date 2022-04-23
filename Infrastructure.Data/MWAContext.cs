using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MWAContext : IdentityDbContext
    {
        public MWAContext(DbContextOptions options)
        : base(options){}

        //public DbSet<User> Users { get; set; }
        public DbSet<RootWord> RootWords { get; set; }
        public DbSet<Phonetic> Phonetics { get; set; }
        public DbSet<Meaning> Meanings { get; set; }
        public DbSet<Definition> Definitions { get; set; }
        public DbSet<WordList> WordLists { get; set; }
    }
}