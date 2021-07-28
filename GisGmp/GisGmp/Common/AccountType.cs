using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class AccountType
    {
        public BankType Bank { get; set; }

        [XmlAttribute]
        public string accountNumber { get; set; }
    }
}
