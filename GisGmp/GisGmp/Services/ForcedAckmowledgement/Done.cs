using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class Done
    {
        [XmlAttribute]
        public string serviceDataID { get; set; }

        [XmlText()]
        public bool Value { get; set; }
    }
}
