using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class SignsClarificationType
    {
        public string HeadPost { get; set; }

        public string HeadName { get; set; }

        public string ExecutorPost { get; set; }

        public string ExecutorName { get; set; }

        public string ExecutorNum { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime SignDate { get; set; }

        [XmlIgnore]
        public bool SignDateSpecified { get; set; }

        public string TOFKheadPost { get; set; }

        public string TOFKheadName { get; set; }

        public string TOFKexecutorPost { get; set; }

        public string TOFKexecutorName { get; set; }

        public string TOFKexecutorNum { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime TOFKsignDate { get; set; }

        [XmlIgnore]
        public bool TOFKsignDateSpecified { get; set; }
    }
}
