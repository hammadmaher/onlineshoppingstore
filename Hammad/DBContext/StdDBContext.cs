using Hammad.Models;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;

namespace Hammad.DBContext
{
    public class StdDBContext : DbContext
    {
        public StdDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<formdata> formdata { get; set; }
    }

}

