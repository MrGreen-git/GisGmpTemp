using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Тип для хранения реквизитов платежного документа.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class ClarificationApplicationType
    {
        /// <summary>
        /// Реквизиты уточняемого платежного документа.
        /// </summary>
        public originalDetailType OriginalDetails { get; set; }

        /// <summary>
        /// Новые реквизиты платежного документа.
        /// </summary>
        public setDetailType SetDetails { get; set; }

        /// <summary>
        /// Указывается уникальный цифровой порядковый номер строки распоряжения в пределах оформляемого распоряжения.
        /// </summary>
        [XmlAttribute("ordinalNumber")]
        public string OrdinalNumber { get; set; }

        /// <summary>
        /// Указывается наименование уточняемого документа.
        /// </summary>
        [XmlAttribute("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Код платежного документа
        /// </summary>
        [XmlAttribute("appCode")]
        public AppCode AppCode { get; set; }

        [XmlIgnore]
        public bool AppCodeSpecified { get; set; }

        /// <summary>
        /// Номер уточняемого платежного документа.
        /// </summary>
        [XmlAttribute]
        public string AppNum { get; set; }

        /// <summary>
        /// Дата уточняемого платежного документа.
        /// </summary>
        [XmlAttribute("appDate", DataType = "date")]
        public DateTime AppDate { get; set; }

        [XmlIgnore]
        public bool AppDateSpecified { get; set; }

        /// <summary>
        /// Указывается УИЗ извещения о зачислении, в отношении которого формируется уведомление об уточнении вида и принадлежности платежа.
        /// </summary>
        [XmlAttribute("incomeId")]
        public string IncomeId { get; set; }

        /// <summary>
        /// Указывается номер распоряжения, полученного территориальным органом Федерального казначейства в качестве приложения к выписке из казначейского счета.
        /// </summary>
        [XmlAttribute("applicationNumber")]
        public string ApplicationNumber { get; set; }

        /// <summary>
        /// Указывается дата распоряжения, полученного территориальным органом Федерального казначейства в качестве приложения к выписке из казначейского счета.
        /// </summary>
        [XmlAttribute("applicationDate", DataType = "date")]
        public DateTime ApplicationDate { get; set; }

        [XmlIgnore]
        public bool ApplicationDateSpecified { get; set; }
    }
}
