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
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// Поле номер 1001: Дата, до которой(включительно) актуально выставленное начисление.
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("validUntil", DataType = "date")]
        public DateTime ValidUntil { get; set; }   //TODO specified

        [XmlIgnore]
        public bool ValidUntilSpecified { get; set; }

        /// <summary>
        /// Поле номер 7: Сумма начисления
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// <para>use: required</para>
        /// <para>length: 0..210</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Поле номер 104: КБК
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; } //TODO type

        /// <summary>
        /// Поле номер 105: Код ОКТМО
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; } //TODO type

        /// <summary>
        /// Поле номер 37: Дата отсылки(вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime DeliveryDate { get; set; } //TODO specified

        [XmlIgnore]
        public bool DeliveryDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 1010: Информация о нормативном правовом(правовом) акте, являющемся основанием для исчисления суммы денежных средств, подлежащих уплате
        /// <para>use: not required</para>
        /// <para>length: 0..255</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct { get; set; }

        /// <summary>
        /// Поле номер 19: Срок оплаты начисления в соответствии с нормативным правовым(правовым) актом
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("paymentTerm", DataType = "date")]
        public DateTime PaymentTerm { get; set; } //TODO specified

        [XmlIgnore]
        public bool PaymentTermSpecified { get; set; }

        /// <summary>
        /// Поле номер 1002: Признак предварительного начисления
        /// <para>use: not required</para>
        /// <para>value: PRIOR</para>
        /// <para>value: TEMP</para>
        /// </summary>
        [XmlAttribute("origin")]
        public string Origin { get; set; } //TODO value enum
    }
}
