using Microsoft.EntityFrameworkCore;
using MS.AFORO255.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.AFORO255.Security.Repositories
{
    public class ContextDatabase: DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {

        }

        public DbSet<Access> Access { get; set; }

    }
}
