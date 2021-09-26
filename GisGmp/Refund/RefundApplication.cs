using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Данные заявки на возврат
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundApplication
    {
        protected RefundApplication() { }

        /// <summary>
        /// Данные заявки на возврат
        /// </summary>
        /// <param name="appNum">Поле номер 3: Номер, присвоенный организацией, формирующей Заявку на возврат в ТОФК</param>
        /// <param name="appDate">Поле номер 4: Дата, на которую сформирована Заявка на возврат в ТОФК</param>
        /// <param name="paymentId">Поле номер 2000: Уникальный присваиваемый номер операции(УПНО), подлежащего возврату</param>
        /// <param name="cashType">Поле номер 3004: Вид средств для осуществления возврата</param>
        /// <param name="amount">Поле номер 7: Сумма возврата</param>
        /// <param name="purpose">Поле номер 24: Назначение платежа</param>
        public RefundApplication(string appNum, DateTime appDate, PaymentIdType paymentId, int cashType, ulong amount, string purpose)
        {
            AppNum = appNum;
            AppDate = appDate;
            PaymentId = paymentId;
            CashType = cashType;
            Amount = amount;
            Purpose = purpose;
        }

        /// <summary>
        /// Поле номер 3: Номер, присвоенный организацией, формирующей Заявку на возврат в ТОФК
        /// <para>use: required</para>
        /// <para>length: 1..15</para>
        /// </summary>
        [XmlAttribute("appNum")]
        public string AppNum
        {
            get => AppNumField;
            set => AppNumField = value.IsRequired().IsLength(min: 1, max: 15);
        }

        string AppNumField;

        /// <summary>
        /// Поле номер 4: Дата, на которую сформирована Заявка на возврат в ТОФК
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("appDate", DataType = "date")]
        public DateTime AppDate { get; set; }

        /// <summary>
        /// Поле номер 2000: Уникальный присваиваемый номер операции(УПНО), подлежащего возврату
        /// <para>use: required</para>
        /// </summary>
        [XmlIgnore]
        public PaymentIdType PaymentId
        {
            get => PaymentIdField;
            set => PaymentIdField = value.IsRequired();
        }

        PaymentIdType PaymentIdField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("paymentId")]
        public string WrapperPaymentId { get => PaymentId; set => PaymentId = value; }

        /// <summary>
        /// Поле номер 3004: Вид средств для осуществления возврата
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("cashType")]
        public int CashType { get; set; }  //TODO enum

        /// <summary>
        /// Поле номер 7: Сумма возврата
        /// <para>use: required</para>
        /// <para>value: 1..max</para>
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// <para>use: required</para>
        /// <para>length: 0..210</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose
        {
            get => PurposeField;
            set => PurposeField = value.IsRequired().IsLength(min: 0, max: 210);
        }

        string PurposeField;
    }
}
