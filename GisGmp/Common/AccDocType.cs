using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class AccDocType
    {
        /// <summary>
        /// Поле номер 3. Для частичного платежа поле номер 40: Номер платежного документа
        /// </summary>
        [XmlAttribute("accDocNo")]
        public string AccDocNo { get; set; }

        /// <summary>
        /// Поле номер 4. Для частичного платежа поле номер 41: Дата платежного документа
        /// </summary>
        [XmlAttribute("accDocDate", DataType = "date")]
        public DateTime AccDocDate { get; set; }
    }
}
