using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public class ReconcileWithoutPayment
    {
        [XmlAttribute]
        public string reconcileID { get; set; }

        [XmlAttribute]
        public ulong amountReconcile { get; set; }
    }
}
