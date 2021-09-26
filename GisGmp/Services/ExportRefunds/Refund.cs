using GisGmp.Common;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportRefunds
{
    /// <summary>
    /// Информация о возврате денежных средств (возврат)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
    public class Refund : RefundType
    {
        /// <summary/>
        protected Refund() { }

        public Refund(ChangeStatusInfo changeStatusInfo, RefundType refund)
            : base(refund) => ChangeStatusInfo = changeStatusInfo;

        /// <summary>
        /// Сведения о статусе начисления и основаниях его изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
