using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncurtadorDeLinks.Models
{
    public class EncurtadorContext : DbContext
    {
        public EncurtadorContext(DbContextOptions<EncurtadorContext> options)
            : base(options)
        { }

        public DbSet<URL> URLS { get; set; }
    }
}
