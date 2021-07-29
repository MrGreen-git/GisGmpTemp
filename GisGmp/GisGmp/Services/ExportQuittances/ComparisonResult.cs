using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
    public class ComparisonResult
    {
        [XmlAttribute]
        public string paymentId { get; set; }

        [XmlAttribute]
        public ulong comparisonWeight { get; set; }

        [XmlAttribute]
        public DateTime comparisonDate { get; set; }

        [XmlIgnore]
        public bool comparisonDateSpecified { get; set; }

        [XmlAttribute]
        public ulong amountPayment { get; set; }

        [XmlIgnore]
        public bool amountPaymentSpecified { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }

        [XmlAttribute]
        public string accountNumber { get; set; }

        [XmlAttribute]
        public string bik { get; set; }
    }
}
