using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public class OrganizationType
    {
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string inn { get; set; }

        [XmlAttribute]
        public string kpp { get; set; }

        [XmlAttribute]
        public string ogrn { get; set; }
    }
}
