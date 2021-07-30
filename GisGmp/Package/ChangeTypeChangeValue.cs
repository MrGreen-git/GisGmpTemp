using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ChangeTypeChangeValue
    {
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string value { get; set; }
    }
}
