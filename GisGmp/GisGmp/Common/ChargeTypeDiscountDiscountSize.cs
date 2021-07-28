using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    [XmlRoot("DiscountSize", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0", IsNullable = false)]
    public class ChargeTypeDiscountDiscountSize : DiscountType
    {
    }
}
