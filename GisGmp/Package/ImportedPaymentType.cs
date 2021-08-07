using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedPaymentType : PaymentType
    {
        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор платежа в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// Способ оплаты начисления.
        /// </summary>
        [XmlAttribute("paymentMethod")]
        public PaymentMethod PaymentMethod { get; set; }

        [XmlIgnore]
        public bool PaymentMethodSpecified { get; set; }

        /// <summary>
        /// КПР
        /// </summary>
        [XmlAttribute("requisiteCheckCode")]
        public string RequisiteCheckCode { get; set; }
    }
}
