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
        /// <summary>
        /// Код региона
        /// </summary>
        [XmlAttribute("regionCode")]
        public string RegionCode { get; set; }

        /// <summary>
        /// Код района/города МО
        /// </summary>
        [XmlAttribute("areaCode")]
        public string AreaCode { get; set; }

        /// <summary>
        /// Код поселения МО
        /// </summary>
        [XmlAttribute("cityCode")]
        public string CityCode { get; set; }

        /// <summary>
        /// Код населенного пункта МО
        /// </summary>
        [XmlAttribute("localCode")]
        public string LocalCode { get; set; }

        /// <summary>
        /// Контрольное число
        /// </summary>
        [XmlAttribute("controlNum")]
        public string ControlNum { get; set; }

        /// <summary>
        /// Код раздела
        /// </summary>
        [XmlAttribute("section")]
        public string Section { get; set; }

        /// <summary>
        /// Код (совокупный код)
        /// </summary>
        [XmlAttribute("code")]
        public string Code { get; set; }

        /// <summary>
        /// Наименование территории
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Дополнительная информация
        /// </summary>
        [XmlAttribute("centreName")]
        public string CentreName { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [XmlAttribute("clarification")]
        public string Clarification { get; set; }

        /// <summary>
        /// Номер изменения
        /// </summary>
        [XmlAttribute("lastChangeNum")]
        public string LastChangeNum { get; set; }

        /// <summary>
        /// Тип изменения
        /// </summary>
        [XmlAttribute("lastChangeType")]
        public LastChangeType LastChangeType { get; set; }

        /// <summary>
        /// Дата принятия
        /// </summary>
        [XmlAttribute("changeDate", DataType = "date")]
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// Дата введения
        /// </summary>
        [XmlAttribute("introductionDate", DataType = "date")]
        public DateTime IntroductionDate { get; set; }

        /// <summary>
        /// Дата и время обновления справочника
        /// </summary>
        [XmlAttribute("updateDate")]
        public DateTime UpdateDate { get; set; }
    }

}
