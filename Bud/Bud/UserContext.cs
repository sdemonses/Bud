using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Bud
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }
        public DbSet<BudVar1> BudVar1s { get; set; }
        public DbSet<BudVar2> BudVar2s { get; set; }
    }
}
