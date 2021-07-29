using GisGmp.Charge;
using System;
using System.Xml.Serialization;

namespace GisGmp.ExportCharges
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public class ExportChargesResponseChargeOffense
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
        public OffenseType AdditionalOffense { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }
    }
}
