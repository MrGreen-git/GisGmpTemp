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
        /// <summary/>
        protected ClarificationApplicationType() { }

        /// <summary/>
        public ClarificationApplicationType(
            originalDetailType originalDetails,
            setDetailType setDetails,
            string ordinalNumber,
            AppCode appCode,
            DateTime appDate
            ) 
        { 
            OriginalDetails = originalDetails;
            SetDetails = setDetails;
            OrdinalNumber = ordinalNumber;
            AppCode = appCode;
            AppDate = appDate;
        }

        /// <summary>
        /// Реквизиты уточняемого платежного документа |> required
        /// </summary>
        public originalDetailType OriginalDetails { get; set; }

        /// <summary>
        /// Новые реквизиты платежного документа |> required
        /// </summary>
        public setDetailType SetDetails { get; set; }

        /// <summary>
        /// Номер п/п |> required
        /// </summary>
        [XmlAttribute("ordinalNumber")]
        public string OrdinalNumber { get; set; }

        /// <summary>
        /// Наименование |> not required
        /// </summary>
        [XmlAttribute("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Код платежного документа |> required
        /// </summary>
        [XmlAttribute("appCode")]
        public AppCode AppCode { get; set; }

        [XmlIgnore]
        public bool AppCodeSpecified { get; set; }

        /// <summary>
        /// Номер платежного документа |> not required
        /// </summary>
        [XmlAttribute("appNum")]
        public string AppNum { get; set; }

        /// <summary>
        /// Дата платежного документа |> required
        /// </summary>
        [XmlAttribute("appDate", DataType = "date")]
        public DateTime AppDate { get; set; }

        [XmlIgnore]
        public bool AppDateSpecified { get; set; }

        /// <summary>
        /// УИЗ |> not required
        /// </summary>
        [XmlAttribute("incomeId")]
        public string IncomeId { get; set; }

        /// <summary>
        /// Номер |> not required
        /// </summary>
        [XmlAttribute("applicationNumber")]
        public string ApplicationNumber { get; set; }

        /// <summary>
        /// Дата |> not required
        /// </summary>
        [XmlAttribute("applicationDate", DataType = "date")]
        public DateTime ApplicationDate { get; set; }

        [XmlIgnore]
        public bool ApplicationDateSpecified { get; set; }
    }
}
