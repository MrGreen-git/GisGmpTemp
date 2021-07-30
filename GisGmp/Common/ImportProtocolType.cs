using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ImportProtocolType
    {
        [XmlAttribute(DataType = "ID")]
        public string entityID { get; set; }

        [XmlAttribute]
        public string code { get; set; }

        [XmlAttribute]
        public string description { get; set; }
    }
}
