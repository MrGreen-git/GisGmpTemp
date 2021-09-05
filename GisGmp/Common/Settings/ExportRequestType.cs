using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExportRequestType : RequestType
    {
        /// <summary/>
        protected ExportRequestType() { }

        /// <summary/>
        public ExportRequestType(ExportRequestType exportRequest) => Clone.Field(this, exportRequest);
         
        /// <summary/>
        public ExportRequestType(RequestType request, URNType originatorId, PagingType paging)
            : base(request)
        { 
            OriginatorId = originatorId;
            Paging = paging;
        }


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
