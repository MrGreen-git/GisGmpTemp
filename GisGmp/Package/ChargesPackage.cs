using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IsNullable = false)]
    public class ChargesPackage : PackageType
    {
    }
}
