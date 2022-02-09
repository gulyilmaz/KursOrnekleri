using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filters.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<SiteUser> SiteUsers { get; set; }
        public DbSet<Log> Logs { get; set; }

    }
}