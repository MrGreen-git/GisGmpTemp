using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExportRequestType : RequestType
    {
        /// <summary>
        /// Параметры постраничного предоставления из ГИС ГМП информации (при больших объемах предоставляемых данных)
        /// </summary>
        public PagingType Paging { get; set; }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }
    }
}
