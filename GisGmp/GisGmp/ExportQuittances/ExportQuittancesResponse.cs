using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ExportQuittances
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0", IsNullable = false)]
    public class ExportQuittancesResponse : ResponseType
    {
        [XmlElement("Quittance")]
        public QuittanceType[] Quittance { get; set; }

        [XmlElement("PossibleData")]
        public ExportQuittancesResponsePossibleData[] PossibleData { get; set; }

        [XmlAttribute]
        public bool hasMore { get; set; }
    }
}
