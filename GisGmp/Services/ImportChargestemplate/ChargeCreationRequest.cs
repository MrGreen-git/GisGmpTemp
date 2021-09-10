using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportChargestemplate
{
    /// <summary>
    /// Прием запроса на формирование необходимой для уплаты информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0", IsNullable = false)]
    public class ChargeCreationRequest : RequestType
    {
        /// <summary>
        protected ChargeCreationRequest() { }

        /// <summary>
        public ChargeCreationRequest(RequestType config, ChargeTemplateType chargeTemplate)
            : base(config) => ChargeTemplate = chargeTemplate;

        public ChargeCreationRequest(RequestType config, ChargeTemplateType chargeTemplate, URNType originatorId)
            : this(config, chargeTemplate) => OriginatorId = originatorId;

        /// <summary>
        /// Данные для формирования необходимой для уплаты информации
        /// </summary>
        public ChargeTemplateType ChargeTemplate
        {
            get => ChargeTemplateField;
            set => ChargeTemplateField = Validator.IsNull(value: value, nameof(ChargeTemplate));
        }

        ChargeTemplateType ChargeTemplateField;

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlIgnore]
        public URNType OriginatorId { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("originatorId")]
        public string WrapperOriginatorId { get; set; }
    }
}
