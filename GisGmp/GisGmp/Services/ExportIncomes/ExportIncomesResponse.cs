﻿using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportIncomes
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0", IsNullable = false)]
    public class ExportIncomesResponse : ResponseType
    {
        [XmlElement("IncomeInfo")]
        public ExportIncomesResponseIncomeInfo[] IncomeInfo { get; set; }

        [XmlAttribute]
        public bool hasMore { get; set; }
    }
}
