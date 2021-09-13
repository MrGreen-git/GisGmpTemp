using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    [XmlRoot("AdditionalOffense", Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0", IsNullable = false)]
    public class OffenseType
    {
        /// <summary/>
        protected OffenseType() { }

        /// <summary/>
        public OffenseType(
            DateTime offenseDate,
            string offensePlace,
            string legalAct,
            string digitalLink,
            string departmentName
            ) 
        { 
            OffenseDate = offenseDate;
            OffensePlace = offensePlace;
            LegalAct = legalAct;
            DigitalLink = digitalLink;
            DepartmentName = departmentName;
        }

        /// <summary>
        /// Поле номер 1401: Дата и время нарушения | required
        /// </summary>
        [XmlAttribute("offenseDate")]
        public DateTime OffenseDate { get; set; }

        /// <summary>
        /// Поле номер 1402: Место нарушения | required
        /// </summary>
        [XmlAttribute("offensePlace")]
        public string OffensePlace { get; set; }

        /// <summary>
        /// Поле номер 1403: Статья нарушения | required
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct { get; set; }

        /// <summary>
        /// Поле номер 1404: Ссылка на фото (видео) материалы фиксации нарушения | required
        /// </summary>
        [XmlAttribute("digitalLink")]
        public string DigitalLink { get; set; }

        /// <summary>
        /// Поле номер 1406: Данные о подразделении, вынесшем постановлен | required
        /// </summary>
        [XmlAttribute("departmentName")]
        public string DepartmentName { get; set; }
    }
}
