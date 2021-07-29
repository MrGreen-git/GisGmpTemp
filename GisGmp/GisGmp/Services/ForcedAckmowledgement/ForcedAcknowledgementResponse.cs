using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable = false)]
    public class ForcedAcknowledgementResponse : ResponseType
    {
        [XmlElement("Done", typeof(Done))]
        [XmlElement("Quittance", typeof(Quittance))]
        public object[] Items { get; set; }
    }
}
