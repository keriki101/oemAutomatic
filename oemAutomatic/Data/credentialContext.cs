using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using oemAutomatic.Models;

namespace oemAutomatic.Data
{
    public class credentialContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public credentialContext (DbContextOptions<credentialContext> options)
            :base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<credentials> credentials { get; set; }
    }
}
