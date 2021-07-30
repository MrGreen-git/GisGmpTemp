using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ServiceDataTypePersoneOfficial
    {
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string officialPosition { get; set; }
    }
}
