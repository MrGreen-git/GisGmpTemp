using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Данные для формирования необходимой для уплаты информации
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public class ChargeTemplateType : AbstractChargtType
    {
        /// <summary/>
        protected ChargeTemplateType() { }

        public ChargeTemplateType(
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            KBKType kbk,
            OKTMOType oktmo,
            Payee payee,
            ChargePayer payer,
            BudgetIndexType budgetIndex
            )
        {
            BillDate = billDate;
            TotalAmount = totalAmount;
            Purpose = purpose;
            Kbk = kbk;
            Oktmo = oktmo;
            Payee = payee;
            Payer = payer;
            BudgetIndex = budgetIndex;
        }

        /// <summary>
        /// Данные организации, являющейся получателем средств | required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Сведения о плательщике | required
        /// </summary>
        public ChargePayer Payer { get; set; }

        /// <summary>
        /// Реквизиты платежа 101, 106 – 109 | required
        /// </summary>
        public BudgetIndexType BudgetIndex { get; set; }

        /// <summary>
        /// not required
        /// </summary>
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Поле номер 1008: Коэффициент, понижающий размер начисления | not required
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        /// <summary>
        /// УИН | not required
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }
    }
}
