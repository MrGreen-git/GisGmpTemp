using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportChargestemplate
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0", IsNullable = false)]
    public class ChargeCreationRequest : RequestType
    {
        public ChargeTemplateType ChargeTemplate { get; set; }

        [XmlAttribute]
        public string originatorId { get; set; }
    }
}
