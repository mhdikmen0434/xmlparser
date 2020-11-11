using System.Data.Entity.ModelConfiguration;
using XmlParser.Entities.Concrete;

namespace XmlParser.DataAccess.Concrete.EntityFramework.Configurations
{
    public class MerkezYurticiConfiguration : EntityTypeConfiguration<MerkezYurtici>
    {
        public MerkezYurticiConfiguration()
        {
            ToTable("MerkezYurtici");

            HasKey(x => x.istno);
            HasIndex(x => x.istno);
        }
    }
}
