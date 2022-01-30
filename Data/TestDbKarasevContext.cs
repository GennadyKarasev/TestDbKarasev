#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestDbKarasev.Models;

namespace TestDbKarasev.Data
{
    public class TestDbKarasevContext : DbContext
    {
        public TestDbKarasevContext (DbContextOptions<TestDbKarasevContext> options)
            : base(options)
        {
        }

        public DbSet<TestDbKarasev.Models.Product> Product { get; set; }
    }
}
