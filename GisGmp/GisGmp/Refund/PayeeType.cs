using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class PayeeType : PayerType
    {
    }
}
