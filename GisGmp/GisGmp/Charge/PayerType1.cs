using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    [Serializable]
    [XmlType(TypeName = "PayerType", Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public class PayerType1 : PayerType
    {
    }
}
