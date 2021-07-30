using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
    public class IncomeTypeIncomeIndex
    {
        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }

        [XmlAttribute]
        public string inn { get; set; }

        [XmlAttribute]
        public string kpp { get; set; }

        [XmlAttribute]
        public string accountNumber { get; set; }
    }
}
