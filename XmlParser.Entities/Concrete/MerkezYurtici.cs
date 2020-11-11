using System;
using XmlParser.Core.Entities;

namespace XmlParser.Entities.Concrete
{
    public class MerkezYurtici : IEntity
    {
        public int istno { get; set; }
        public string il_adi { get; set; }
        public string ilce_adi { get; set; }
        public int ilid { get; set; }
        public string istad { get; set; }
        public string datatarih { get; set; }
        public float SICAKLIK { get; set; }
        public float MAKSIMUM_SICAKLIK { get; set; }
        public float MINIMUM_SICAKLIK { get; set; }
        public float NEM { get; set; }
        public float RUZGAR_YONU { get; set; }
        public float RUZGAR_HIZI { get; set; }
        public float YAGIS { get; set; }
        public int YAGIS_KAYIT_SAYISI { get; set; }
        public int KAPALILIK { get; set; }
        public float AKTUEL_BASINC { get; set; }
        public float DENIZE_INDIRGENMIS_BASINC { get; set; }
        public float MAKSIMUM_RUZGAR_YONU_DER { get; set; }
        public float MAKSIMUM_RUZGAR_HIZI { get; set; }
    }
}
