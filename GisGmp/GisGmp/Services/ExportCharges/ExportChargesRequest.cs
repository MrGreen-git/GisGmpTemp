using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0", IsNullable = false)]
    public class ExportChargesRequest : ExportRequestType
    {
        [XmlElement("EsiaUserInfo")]
        public EsiaUserInfoType EsiaUserInfo { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
        [XmlElement("ChargesExportConditions")]
        public ChargesExportConditions ChargesExportConditions { get; set; }

        [XmlAttribute("external")]
        public External External { get; set; }

        [XmlIgnore]
        public bool ExternalSpecified { get; set; }
    }
}
