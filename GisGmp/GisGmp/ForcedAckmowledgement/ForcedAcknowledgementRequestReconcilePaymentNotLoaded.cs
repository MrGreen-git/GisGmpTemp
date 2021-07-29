using System;
using System.Xml.Serialization;

namespace GisGmp.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class ForcedAcknowledgementRequestReconcilePaymentNotLoaded
    {
        [XmlAttribute]
        public ulong amountReconcile { get; set; }

        [XmlIgnore]
        public bool amountReconcileSpecified { get; set; }

        [XmlText()]
        public bool Value { get; set; }
    }
}
