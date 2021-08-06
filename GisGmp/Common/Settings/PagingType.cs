using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Параметры постраничного предоставления из ГИС ГМП информации (при больших объемах предоставляемых данных)
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class PagingType
    {
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string pageNumber { get; set; }

        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string pageLength { get; set; }
    }
}
