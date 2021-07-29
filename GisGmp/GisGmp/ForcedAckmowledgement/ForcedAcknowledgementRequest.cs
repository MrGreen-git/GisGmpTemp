using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable = false)]
    public class ForcedAcknowledgementRequest : RequestType
    {
        [XmlElement("AnnulmentReconcile", typeof(ForcedAcknowledgementRequestAnnulmentReconcile))]
        [XmlElement("AnnulmentServiceProvided", typeof(ForcedAcknowledgementRequestAnnulmentServiceProvided))]
        [XmlElement("Reconcile", typeof(ForcedAcknowledgementRequestReconcile))]
        [XmlElement("ServiceProvided", typeof(ForcedAcknowledgementRequestServiceProvided))]
        public object Item { get; set; }

        [XmlAttribute]
        public string originatorId { get; set; }
    }
}
