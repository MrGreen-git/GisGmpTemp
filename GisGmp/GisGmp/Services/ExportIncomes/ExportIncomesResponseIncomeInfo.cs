using GisGmp.Common;
using GisGmp.Income;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportIncomes
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
    public class ExportIncomesResponseIncomeInfo : IncomeType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
