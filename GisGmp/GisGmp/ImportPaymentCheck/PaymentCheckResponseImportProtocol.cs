﻿using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ImportPaymentCheck
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
    public class PaymentCheckResponseImportProtocol : ImportProtocolType
    {
        [XmlAttribute]
        public string requisiteCheckCode { get; set; }
    }
}
