using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class IncomesConditionsType
    {
        /// <summary/>
        protected IncomesConditionsType() { }

        /// <summary/>
        public IncomesConditionsType(string[] incomeId)
            => IncomeId = incomeId;

        [XmlElement("IncomeId")]
        public string[] IncomeId { get; set; }
    }
}
