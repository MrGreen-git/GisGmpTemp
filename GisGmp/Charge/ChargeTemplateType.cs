using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Данные шаблона формирования начисления
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public class ChargeTemplateType : AbstractChargtType
    {
        /// <summary>
        /// Данные организации, являющейся получателем средств
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Сведения о плательщике
        /// </summary>
        public ChargePayer Payer { get; set; }

        /// <summary>
        /// Дополнительные реквизиты платежа, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
        /// </summary>
        public BudgetIndexType BudgetIndex { get; set; }

        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля начисления
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }
    }
}
