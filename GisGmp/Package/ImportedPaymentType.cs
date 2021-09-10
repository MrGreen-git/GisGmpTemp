using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedPaymentType : PaymentType
    {
        /// <summary/>
        protected ImportedPaymentType() { }

        /// <summary/>
        public ImportedPaymentType(string id, PaymentType payment) : base(payment) => Id = id;
        
        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего сущность | not required
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор запроса | required
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// Способ оплаты | not required
        /// </summary>
        [XmlAttribute("paymentMethod")]
        public PaymentMethod PaymentMethod { get; set; }

        [XmlIgnore]
        public bool PaymentMethodSpecified { get; set; }

        /// <summary>
        /// Код проверки реквизитов (КПР) | not required
        /// </summary>
        [XmlAttribute("requisiteCheckCode")]
        public string RequisiteCheckCode { get; set; }
    }
}
