using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0", IsNullable = false)]
    public class Payee : OrganizationType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public OrgAccount OrgAccount { get; set; }
    }
}
