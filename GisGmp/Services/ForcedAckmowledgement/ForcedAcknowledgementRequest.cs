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
        /// <summary/>
        protected ForcedAcknowledgementRequest() { }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, AnnulmentReconcile annulmentReconcile, URNType originatorId = default)
            : base(config)
        {
            Item = annulmentReconcile;
            OriginatorId = originatorId;
        }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, AnnulmentServiceProvided annulmentServiceProvided, URNType originatorId = default)
            : base(config)
        {
            Item = annulmentServiceProvided;
            OriginatorId = originatorId;
        }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, Reconcile reconcile, URNType originatorId = default)
            : base(config)
        {
            Item = reconcile;
            OriginatorId = originatorId;
        }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, ServiceProvided serviceProvided, URNType originatorId = default)
            : base(config)
        {
            Item = serviceProvided;
            OriginatorId = originatorId;
        }

        [XmlElement("AnnulmentReconcile", typeof(AnnulmentReconcile))]
        [XmlElement("AnnulmentServiceProvided", typeof(AnnulmentServiceProvided))]
        [XmlElement("Reconcile", typeof(Reconcile))]
        [XmlElement("ServiceProvided", typeof(ServiceProvided))]
        public object Item { get; set; }


        [XmlIgnore]
        public AnnulmentReconcile AnnulmentReconcile
        {
            get => Item as AnnulmentReconcile;
            set => Item = value;
        }

        [XmlIgnore]
        public AnnulmentServiceProvided AnnulmentServiceProvided
        {
            get => Item?.GetType() == typeof(AnnulmentServiceProvided) ? (AnnulmentServiceProvided)Item : null;
            set => Item = value;
        }

        [XmlIgnore]
        public Reconcile Reconcile
        {
            get => Item?.GetType() == typeof(Reconcile) ? (Reconcile)Item : null;
            set => Item = value;
        }

        [XmlIgnore]
        public ServiceProvided ServiceProvided
        {
            get => Item?.GetType() == typeof(ServiceProvided) ? (ServiceProvided)Item : null;
            set => Item = value;
        }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }
    }
}
