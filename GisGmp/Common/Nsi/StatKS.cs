using System;
using System.Xml.Serialization;

namespace GisGmp.Common.NSI
{
    /// <summary>
    /// Статус казначейского счета
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public enum StatKS
    {

        KS1,

        KS2,

        KS3,
    }
}
