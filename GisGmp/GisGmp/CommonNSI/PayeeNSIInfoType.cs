using System;
using System.Xml.Serialization;

namespace GisGmp.CommonNSI
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public class PayeeNSIInfoType
    {
        [XmlArrayItem("kbk", IsNullable = false)]
        public string[] KBKlist { get; set; }

        [XmlArrayItem("OrgKS", IsNullable = false)]
        public PayeeNSIInfoTypeOrgKS[] OrgKSllist { get; set; }

        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string inn { get; set; }

        [XmlAttribute]
        public string kpp { get; set; }

        [XmlAttribute]
        public string kbkGlavaCode { get; set; }

        [XmlAttribute]
        public PayeeNSIInfoTypeOrgStatus orgStatus { get; set; }

        [XmlAttribute]
        public DateTime updateDate { get; set; }
    }
}
