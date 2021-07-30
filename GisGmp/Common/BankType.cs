using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class BankType
    {
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string bik { get; set; }

        [XmlAttribute]
        public string correspondentBankAccount { get; set; }
    }
}
