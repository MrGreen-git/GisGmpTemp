using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot("TimeInterval", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class TimeIntervalType
    {
        [XmlAttribute]
        public DateTime startDate { get; set; }

        [XmlAttribute]
        public DateTime endDate { get; set; }
    }
}
