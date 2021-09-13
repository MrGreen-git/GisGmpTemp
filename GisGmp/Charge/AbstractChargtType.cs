using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Общие атрибуты для начисления и шаблона формирования начисления
    /// </summary>
    [XmlInclude(typeof(ChargeTemplateType))]
    [XmlInclude(typeof(ChargeType))]
    [XmlInclude(typeof(ImportedChargeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public abstract class AbstractChargtType
    {
        /// <summary>
        /// Поле номер 4: Дата, а также сведения о периоде времени, в который осуществлено начисление суммы денежных средств, подлежащих уплате(до 21 часа или после 21 часа по местному времени), либо время начисления суммы денежных средств, подлежащих уплате
        /// required
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// Поле номер 1001: Дата, до которой(включительно) актуально выставленное начисление.
        /// not required
        /// </summary>
        [XmlAttribute("validUntil", DataType = "date")]
        public DateTime ValidUntil { get; set; }

        [XmlIgnore]
        public bool ValidUntilSpecified { get; set; }

        /// <summary>
        /// Поле номер 7: Сумма начисления | required
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа | required
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Поле номер 104: КБК | required
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Поле номер 105: Код ОКТМО | required
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Поле номер 37: Дата отсылки(вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// not required
        /// </summary>
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime DeliveryDate { get; set; }

        [XmlIgnore]
        public bool DeliveryDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 1010: Информация о нормативном правовом(правовом) акте, являющемся основанием для исчисления суммы денежных средств, подлежащих уплате
        /// not required
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct { get; set; }

        /// <summary>
        /// Поле номер 19: Срок оплаты начисления в соответствии с нормативным правовым(правовым) актом | not required
        /// </summary>
        [XmlAttribute("paymentTerm", DataType = "date")]
        public DateTime PaymentTerm { get; set; }

        [XmlIgnore]
        public bool PaymentTermSpecified { get; set; }

        /// <summary>
        /// Поле номер 1002: Признак предварительного начисления | not required
        /// </summary>
        [XmlAttribute("origin")]
        public string Origin { get; set; }
    }
}
