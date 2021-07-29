using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public enum External
    {

        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,
    }
}
