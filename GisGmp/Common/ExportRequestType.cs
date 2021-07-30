using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExportRequestType : RequestType
    {
        public PagingType Paging { get; set; }

        [XmlAttribute]
        public string originatorId { get; set; }
    }
}
