using System;
using System.Xml.Serialization;

namespace GisGmp.CommonNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public enum PayeeNSIInfoTypeOrgKSStatKS
    {

        KS1,

        KS2,

        KS3,
    }
}
