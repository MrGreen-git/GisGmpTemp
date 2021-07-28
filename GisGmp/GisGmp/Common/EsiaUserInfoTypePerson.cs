using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class EsiaUserInfoTypePerson
    {
        public EsiaUserInfoTypePersonDocumentIdentity DocumentIdentity { get; set; }

        [XmlAttribute]
        public string snils { get; set; }

        [XmlAttribute]
        public string personINN { get; set; }
    }
}
