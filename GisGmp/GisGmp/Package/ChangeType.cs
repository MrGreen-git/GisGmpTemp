using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ChangeType
    {
        [XmlElement("ChangeValue")]
        public ChangeTypeChangeValue[] ChangeValue { get; set; }

        [XmlAttribute]
        public string fieldNum { get; set; }
    }
}
