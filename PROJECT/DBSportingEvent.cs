using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class DBSportingEvent : DbContext
    {
        public DbSet<SportingEvent> Events {get; set;}
    }
}
