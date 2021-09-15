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
        /// <summary/>
        protected PayeeNSIInfoType() { }

        /// <summary/>
        public PayeeNSIInfoType(
            string[] kBKlist,
            string name,
            string inn,
            string kpp,
            OrgStatus orgStatus,
            DateTime updateDate
            ) 
        {  
            KBKlist = kBKlist;
            Name = name;
            Inn = inn;
            Kpp = kpp;
            OrgStatus = orgStatus;
            UpdateDate = updateDate;
        }

        /// <summary>
        /// Перечень КБК | required
        /// </summary>
        [XmlArrayItem("kbk", IsNullable = false)]
        public string[] KBKlist { get; set; }

        /// <summary>
        /// Перечень реквизитов счетов организации | not required
        /// </summary>
        [XmlArrayItem("OrgKS", IsNullable = false)]
        public OrgKS[] OrgKSllist { get; set; }

        /// <summary>
        /// Наименование организации | required
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// ИНН организации | required
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП организации | required
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Код Главы по БК | not required
        /// </summary>
        [XmlAttribute("kbkGlavaCode")]
        public string KbkGlavaCode { get; set; }

        /// <summary>
        /// Код статуса организации | required
        /// </summary>
        [XmlAttribute("orgStatus")]
        public OrgStatus OrgStatus { get; set; }

        /// <summary>
        /// Дата и время обновления справочника | required
        /// </summary>
        [XmlAttribute("updateDate")]
        public DateTime UpdateDate { get; set; }
    }
}
