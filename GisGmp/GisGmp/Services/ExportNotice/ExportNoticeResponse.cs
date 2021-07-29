﻿using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0", IsNullable = false)]
    public class ExportNoticeResponse : ResponseType
    {
        public string RoutingCode { get; set; }

        public bool ExportNoticeConfirmation { get; set; }
    }
}
