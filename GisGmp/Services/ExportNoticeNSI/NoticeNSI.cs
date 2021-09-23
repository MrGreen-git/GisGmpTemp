using GisGmp.Common.NSI;
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
        /// <summary/>
        protected NoticeNSI() { }

        /// <summary/>
        public NoticeNSI(string directoryCode) => DirectoryCode = directoryCode;

        /// <summary>
        /// |> not required
        /// </summary>
        [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
        [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
        public object[] Items { get; set; }

        /// <summary>
        /// Нормативно-справочная информация об участнике-получателе средств
        /// </summary>
        [XmlIgnore]
        public PayeeNSIInfoType[] PayeeNSIInfoType
        {
            get => Items as PayeeNSIInfoType[];
            set => Items = value;
        }

        /// <summary>
        /// Нормативно-справочная информация о коде по ОКТМО
        /// </summary>
        [XmlIgnore]
        public oktmoNSIInfoType[] OktmoNSIInfoType
        {
            get => Items as oktmoNSIInfoType[];
            set => Items = value;
        }

        /// <summary>
        /// Код справочника |> required
        /// </summary>
        [XmlAttribute("directoryCode")]
        public string DirectoryCode { get; set; }
    }
}
