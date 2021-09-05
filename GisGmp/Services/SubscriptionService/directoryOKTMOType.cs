using GisGmp.Common.NSI;
using System;
using System.Xml.Serialization;

namespace GisGmp.Service.SubscriptionService
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    [XmlRoot("directoryOKTMO", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/attachments/directoryOKTMO/2.4.0", IsNullable = false)]
    public class directoryOKTMOType
    {
        [XmlElement("oktmoNSIInfo")]
        public oktmoNSIInfoType[] oktmoNSIInfo { get; set; }
    }
}
