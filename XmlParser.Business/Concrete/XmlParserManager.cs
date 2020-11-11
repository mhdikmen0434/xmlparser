using System;
using System.CodeDom;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.XPath;
using ECommerceApp.Business.Constants;
using XmlParser.Business.Abstract;
using XmlParser.Core.Results;
using XmlParser.DataAccess.Abstract;
using XmlParser.Entities.Concrete;

namespace XmlParser.Business.Concrete
{
    public class XmlParserManager : IXmlParserService
    {
        private readonly IMerkezYurticiDal _merkezYurticiDal;
        private readonly IMerkezYurtdisiDal _merkezYurtdisiDal;

        public XmlParserManager(IMerkezYurticiDal merkezYurticiDal, IMerkezYurtdisiDal merkezYurtdisiDal)
        {
            _merkezYurticiDal = merkezYurticiDal;
            _merkezYurtdisiDal = merkezYurtdisiDal;
        }

        public IResult Save(string folderPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles().OrderBy(x => x.LastWriteTime).ToArray();

                foreach (var file in files)
                {
                    var fileContent = File.ReadAllText(file.FullName);
                    XDocument doc = XDocument.Parse(fileContent);
                    var root = doc.Root;
                    if (root.Name==RootTypes.SD)
                    {
                        foreach (var node in doc.Root.Nodes().ToList())
                        {
                            MerkezYurtici merkezYurtici = new MerkezYurtici();
                            var types = merkezYurtici.GetType().GetProperties().ToList();
                            types.ForEach(x =>
                            {
                                var relatedNodeValue = node.XPathSelectElement(x.Name) != null ? node.XPathSelectElement(x.Name).Value : string.Empty;
                                if (x.PropertyType != typeof(string))
                                {
                                    var parse = x.PropertyType.GetMethod("Parse", new[] { typeof(string) });
                                    if (parse != null && string.IsNullOrEmpty(relatedNodeValue) == false)
                                    {
                                        x.SetValue(merkezYurtici, parse.Invoke(null, new object[] { relatedNodeValue }));
                                    }
                                }
                                else
                                {
                                    x.SetValue(merkezYurtici, relatedNodeValue);
                                }
                            });
                            _merkezYurticiDal.Add(merkezYurtici);
                        }

                    }
                    else if(root.Name == RootTypes.Tahmin)
                    {
                        foreach (var node in doc.Root.Nodes().ToList())
                        {
                            MerkezYurtdisi merkezYurtdisi = new MerkezYurtdisi();
                            var types = merkezYurtdisi.GetType().GetProperties().ToList();
                            types.ForEach(x =>
                            {
                                var relatedNodeValue = node.XPathSelectElement(x.Name) != null ? node.XPathSelectElement(x.Name).Value : string.Empty;
                                if (x.PropertyType != typeof(string))
                                {
                                    var parse = x.PropertyType.GetMethod("Parse", new[] { typeof(string) });
                                    if (parse != null && string.IsNullOrEmpty(relatedNodeValue) == false)
                                    {
                                        x.SetValue(merkezYurtdisi, parse.Invoke(null, new object[] { relatedNodeValue }));
                                    }
                                }
                                else
                                {
                                    x.SetValue(merkezYurtdisi, relatedNodeValue);
                                }

                            });
                            _merkezYurtdisiDal.Add(merkezYurtdisi);
                        }
                    }

                }
                return new SuccessResult(Messages.Success);
            }
            else
            {
                return new ErrorResult(Messages.FolderNotFound);
            }

        }
    }
}
