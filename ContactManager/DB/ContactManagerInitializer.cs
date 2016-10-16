using System.Data.Entity;

namespace ContactManager.DB
{
    public class ContactManagerInitializer : DropCreateDatabaseIfModelChanges<ContactManagerContext>
    {
        protected override void Seed(ContactManagerContext context)
        {
            People initPerson = new People
            {
                Name = "Anderson"
            };

            context.Peoples.Add(initPerson);
            context.SaveChanges();
        }
    }
}