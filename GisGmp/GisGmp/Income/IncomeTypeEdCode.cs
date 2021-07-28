using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
    public enum IncomeTypeEdCode
    {

        ED101,

        ED104,

        ED105,

        ED108,

        ED701,
    }
}
