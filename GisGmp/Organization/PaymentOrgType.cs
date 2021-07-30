using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public class PaymentOrgType
    {
        [XmlElement("Bank", typeof(BankType))]
        [XmlElement("Other", typeof(PaymentOrgTypeOther))]
        [XmlElement("UFK", typeof(string))]
        public object Item { get; set; }
    }
}
