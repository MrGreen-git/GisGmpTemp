using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class AccDocType
    {
        [XmlAttribute]
        public string accDocNo { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime accDocDate { get; set; }
    }
}
