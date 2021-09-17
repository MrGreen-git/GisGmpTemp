using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportPayments;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportIncomes
{
    /// <summary>
    /// Запрос на предоставление информации о зачислении
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0", IsNullable = false)]
    public class ExportIncomesRequest : ExportRequestType
    {
        /// <summary/>
        protected ExportIncomesRequest() { }

        public ExportIncomesRequest(ExportRequestType config, IncomesExportConditions exportConditions)
            : base(config) => IncomesExportConditions = exportConditions;


        /// <summary>
        /// Условия для предоставления информации о зачислении
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
        public IncomesExportConditions IncomesExportConditions 
        {
            get => IncomesExportConditionsField; 
            set => IncomesExportConditionsField = value;
        }

        IncomesExportConditions IncomesExportConditionsField;
    }
}
