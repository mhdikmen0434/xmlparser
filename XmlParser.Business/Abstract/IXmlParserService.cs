using XmlParser.Core.Results;

namespace XmlParser.Business.Abstract
{
    public interface IXmlParserService
    {
        IResult Save(string folderPath);
    }
}
