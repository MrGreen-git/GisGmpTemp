using System;
using System.Xml.Serialization;

namespace GisGmp.CommonNSI
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public class oktmoNSIInfoType
    {
        [XmlAttribute]
        public string regionCode { get; set; }

        [XmlAttribute]
        public string areaCode { get; set; }

        [XmlAttribute]
        public string cityCode { get; set; }

        [XmlAttribute]
        public string localCode { get; set; }

        [XmlAttribute]
        public string controlNum { get; set; }

        [XmlAttribute]
        public string section { get; set; }

        [XmlAttribute]
        public string code { get; set; }

        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string centreName { get; set; }

        [XmlAttribute]
        public string clarification { get; set; }

        [XmlAttribute]
        public string lastChangeNum { get; set; }

        [XmlAttribute]
        public oktmoNSIInfoTypeLastChangeType lastChangeType { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime changeDate { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime introductionDate { get; set; }

        [XmlAttribute]
        public DateTime updateDate { get; set; }
    }

}
