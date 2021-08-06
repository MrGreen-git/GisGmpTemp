using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные пользователя, полученные информационной системой Участника из ЕСИА
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class EsiaUserInfoType
    {
        [XmlElement("IndividualBusiness", typeof(IndividualBusiness))]
        [XmlElement("Person", typeof(DebtorPerson))]
        public object Item { get; set; }

        /// <summary>
        /// Уникальный идентификатор учетной записи пользователя в системе ЕСИА
        /// </summary>
        [XmlAttribute("userId", DataType = "integer")]
        public string UserId { get; set; }

        /// <summary>
        /// Уникальный идентификатор сессии пользователя в системе ЕСИА
        /// </summary>
        [XmlAttribute("sessionIndex")]
        public string SessionIndex { get; set; }

        /// <summary>
        /// Дата и время открытия сессии пользователя в системе ЕСИА
        /// </summary>
        [XmlAttribute("sessionDate")]
        public DateTime SessionDate { get; set; }

        [XmlIgnore]
        public bool SessionDateSpecified { get; set; }
    }
}
