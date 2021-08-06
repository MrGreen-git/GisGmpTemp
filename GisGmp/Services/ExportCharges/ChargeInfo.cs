using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Извещение о начислении (начисление)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public class ChargeInfo : ChargeType
    {
        /// <summary>
        /// Сведения о фактах погашения начисления без платежа
        /// </summary>
        [XmlElement("ReconcileWithoutPayment")]
        public ReconcileWithoutPayment[] ReconcileWithoutPayment { get; set; }

        /// <summary>
        /// Сведения о статусе начисления и основаниях его изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }

        /// <summary>
        /// Остаток суммы подлежащей оплате, указанной в начислении (в
        /// копейках). При переплате начисления принимает отрицательное значение; при
        /// полной оплате — значение «0»
        /// </summary>
        [XmlAttribute("amountToPay")]
        public long AmountToPay { get; set; }

        /// <summary>
        /// Статус присвоенный начислению при создании квитанции
        /// </summary>
        [XmlAttribute("acknowledgmentStatus")]
        public AcknowledgmentStatusType AcknowledgmentStatus { get; set; }

        [XmlIgnore]
        public bool AcknowledgmentStatusSpecified { get; set; }

        /// <summary>
        /// КПР или код и описание ошибки
        /// </summary>
        [XmlAttribute("requisiteCheckCode")]
        public string RequisiteCheckCode { get; set; }
    }
}
