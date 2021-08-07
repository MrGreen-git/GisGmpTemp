﻿using GisGmp.Common.NSI;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    /// <summary>
    /// Уведомление об изменении нормативно-справочной информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
    public class NoticeNSI
    {
        [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
        [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
        public object[] Items { get; set; }

        /// <summary>
        /// Код справочника
        /// </summary>
        [XmlAttribute("directoryCode")]
        public string DirectoryCode { get; set; }
    }
}
