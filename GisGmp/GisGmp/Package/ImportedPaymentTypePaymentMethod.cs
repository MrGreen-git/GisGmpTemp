using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public enum ImportedPaymentTypePaymentMethod
    {

        [XmlEnum("1")]
        Item1,
    }
}
