using GisGmp.Package;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    [XmlInclude(typeof(ImportedIncomeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
    public class IncomeType : PaymentBaseType
    {
        public IncomeTypeIncomeIndex IncomeIndex { get; set; }

        [XmlAttribute]
        public string transactionID { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime edDate { get; set; }

        [XmlAttribute]
        public string incomeId { get; set; }

        [XmlAttribute]
        public DateTime incomeDate { get; set; }

        [XmlAttribute]
        public IncomeTypeEdCode edCode { get; set; }

        [XmlAttribute]
        public string edNo { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime chargeOffDate { get; set; }

        [XmlIgnore]
        public bool chargeOffDateSpecified { get; set; }

        [XmlAttribute]
        public bool isUncertain { get; set; }

        [XmlAttribute]
        public string paymentId { get; set; }
    }
}
