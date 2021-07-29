using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    [XmlInclude(typeof(ClarificationType))]
    [XmlInclude(typeof(ImportedClarificationType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public abstract class AbstractClarificationType
    {
    }
}
