using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public class RenouncementTypeExecutor
    {
        [XmlAttribute]
        public string VKSPCode { get; set; }

        [XmlAttribute]
        public string structuralUnitName { get; set; }

        [XmlAttribute]
        public string structuralUnitAddress { get; set; }

        [XmlAttribute]
        public string structuralLocality { get; set; }

        [XmlAttribute]
        public string executorFullName { get; set; }
    }
}
