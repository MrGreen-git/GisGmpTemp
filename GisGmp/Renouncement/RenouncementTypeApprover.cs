using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public class RenouncementTypeApprover
    {
        [XmlAttribute]
        public string positionCode { get; set; }

        [XmlAttribute]
        public string positionName { get; set; }

        [XmlAttribute]
        public string personApproving { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime approvalDate { get; set; }
    }
}
