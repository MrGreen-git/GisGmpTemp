using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class AdditionalDataType
    {
        /// <summary>
        /// Наименование поля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение поля
        /// </summary>
        public string Value { get; set; }
    }
}
