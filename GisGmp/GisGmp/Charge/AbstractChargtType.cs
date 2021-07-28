using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    [XmlInclude(typeof(ChargeTemplateType))]
    [XmlInclude(typeof(ChargeType))]
    [XmlInclude(typeof(ImportedChargeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public abstract class AbstractChargtType
    {
    }
}
