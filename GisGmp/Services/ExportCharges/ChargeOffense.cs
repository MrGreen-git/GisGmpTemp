using GisGmp.Charge;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Дополнительная информация административного правонарушения, зафиксированного специальными техническими средствами, работающими в автоматическом режиме
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public class ChargeOffense
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
        public OffenseType AdditionalOffense { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }
    }
}
