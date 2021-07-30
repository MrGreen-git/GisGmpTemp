using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundTypeRefundPayee : PayeeType
    {
        public AccountType BankAccountNumber { get; set; }

        public string PayeeAccount { get; set; }

        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }
    }
}
