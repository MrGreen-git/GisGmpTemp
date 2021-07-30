﻿using GisGmp.Clarification;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportClarification
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
    public class ClarificationInfo : ClarificationType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}