using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [Serializable]
    [XmlType(TypeName = "PayerType", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    public class PayerType2 : PayerType
    {
    }
}
