using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    /// <summary>
    /// Запрос на проведение (отмену) принудительного квитирования/установление (отмену факта установления) извещению о приеме к исполнению распоряжения статуса "Услуга предоставлена"
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0", IsNullable = false)]
    public class ForcedAcknowledgementRequest : RequestType
    {
        [XmlElement("AnnulmentReconcile", typeof(AnnulmentReconcile))]
        [XmlElement("AnnulmentServiceProvided", typeof(AnnulmentServiceProvided))]
        [XmlElement("Reconcile", typeof(Reconcile))]
        [XmlElement("ServiceProvided", typeof(ServiceProvided))]
        public object Item { get; set; }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }
    }
}
