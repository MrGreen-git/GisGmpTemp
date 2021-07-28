using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExecutiveProcedureInfoType
    {
        public DeedInfo DeedInfo { get; set; }

        public ExecutiveProcedureInfoTypeExecutOrgan ExecutOrgan { get; set; }

        public ExecutiveProcedureInfoTypeDebtor Debtor { get; set; }

        [XmlAttribute]
        public string idDeloNo { get; set; }

        [XmlAttribute]
        public string deloPlace { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime idDesDate { get; set; }

        [XmlAttribute]
        public string aktDate { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string srokPrIsp { get; set; }

        [XmlAttribute]
        public ExecutiveProcedureInfoTypeSrokPrIspType srokPrIspType { get; set; }

        [XmlAttribute]
        public string claimerAdr { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime notifFSSPDate { get; set; }
    }
}
