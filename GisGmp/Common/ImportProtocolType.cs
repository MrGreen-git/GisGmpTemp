using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ImportProtocolType
    {
        /// <summary>
        /// Идентификатор сущности в пакете
        /// </summary>
        [XmlAttribute("entityID", DataType = "ID")]
        public string EntityID { get; set; }

        /// <summary>
        /// Код результата обработки: 0 — если запрос успешно принят или код ошибки в случае отказа в приеме к обработке документа
        /// </summary>
        [XmlAttribute("code")]
        public string Code { get; set; }

        /// <summary>
        /// Описание результата обработки
        /// </summary>
        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}
