using System;
using System.Xml.Serialization;

namespace GisGmp.CommonNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public class PayeeNSIInfoTypeOrgKS
    {
        [XmlAttribute]
        public string KSNumber { get; set; }

        [XmlAttribute]
        public string bik { get; set; }

        [XmlAttribute]
        public string bankAccountNumber { get; set; }

        [XmlAttribute]
        public PayeeNSIInfoTypeOrgKSStatKS statKS { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime dateIn { get; set; }
    }
}
