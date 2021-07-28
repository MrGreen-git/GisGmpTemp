using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public abstract class ChangeStatusType
    {
        public string Meaning { get; set; }

        public string Reason { get; set; }

        public DateTime ChangeDate { get; set; }

        [XmlIgnore]
        public bool ChangeDateSpecified { get; set; }
    }
}
