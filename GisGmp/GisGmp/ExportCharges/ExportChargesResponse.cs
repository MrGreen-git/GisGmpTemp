using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ExportCharges
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0", IsNullable = false)]
    public class ExportChargesResponse : ResponseType
    {
        public ExportChargesResponse()
        {
            needReRequest = false;
        }

        [XmlElement("ChargeInfo", typeof(ExportChargesResponseChargeInfo))]
        [XmlElement("ChargeOffense", typeof(ExportChargesResponseChargeOffense))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public bool hasMore { get; set; }

        [XmlAttribute]
        [System.ComponentModel.DefaultValue(false)]
        public bool needReRequest { get; set; }
    }
}
