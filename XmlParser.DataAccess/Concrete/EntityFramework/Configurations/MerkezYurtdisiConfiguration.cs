using System.Data.Entity.ModelConfiguration;
using XmlParser.Entities.Concrete;

namespace XmlParser.DataAccess.Concrete.EntityFramework.Configurations
{
    public class MerkezYurtdisiConfiguration : EntityTypeConfiguration<MerkezYurtdisi>
    {
        public MerkezYurtdisiConfiguration()
        {
            ToTable("MerkezYurtdisi");

            HasKey(x => x.istno);
            HasIndex(x => x.istno);
        }
    }
}
