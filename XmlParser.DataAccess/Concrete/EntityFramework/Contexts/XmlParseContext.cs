using System.Data.Entity;
using XmlParser.DataAccess.Concrete.EntityFramework.Configurations;
using XmlParser.Entities.Concrete;

namespace XmlParser.DataAccess.Concrete.EntityFramework.Contexts
{
    public class XmlParseContext : DbContext
    {
        public XmlParseContext() : base(@"Server=DESKTOP-A8MUS1G\SQLEXPRESS;Database=XmlParserApp;Trusted_Connection=True;")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<MerkezYurtici> MerkezYurtici { get; set; }
        public DbSet<MerkezYurtdisi> MerkezYurtdisi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MerkezYurticiConfiguration());
            modelBuilder.Configurations.Add(new MerkezYurtdisiConfiguration());
        }
    }
}
