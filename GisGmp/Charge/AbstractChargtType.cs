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
        /// Поле номер 4: Дата, а также сведения о периоде времени, в который осуществлено начисление, либо время начисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// Поле номер 1001: Дата, вплоть до которой актуально выставленное начисление
        /// </summary>
        [XmlAttribute("validUntil", DataType = "date")]
        public DateTime ValidUntil { get; set; }

        [XmlIgnore]
        public bool ValidUntilSpecified { get; set; }

        /// <summary>
        /// Поле номер 7: Сумма начисления (в копейках)
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Поле номер 104: КБК
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Поле номер 105: Код по ОКТМО, указываемый АН или ГАН в соответствии с НПА
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Поле номер 37: Дата отсылки (вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// </summary>
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime DeliveryDate { get; set; }

        [XmlIgnore]
        public bool DeliveryDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 1010: Информация о нормативном правовом (правовом) акте, являющемся основанием для исчисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct { get; set; }

        /// <summary>
        /// Поле номер 19: Срок оплаты начисления в соответствии с нормативным правовым (правовым) актом
        /// </summary>
        [XmlAttribute("paymentTerm", DataType = "date")]
        public DateTime PaymentTerm { get; set; }

        [XmlIgnore]
        public bool PaymentTermSpecified { get; set; }

        /// <summary>
        /// Поле номер 1002: Признак предварительного начисления
        /// </summary>
        [XmlAttribute("origin")]
        public string Origin { get; set; }
    }
}
