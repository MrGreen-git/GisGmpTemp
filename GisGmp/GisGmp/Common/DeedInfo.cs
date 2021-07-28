using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class DeedInfo
    {
        [XmlAttribute]
        public DeedInfoIDType IDType { get; set; }

        [XmlAttribute]
        public string idDocNo { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime idDocDate { get; set; }

        [XmlAttribute]
        public string subjCode { get; set; }

        [XmlAttribute]
        public string subjName { get; set; }
    }
}
