using System.Data.Entity.Infrastructure.Interception;

namespace DBinterceptor
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelConnection")
        {
            DbInterception.Add(new DatabaseLogger());
        }

        public virtual DbSet<Error> Errors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
