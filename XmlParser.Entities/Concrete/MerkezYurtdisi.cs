using System;
using XmlParser.Core.Entities;

namespace XmlParser.Entities.Concrete
{
    public class MerkezYurtdisi : IEntity
	{
        public int istno { get; set; }
        public int yil { get; set; }
        public int ay { get; set; }
        public string gun { get; set; }
        public string TahminMerkezi { get; set; }
        public string RaporZamani { get; set; }
        public string Yurtici { get; set; }
        public string tDurumDbirgun { get; set; }
        public int tMaxDbirgun { get; set; }
        public int tMinDbirgun { get; set; }
        public string tDurumDikigun { get; set; }
        public int tMaxDikigun { get; set; }
        public int tMinDikigun { get; set; }
        public string tDurumDucgun { get; set; }
        public int tMaxDucgun { get; set; }
        public int tMinDucgun { get; set; }
    }
}
