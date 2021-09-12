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
        /// <summary/>
        protected Executor() { }

        /// <summary/>
        public Executor(
             string vKSPCode,
             string structuralUnitName,
             string structuralUnitAddress,
             string structuralLocality,
             string executorFullName
            )
        {
            VKSPCode = vKSPCode;
            StructuralUnitName = structuralUnitName;
            StructuralUnitAddress = structuralUnitAddress;
            StructuralLocality = structuralLocality;
            ExecutorFullName = executorFullName;
        }

        /// <summary>
        /// Код по ВКСП | required
        /// </summary>
        [XmlAttribute("VKSPCode")]
        public string VKSPCode { get; set; }

        /// <summary>
        /// Наименование структурного подразделения ФССП | required
        /// </summary>
        [XmlAttribute("structuralUnitName")]
        public string StructuralUnitName { get; set; }

        /// <summary>
        /// Адрес структурного подразделения ФССП России | required
        /// </summary>
        [XmlAttribute("structuralUnitAddress")]
        public string StructuralUnitAddress { get; set; }

        /// <summary>
        /// Населенный пункт структурного подразделения ФССП России | required
        /// </summary>
        [XmlAttribute("structuralLocality")]
        public string StructuralLocality { get; set; }

        /// <summary>
        /// ФИО судебного пристава-исполнителя | required
        /// </summary>
        [XmlAttribute("executorFullName")]
        public string ExecutorFullName { get; set; }
    }
}
