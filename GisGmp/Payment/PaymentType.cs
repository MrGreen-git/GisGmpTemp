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
        protected PaymentType() { }

        public PaymentType(PaymentType payment) => Clone.Field(this, payment);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="purpose">Поле номер 24: Назначение платежа</param>
        /// <param name="amount">Поле номер 7: Сумма платежа</param>
        /// <param name="transKind">Поле номер 18: Вид операции</param>
        /// <param name="paymentOrg">Данные организации, принявшей платеж</param>
        /// <param name="payee">Сведения о получателе средств</param>
        /// <param name="budgetIndex">Поле номер 2007 Реквизиты платежа 101, 106-109</param>
        /// <param name="paymentId">УПНО (УИП)</param>
        /// <param name="paymentDate">Поле номер 2001: Дата, а также сведения о периоде времени, в который осуществлен прием к исполнению распоряжения о переводе денежных средств(до 21 часа или после 21 часа по местному времени), либо время приема к исполнению распоряжения о переводе денежных средств</param>
        public PaymentType(
            string purpose,
            ulong amount,
            TransKindType transKind,
            PaymentOrgType paymentOrg,
            Payee payee,
            BudgetIndexType budgetIndex,
            string paymentId,
            DateTime paymentDate
            ) 
            : base(purpose, amount, transKind, paymentOrg, payee, budgetIndex)
        {  
            PaymentId = paymentId;           
            PaymentDate = paymentDate;  
        }


        /// <summary>
        /// УПНО (УИП)
        /// <para>use: required</para>
        /// <para>type: com:PaymentIdType</para>
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; } //TODO type

        /// <summary>
        /// Поле номер 2001: Дата, а также сведения о периоде времени, в который осуществлен прием к исполнению распоряжения о переводе денежных средств(до 21 часа или после 21 часа по местному времени), либо время приема к исполнению распоряжения о переводе денежных средств
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("paymentDate")]
        public DateTime PaymentDate { get; set; }

        [XmlIgnore]
        public bool DeliveryDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 37: Дата отсылки(вручения) плательщику документов в случае, если эти документы были отосланы(вручены) получателем средств плательщику
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Поле номер 2002: Идентификатор учетной записи пользователя в ЕСИА
        /// <para>use: not required</para>
        /// <para>length: 1..255</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute]
        public string ESIA_ID { get; set; }

        /// <summary>
        /// Поле номер 2009 Информация о частичном платеже
        /// <para>use: not required</para>
        /// </summary>
        public PartialPayt PartialPayt { get; set; }  
    }
}
