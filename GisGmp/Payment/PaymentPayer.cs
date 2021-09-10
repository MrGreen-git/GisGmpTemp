using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    [XmlRoot("Payer", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0", IsNullable = false)]
    public class PaymentPayer : PayerType
    {
        /// <summary />
        protected PaymentPayer() { }

        /// <summary />
        public PaymentPayer(string payerIdentifier, string payerName)
            : base(payerIdentifier) => PayerName = payerName;

        /// <summary />
        public PaymentPayer(string payerIdentifier, string payerName, string payerAccount)
            : this(payerIdentifier, payerName) => PayerAccount = payerAccount;

        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        [XmlAttribute("payerAccount")]
        public string PayerAccount { get; set; }
    }
}
