using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportIncomes
{
    /// <summary>
    /// Ответ на запрос предоставления информации о зачислении
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0", IsNullable = false)]
    public class ExportIncomesResponse : ResponseType
    {
        /// <summary/>
        protected ExportIncomesResponse() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore">Признак конца выборки</param>
        public ExportIncomesResponse(ResponseType config, bool hasMore)
            : base(config) => HasMore = hasMore;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore">Признак конца выборки</param>
        /// <param name="incomeInfo"></param>
        public ExportIncomesResponse(ResponseType config, bool hasMore, IncomeInfo[] incomeInfo)
            : this(config, hasMore) => IncomeInfo = incomeInfo;


        /// <summary>
        /// <para>Признак конца выборки:</para>
        /// <para>false - достигнут конец выборки;</para>
        /// <para>true - после последнего предоставленного элемента в выборке имеются другие.</para>
        /// <para>required: true</para>  
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }


        /// <summary>
        /// Извещение о зачислении
        /// </summary>
        [XmlElement("IncomeInfo")]
        public IncomeInfo[] IncomeInfo 
        {
            get => IncomeInfoField;
            set => IncomeInfoField = value;
        }

        IncomeInfo[] IncomeInfoField;
    }
}
