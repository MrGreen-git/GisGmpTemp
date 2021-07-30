using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ServiceDataType
    {
        public ServiceDataTypePersoneOfficial personeOfficial { get; set; }

        [XmlAttribute]
        public ulong amount { get; set; }

        [XmlAttribute]
        public string courtName { get; set; }

        [XmlAttribute]
        public string lawsuitInfo { get; set; }
    }
}
