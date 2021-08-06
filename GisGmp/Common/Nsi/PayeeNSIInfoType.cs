using System;
using System.Xml.Serialization;

namespace GisGmp.Common.NSI
{
    /// <summary>
    /// Данные о нормативно-справочной информации об участнике - получателе средств
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public class PayeeNSIInfoType
    {
        /// <summary>
        /// Перечень КБК
        /// </summary>
        [XmlArrayItem("kbk", IsNullable = false)]
        public string[] KBKlist { get; set; }

        /// <summary>
        /// Перечень реквизитов счетов организации
        /// </summary>
        [XmlArrayItem("OrgKS", IsNullable = false)]
        public OrgKS[] OrgKSllist { get; set; }

        /// <summary>
        /// Наименование организации
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// ИНН организации
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП организации
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Код Главы по бюджетной классификации
        /// </summary>
        [XmlAttribute("kbkGlavaCode")]
        public string KbkGlavaCode { get; set; }

        /// <summary>
        /// Код статуса организации
        /// </summary>
        [XmlAttribute("orgStatus")]
        public OrgStatus OrgStatus { get; set; }

        /// <summary>
        /// Дата и время обновления справочника
        /// </summary>
        [XmlAttribute("updateDate")]
        public DateTime UpdateDate { get; set; }
    }
}
