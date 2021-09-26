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
        protected Executor() { }

        /// <summary>
        /// Данные должностного лица (исполнителя), вынесшего постановление об отказе
        /// </summary>
        /// <param name="vKSPCode">Код по ВКСП</param>
        /// <param name="structuralUnitName">Наименование структурного подразделения ФССП</param>
        /// <param name="structuralUnitAddress">Адрес структурного подразделения ФССП России</param>
        /// <param name="structuralLocality">Населенный пункт структурного подразделения ФССП России</param>
        /// <param name="executorFullName">ФИО судебного пристава-исполнителя</param>
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
        /// Код по ВКСП
        /// <para>use: required</para>
        /// <para>length: 5..5</para>
        /// <para>pattern: "\d{5}"</para>
        /// </summary>
        [XmlAttribute("VKSPCode")]
        public string VKSPCode 
        {
            get => VKSPCodeField;
            set => VKSPCodeField = value.IsRequired().IsLength(min: 5, max: 5);
        }

        string VKSPCodeField;

        /// <summary>
        /// Наименование структурного подразделения ФССП
        /// <para>use: required</para>
        /// <para>length: 1..1000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("structuralUnitName")]
        public string StructuralUnitName 
        {
            get => StructuralUnitNameField;
            set => StructuralUnitNameField = value.IsRequired().IsLength(min: 1, max: 1000);
        }

        string StructuralUnitNameField;

        /// <summary>
        /// Адрес структурного подразделения ФССП России
        /// <para>use: required</para>
        /// <para>length: 1..200</para>
        /// <para>type: com:AdrType</para>
        /// </summary>
        [XmlAttribute("structuralUnitAddress")]
        public string StructuralUnitAddress 
        {
            get => StructuralUnitAddressField;
            set => StructuralUnitAddressField = value.IsRequired().IsLength(min: 1, max: 200);
        }

        string StructuralUnitAddressField;

        /// <summary>
        /// Населенный пункт структурного подразделения ФССП России
        /// <para>use: required</para>
        /// <para>length: 1..80</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("structuralLocality")]
        public string StructuralLocality 
        {
            get => StructuralLocalityField;
            set => StructuralLocalityField = value.IsRequired().IsLength(min: 1, max: 80);
        }

        string StructuralLocalityField;

        /// <summary>
        /// ФИО судебного пристава-исполнителя
        /// <para>use: required</para>       
        /// <para>length: 1..1000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// <para>type: com:FIOFSSPType</para>
        /// </summary>
        [XmlAttribute("executorFullName")]
        public string ExecutorFullName 
        {
            get => ExecutorFullNameField;
            set => ExecutorFullNameField = value.IsRequired().IsLength(min: 1, max: 1000);
        }

        string ExecutorFullNameField;
    }
}
