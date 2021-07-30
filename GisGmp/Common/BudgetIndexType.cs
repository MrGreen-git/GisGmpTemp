using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class BudgetIndexType
    {
        [XmlAttribute]
        public string status { get; set; }

        [XmlAttribute]
        public string paytReason { get; set; }

        [XmlAttribute]
        public string taxPeriod { get; set; }

        [XmlAttribute]
        public string taxDocNumber { get; set; }

        [XmlAttribute]
        public string taxDocDate { get; set; }
    }
}
