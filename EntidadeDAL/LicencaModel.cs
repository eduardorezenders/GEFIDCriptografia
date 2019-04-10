namespace EntidadeDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LicencaModel : DbContext
    {
        public LicencaModel()
            : base("name=LicencaModel")
        {
        }

        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<licenca> licenca { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cliente>()
                .HasMany(e => e.licenca)
                .WithRequired(e => e.cliente)
                .WillCascadeOnDelete(false);
        }
    }
}
