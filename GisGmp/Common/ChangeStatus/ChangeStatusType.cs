using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о статусе и основаниях его изменения
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public abstract class ChangeStatusType
    {
        /// <summary>
        /// Статус, отражающий изменение данных: 1 - новый, 2 - уточнение, 3 - аннулирование, 4 - деаннулировании
        /// required
        /// </summary>
        public string Meaning { get; set; }

        /// <summary>
        /// Основание изменения | not required
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Дата, а также сведения о периоде времени, в который осуществлено уточнение информации об уплате (до 21 часа или после 21 часа по местному времени), либо время уточнения информации об уплате
        /// not required
        /// </summary>
        public DateTime ChangeDate { get; set; }

        [XmlIgnore]
        public bool ChangeDateSpecified { get; set; }
    }
}
