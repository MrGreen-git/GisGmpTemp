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
        private ForcedAcknowledgementRequest(RequestType config, URNType originatorId)
            : base(config) => OriginatorId = originatorId;

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, AnnulmentReconcile annulmentReconcile, URNType originatorId = default)
            : this(config, originatorId) => AnnulmentReconcile = annulmentReconcile;
            
        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, AnnulmentServiceProvided annulmentServiceProvided, URNType originatorId = default)
            : this(config, originatorId) => AnnulmentServiceProvided = annulmentServiceProvided;
            
        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, Reconcile reconcile, URNType originatorId = default)
            : this(config, originatorId) => Reconcile = reconcile;

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, ServiceProvided serviceProvided, URNType originatorId = default)
            : this(config, originatorId) => ServiceProvided = serviceProvided;

        


        /// <summary>
        /// |> required
        /// </summary>
        [XmlElement("AnnulmentReconcile", typeof(AnnulmentReconcile))]
        [XmlElement("AnnulmentServiceProvided", typeof(AnnulmentServiceProvided))]
        [XmlElement("Reconcile", typeof(Reconcile))]
        [XmlElement("ServiceProvided", typeof(ServiceProvided))]
        public object Item { get; set; }

        /// <summary>
        /// Отмена принудительного квитирования начисления с платежами |> required
        /// </summary>
        [XmlIgnore]
        public AnnulmentReconcile AnnulmentReconcile
        {
            get => Item as AnnulmentReconcile;
            set => Item = value;
        }

        /// <summary>
        /// Отмена факта установления платежу признака «Услуга предоставлена»
        /// </summary>
        [XmlIgnore]
        public AnnulmentServiceProvided AnnulmentServiceProvided
        {
            get => Item as AnnulmentServiceProvided;
            set => Item = value;
        }

        /// <summary>
        /// Принудительное квитирование начисления с платежами
        /// </summary>
        [XmlIgnore]
        public Reconcile Reconcile
        {
            get => Item as Reconcile;
            set => Item = value;
        }

        /// <summary>
        /// Установление платежу признака «Услуга предоставлена»
        /// </summary>
        [XmlIgnore]
        public ServiceProvided ServiceProvided
        {
            get => Item as ServiceProvided;
            set => Item = value;
        }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос |> not required
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }
    }
}
