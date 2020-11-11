using XmlParser.Core.DataAccess.EntityFramework;
using XmlParser.DataAccess.Abstract;
using XmlParser.DataAccess.Concrete.EntityFramework.Contexts;
using XmlParser.Entities.Concrete;

namespace XmlParser.DataAccess.Concrete.EntityFramework
{
    public class EfMerkezYurticiDal : EfEntityRepositoryBase<MerkezYurtici, XmlParseContext>, IMerkezYurticiDal
    {
    }
}
