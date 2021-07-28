using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    [XmlInclude(typeof(ImportedRenouncementType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public class RenouncementType
    {
        public RenouncementTypeApprover Approver { get; set; }

        public RenouncementTypeExecutor Executor { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DeedInfo DeedInfo { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute]
        public string renouncementID { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime rulingDate { get; set; }

        [XmlAttribute]
        public string rulingNum { get; set; }

        [XmlAttribute]
        public string refusalGround { get; set; }

        [XmlAttribute]
        public RenouncementTypeReasonCode reasonCode { get; set; }
    }
}
