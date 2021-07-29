using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class AnnulmentReconcilePaymentNotLoaded
    {
        [XmlAttribute]
        public string reconcileID { get; set; }

        [XmlText()]
        public bool Value { get; set; }
    }
}
