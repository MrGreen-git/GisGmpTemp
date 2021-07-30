using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    [XmlRoot("AdditionalOffense", Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0", IsNullable = false)]
    public class OffenseType
    {
        [XmlAttribute]
        public DateTime offenseDate { get; set; }

        [XmlAttribute]
        public string offensePlace { get; set; }

        [XmlAttribute]
        public string legalAct { get; set; }

        [XmlAttribute]
        public string digitalLink { get; set; }

        [XmlAttribute]
        public string departmentName { get; set; }
    }
}
