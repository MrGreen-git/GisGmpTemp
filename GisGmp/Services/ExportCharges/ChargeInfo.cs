using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Извещение о начислении
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public class ChargeInfo : ChargeType
    {
        /// <summary/>
        protected ChargeInfo() { }

        public ChargeInfo(
            long amountToPay,
            ChangeStatusInfo changeStatusInfo,
            ChargeType charge
            ) : base(charge)
        {
            AmountToPay = amountToPay;
            ChangeStatusInfo = changeStatusInfo;
        }


        /// <summary>
        /// Сведения о фактах погашения начисления без платежа | not required
        /// </summary>
        [XmlElement("ReconcileWithoutPayment")]
        public ReconcileWithoutPayment[] ReconcileWithoutPayment { get; set; }

        /// <summary>
        /// Сведения о статусе извещения о начислении и основаниях изменения | required 
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }

        /// <summary>
        /// Остаток суммы подлежащей оплате, указанной в начислении (в копейках). 
        /// required
        /// </summary>
        [XmlAttribute("amountToPay")]
        public long AmountToPay { get; set; }

        /// <summary>
        /// Статус квитирования с платежами | not required
        /// </summary>
        [XmlAttribute("acknowledgmentStatus")]
        public AcknowledgmentStatusType AcknowledgmentStatus { get; set; }

        [XmlIgnore]
        public bool AcknowledgmentStatusSpecified { get; set; }

        /// <summary>
        /// Код проверки реквизитов (КПР)
        /// not required
        /// </summary>
        [XmlAttribute("requisiteCheckCode")]
        public string RequisiteCheckCode { get; set; }
    }
}
