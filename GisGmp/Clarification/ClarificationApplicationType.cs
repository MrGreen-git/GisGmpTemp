using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Реквизиты платежного документа
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class ClarificationApplicationType
    {
        protected ClarificationApplicationType() { }

        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        /// <param name="ordinalNumber">Номер п/п</param>
        /// <param name="appCode">Код платежного документа</param>
        /// <param name="appDate">Дата платежного документа</param>
        /// <param name="originalDetails">Реквизиты уточняемого платежного документа</param>
        /// <param name="setDetails">Новые реквизиты платежного документа</param>
        public ClarificationApplicationType(
            string ordinalNumber,
            AppCode appCode,
            DateTime appDate,
            originalDetailType originalDetails,
            setDetailType setDetails                              
            ) 
        {
            OrdinalNumber = ordinalNumber;
            AppCode = appCode;
            AppDate = appDate;
            OriginalDetails = originalDetails;
            SetDetails = setDetails;                                
        }


        /// <summary>
        /// Номер п/п
        /// <para>use: required</para>
        /// <para>length: 1..7</para>
        /// <para>pattern: "\w+"</para>
        /// </summary>
        [XmlAttribute("ordinalNumber")]
        public string OrdinalNumber { get; set; }

        /// <summary>
        /// Наименование
        /// <para>use: not required</para>
        /// <para>length: 0..160</para>
        /// </summary>
        [XmlAttribute("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Код платежного документа
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("appCode")]
        public AppCode AppCode { get; set; }

        [XmlIgnore]
        public bool AppCodeSpecified { get; set; }

        /// <summary>
        /// Номер платежного документа
        /// <para>use: not required</para>
        /// <para>length: 1..20</para>
        /// </summary>
        [XmlAttribute("appNum")]
        public string AppNum { get; set; }

        /// <summary>
        /// Дата платежного документа
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("appDate", DataType = "date")]
        public DateTime AppDate { get; set; }

        [XmlIgnore]
        public bool AppDateSpecified { get; set; }

        /// <summary>
        /// УИЗ
        /// <para>use: not required</para>
        /// <para>type: com:IncomeIdType</para>
        /// </summary>
        [XmlAttribute("incomeId")]
        public string IncomeId { get; set; }

        /// <summary>
        /// Номер
        /// <para>use: not required</para>
        /// <para>length: 1..15</para>
        /// <para>pattern: "\d+"</para>
        /// </summary>
        [XmlAttribute("applicationNumber")]
        public string ApplicationNumber { get; set; }

        /// <summary>
        /// Дата
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("applicationDate", DataType = "date")]
        public DateTime ApplicationDate { get; set; }

        [XmlIgnore]
        public bool ApplicationDateSpecified { get; set; }

        /// <summary>
        /// Реквизиты уточняемого платежного документа
        /// <para>use: required</para>
        /// </summary>
        public originalDetailType OriginalDetails { get; set; }

        /// <summary>
        /// Новые реквизиты платежного документа
        /// <para>use: required</para>
        /// </summary>
        public setDetailType SetDetails { get; set; }  
    }
}
