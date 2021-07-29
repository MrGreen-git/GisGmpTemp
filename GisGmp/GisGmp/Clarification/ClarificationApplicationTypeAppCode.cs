using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public enum ClarificationApplicationTypeAppCode
    {

        PP,

        PL,

        ZR,

        ZK,

        ZS,

        ZN,

        UF,

        ZV,
    }
}
