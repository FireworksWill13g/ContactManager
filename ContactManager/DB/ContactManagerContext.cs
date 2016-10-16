using System.Data.Entity;

namespace ContactManager.DB
{
    public class ContactManagerContext : DbContext
    {
        public DbSet<People> Peoples { get; set; }
    }
}