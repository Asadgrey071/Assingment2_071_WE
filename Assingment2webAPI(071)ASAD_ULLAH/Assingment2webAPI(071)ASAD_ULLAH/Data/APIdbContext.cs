using Microsoft.EntityFrameworkCore;
namespace Assingment2webAPI_071_ASAD_ULLAH.Data
{
    public class APIdbContext: DbContext
    {
        public APIdbContext(DbContextOptions<APIdbContext>options) 
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
