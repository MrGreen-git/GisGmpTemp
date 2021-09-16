using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPaymentCheck
{
    [Serializable]
    //[XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
    public class ImportProtocol : ImportProtocolType
    {
        [XmlAttribute]
        public string requisiteCheckCode { get; set; }
    }
}
