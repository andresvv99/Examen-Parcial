

namespace webApi.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection") 
        {

        }

        public System.Data.Entity.DbSet<webApi.Models.Student> Students { get; set; }
    }
}