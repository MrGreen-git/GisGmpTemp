﻿using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Запрос на предоставление информации о результатах квитирования
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0", IsNullable = false)]
    public class ExportQuittancesRequest : ExportRequestType
    {
        /// <summary/>
        protected ExportQuittancesRequest() { }

        /// <summary/>
        public ExportQuittancesRequest(ExportRequestType config, QuittancesExportConditions exportConditions)
            : base(config) => QuittancesExportConditions = exportConditions;


        /// <summary>
        /// Условия для предоставления информации о результатах квитирования
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
        public QuittancesExportConditions QuittancesExportConditions 
        {
            get => QuittancesExportConditionsField;
            set => QuittancesExportConditionsField = value;
        }

        QuittancesExportConditions QuittancesExportConditionsField;
    }
}
