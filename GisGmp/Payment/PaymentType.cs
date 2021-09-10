using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [XmlInclude(typeof(ImportedPaymentType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    public class PaymentType : PaymentBaseType
    {
        /// <summary/>
        protected PaymentType() { }

        /// <summary/>
        public PaymentType(PaymentType payment) => Clone.Field(this, payment);

        public PaymentType(
            string paymentId,
            string purpose,
            ulong amount,
            DateTime paymentDate,
            TransKindType transKind,
            PaymentOrgType paymentOrg,
            Payee payee
            ) 
            : base(paymentOrg, payee, purpose, amount, transKind)
        {  
            PaymentId = paymentId;           
            PaymentDate = paymentDate;  
        }

        /// <summary>
        /// Поле номер 2009 Информация о частичном платеже | not required
        /// </summary>
        public PartialPayt PartialPayt { get; set; }

        /// <summary>
        /// УПНО (УИП) | required
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Поле номер 2001: Дата, а также сведения о периоде времени, в который осуществлен прием к исполнению распоряжения о переводе денежных средств(до 21 часа или после 21 часа по местному времени), либо время приема к исполнению распоряжения о переводе денежных средств
        /// required
        /// </summary>
        [XmlAttribute("paymentDate")]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Поле номер 37: Дата отсылки(вручения) плательщику документов в случае, если эти документы были отосланы(вручены) получателем средств плательщику
        /// not required
        /// </summary>
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime DeliveryDate { get; set; }

        [XmlIgnore]
        public bool DeliveryDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 2002: Идентификатор учетной записи пользователя в ЕСИА
        /// not required
        /// </summary>
        [XmlAttribute]
        public string ESIA_ID { get; set; }
    }
}
