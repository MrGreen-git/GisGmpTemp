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
        /// Дата и время нарушения
        /// </summary>
        [XmlAttribute("offenseDate")]
        public DateTime OffenseDate { get; set; }

        /// <summary>
        /// Место нарушения
        /// </summary>
        [XmlAttribute("offensePlace")]
        public string OffensePlace { get; set; }
        
        /// <summary>
        /// Статья нарушения
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct { get; set; }

        /// <summary>
        /// Ссылка на фото (видео) материалов нарушения
        /// </summary>
        [XmlAttribute("digitalLink")]
        public string DigitalLink { get; set; }

        /// <summary>
        /// Данные о подразделении, вынесшем постановление
        /// </summary>
        [XmlAttribute("departmentName")]
        public string DepartmentName { get; set; }
    }
}
