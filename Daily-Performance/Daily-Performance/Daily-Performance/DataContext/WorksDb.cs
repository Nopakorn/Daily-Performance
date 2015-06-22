using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Daily_Performance.DataContext
{
    public class WorksDb : DbContext
    {
        public WorksDb()
            : base("DefaultConnection")
        {
    
        }
        public DbSet<Work> Works { get; set; }

    }
}