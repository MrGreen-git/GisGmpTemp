using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Тип для хранения реквизитов уточняемого платежного документа, которые могут быть уточнены, или новых (уточненных) реквизитов.
    /// </summary>
    [XmlInclude(typeof(setDetailType))]
    [XmlInclude(typeof(originalDetailType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class paymentDetailType
    {
        /// <summary>
        /// Указывается наименование получателя уточняемого распоряжения.
        /// </summary>
        [XmlAttribute("payeeName")]
        public string PayeeName { get; set; }

        /// <summary>
        /// Указывается идентификационный номер налогоплательщика - получателя средств.
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Указывается код причины постановки на учет в налоговом органе получателя средств.
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Указывается лицевой счет получателя средств.
        /// </summary>
        [XmlAttribute("payeeAccount")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// Указывается 8-значный код по Общероссийскому классификатору территорий муниципальных образований.
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Указывается код классификации доходов бюджетов, в соответствии с действующей бюджетной классификацией Российской Федерации.
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Указывается код цели субсидии (субвенции).
        /// </summary>
        [XmlAttribute("subsidy")]
        public string Subsidy { get; set; }

        /// <summary>
        /// Указывается назначение платежа.
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Указывается прочая необходимая информация.
        /// </summary>
        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}
