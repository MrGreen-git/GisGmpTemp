using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable = false)]
    public class ForcedAcknowledgementResponse : ResponseType
    {
        [XmlElement("Done", typeof(ForcedAcknowledgementResponseDone))]
        [XmlElement("Quittance", typeof(ForcedAcknowledgementResponseQuittance))]
        public object[] Items { get; set; }
    }
}
