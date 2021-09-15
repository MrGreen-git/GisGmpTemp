using System;
using System.Xml.Serialization;

namespace GisGmp.Common.NSI
{
    /// <summary>
    /// Данные о нормативно-справочной информации о коде по ОКТМО
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public class oktmoNSIInfoType
    {
        /// <summary/>
        protected oktmoNSIInfoType() { }

        /// <summary/>
        public oktmoNSIInfoType(
            string regionCode,
            string areaCode,
            string cityCode,
            string localCode,
            string controlNum,
            string section,
            string code,
            string name,
            string lastChangeNum,
            LastChangeType lastChangeType,
            DateTime changeDate,
            DateTime introductionDate,
            DateTime updateDate
            )
        { 
            RegionCode = regionCode;
            AreaCode = areaCode;
            CityCode = cityCode;
            LocalCode = localCode;
            ControlNum = controlNum;
            Section = section;
            Code = code;
            Name = name;
            LastChangeNum = lastChangeNum;
            LastChangeType = lastChangeType;
            ChangeDate = changeDate;
            IntroductionDate = introductionDate;
            UpdateDate = updateDate;
        }

        /// <summary>
        /// Код региона | required
        /// </summary>
        [XmlAttribute("regionCode")]
        public string RegionCode { get; set; }

        /// <summary>
        /// Код района/города МО | required
        /// </summary>
        [XmlAttribute("areaCode")]
        public string AreaCode { get; set; }

        /// <summary>
        /// Код поселения МО | required
        /// </summary>
        [XmlAttribute("cityCode")]
        public string CityCode { get; set; }

        /// <summary>
        /// Код населенного пункта МО | required
        /// </summary>
        [XmlAttribute("localCode")]
        public string LocalCode { get; set; }

        /// <summary>
        /// Контрольное число | required
        /// </summary>
        [XmlAttribute("controlNum")]
        public string ControlNum { get; set; }

        /// <summary>
        /// Код раздела | required
        /// </summary>
        [XmlAttribute("section")]
        public string Section { get; set; }

        /// <summary>
        /// Код (совокупный код) | required
        /// </summary>
        [XmlAttribute("code")]
        public string Code { get; set; }

        /// <summary>
        /// Наименование территории | required
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Дополнительная информация | not required
        /// </summary>
        [XmlAttribute("centreName")]
        public string CentreName { get; set; }

        /// <summary>
        /// Описание | not required
        /// </summary>
        [XmlAttribute("clarification")]
        public string Clarification { get; set; }

        /// <summary>
        /// Номер изменения | required
        /// </summary>
        [XmlAttribute("lastChangeNum")]
        public string LastChangeNum { get; set; }

        /// <summary>
        /// Тип изменения | required
        /// </summary>
        [XmlAttribute("lastChangeType")]
        public LastChangeType LastChangeType { get; set; }

        /// <summary>
        /// Дата принятия | required
        /// </summary>
        [XmlAttribute("changeDate", DataType = "date")]
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// Дата введения | required
        /// </summary>
        [XmlAttribute("introductionDate", DataType = "date")]
        public DateTime IntroductionDate { get; set; }

        /// <summary>
        /// Дата и время обновления справочника | required
        /// </summary>
        [XmlAttribute("updateDate")]
        public DateTime UpdateDate { get; set; }
    }
}
