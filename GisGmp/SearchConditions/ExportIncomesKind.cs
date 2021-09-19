using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    public enum ExportIncomesKind
    {
        /// <summary>
        /// INCOME
        /// </summary>
        [XmlEnum("INCOME")]
        Income,
    }
}
