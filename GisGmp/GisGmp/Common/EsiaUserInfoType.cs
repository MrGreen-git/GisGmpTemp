using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class EsiaUserInfoType
    {
        [XmlElement("IndividualBusiness", typeof(EsiaUserInfoTypeIndividualBusiness))]
        [XmlElement("Person", typeof(EsiaUserInfoTypePerson))]
        public object Item { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string userId { get; set; }

        [XmlAttribute]
        public string sessionIndex { get; set; }

        [XmlAttribute]
        public DateTime sessionDate { get; set; }

        [XmlIgnore]
        public bool sessionDateSpecified { get; set; }
    }
}
