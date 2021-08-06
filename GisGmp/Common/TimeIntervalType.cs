using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Временной интервал, за который запрашивается информация из ГИС ГМП
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot("TimeInterval", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class TimeIntervalType
    {
        /// <summary>
        /// Начальная дата временного интервала запроса
        /// </summary>
        [XmlAttribute("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Конечная дата временного интервала запроса
        /// </summary>
        [XmlAttribute("endDate")]
        public DateTime EndDate { get; set; }
    }
}
