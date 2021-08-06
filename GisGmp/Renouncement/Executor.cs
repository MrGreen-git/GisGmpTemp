using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    /// <summary>
    /// Данные должностного лица (исполнителя), вынесшего постановление об отказе
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public class Executor
    {
        /// <summary>
        /// Код ВКСП
        /// </summary>
        [XmlAttribute("VKSPCode")]
        public string VKSPCode { get; set; }

        /// <summary>
        /// Наименование структурного подразделения ФССП
        /// </summary>
        [XmlAttribute("structuralUnitName")]
        public string StructuralUnitName { get; set; }

        /// <summary>
        /// Адрес структурного подразделения ФССП России
        /// </summary>
        [XmlAttribute("structuralUnitAddress")]
        public string StructuralUnitAddress { get; set; }

        /// <summary>
        /// Населенный пункт структурного подразделения ФССП России
        /// </summary>
        [XmlAttribute("structuralLocality")]
        public string StructuralLocality { get; set; }

        /// <summary>
        /// ФИО судебного пристава-исполнителя
        /// </summary>
        [XmlAttribute("executorFullName")]
        public string ExecutorFullName { get; set; }
    }
}
