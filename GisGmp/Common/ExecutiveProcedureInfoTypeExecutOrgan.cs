using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExecutiveProcedureInfoTypeExecutOrgan
    {
        [XmlAttribute]
        public string organOkogu { get; set; }

        [XmlAttribute]
        public string organCode { get; set; }

        [XmlAttribute]
        public string organ { get; set; }

        [XmlAttribute]
        public string organAdr { get; set; }

        [XmlAttribute]
        public string organSignCodePost { get; set; }

        [XmlAttribute]
        public string organSign { get; set; }

        [XmlAttribute]
        public string organSignFIO { get; set; }
    }
}
