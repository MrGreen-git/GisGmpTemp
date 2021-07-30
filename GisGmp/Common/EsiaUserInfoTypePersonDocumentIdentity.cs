using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class EsiaUserInfoTypePersonDocumentIdentity
    {
        [XmlAttribute]
        public EsiaUserInfoTypePersonDocumentIdentityCode code { get; set; }

        [XmlAttribute]
        public string series { get; set; }

        [XmlAttribute]
        public string number { get; set; }
    }
}
