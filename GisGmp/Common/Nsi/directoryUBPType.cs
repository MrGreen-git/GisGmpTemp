using System;
using System.Xml.Serialization;

namespace GisGmp.Common.NSI
{
    /// <summary>
    /// Данные справочника Участников бюджетного процесса (УБП)
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    [XmlRoot("directoryUBP", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/attachments/directoryUBP/2.4.0", IsNullable = false)]
    public class directoryUBPType
    {
        /// <summary>
        /// Нормативно-справочная информация об участнике-получателе средств
        /// </summary>
        [XmlElement("PayeeNSIInfo")]
        public PayeeNSIInfoType[] PayeeNSIInfo { get; set; }
    }
}
