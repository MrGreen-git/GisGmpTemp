using System;
using System.Xml.Serialization;

namespace GisGmp.ExportCharges
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public enum ExportChargesRequestExternal
    {

        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,
    }
}
