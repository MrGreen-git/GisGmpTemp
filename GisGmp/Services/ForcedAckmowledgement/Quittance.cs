using GisGmp.Quittance;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class Quittance : QuittanceType
    {
        [XmlAttribute]
        public string reconcileID { get; set; }
    }
}
