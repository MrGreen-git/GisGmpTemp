using System;
using System.Xml.Serialization;

namespace GisGmp.Common.NSI
{
    /// <summary>
    /// Реквизиты счета организации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public class OrgKS
    {
        /// <summary>
        /// Номер казначейского счета
        /// </summary>
        [XmlAttribute]
        public string KSNumber { get; set; }

        /// <summary>
        /// БИК ТОФК
        /// </summary>
        [XmlAttribute("bik")]
        public string Bik { get; set; }

        /// <summary>
        /// Номер единого казначейского счета
        /// </summary>
        [XmlAttribute]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Статус казначейского счета
        /// </summary>
        [XmlAttribute("statKS")]
        public StatKS StatKS { get; set; }

        /// <summary>
        /// Дата вступления изменений в силу
        /// </summary>
        [XmlAttribute("dateIn", DataType = "date")]
        public DateTime DateIn { get; set; }
    }
}
