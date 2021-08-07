using GisGmp.Charge;
using GisGmp.Common;
using System;
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
        /// Данные для формирования необходимой для уплаты информации
        /// </summary>
        public ChargeTemplateType ChargeTemplate { get; set; }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }
    }
}
