using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class ClarificationApplicationType
    {
        public originalDetailType OriginalDetails { get; set; }

        public setDetailType SetDetails { get; set; }

        [XmlAttribute]
        public string ordinalNumber { get; set; }

        [XmlAttribute]
        public string applicationName { get; set; }

        [XmlAttribute]
        public ClarificationApplicationTypeAppCode appCode { get; set; }

        [XmlIgnore]
        public bool appCodeSpecified { get; set; }

        [XmlAttribute]
        public string appNum { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime appDate { get; set; }

        [XmlIgnore]
        public bool appDateSpecified { get; set; }

        [XmlAttribute]
        public string incomeId { get; set; }

        [XmlAttribute]
        public string applicationNumber { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime applicationDate { get; set; }

        [XmlIgnore]
        public bool applicationDateSpecified { get; set; }
    }
}
