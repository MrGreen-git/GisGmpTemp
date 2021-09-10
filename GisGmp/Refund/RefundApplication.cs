using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundApplication
    {
        /// <summary/>
        protected RefundApplication() { }

        /// <summary/>
        public RefundApplication(string appNum, DateTime appDate, PaymentIdType paymentIdType, int cashType, ulong amount, string purpose)
        {
            AppNum = appNum;
            AppDate = appDate;
            PaymentId = paymentIdType;
            CashType = cashType;
            Amount = amount;
            Purpose = purpose;
        }

        [XmlAttribute("appNum")]
        public string AppNum
        {
            get => AppNumField;
            set => AppNumField = Validator.String(value: ref value, name: nameof(AppNum), required: true, min: 1, max: 15);
        }

        string AppNumField;


        [XmlAttribute("appDate", DataType = "date")]
        public DateTime AppDate { get; set; }


        [XmlIgnore]
        public PaymentIdType PaymentId
        {
            get => PaymentIdField;
            set => PaymentIdField = Validator.IsNull(value: value, name: nameof(PaymentId));
        }

        PaymentIdType PaymentIdField;


        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("paymentId")]
        public string WrapperPaymentId { get => PaymentId; set => PaymentId = value; }


        [XmlAttribute("cashType")]
        public int CashType { get; set; }


        [XmlAttribute("amount")]
        public ulong Amount { get; set; }


        [XmlAttribute("purpose")]
        public string Purpose
        {
            get => PurposeField;
            set => PurposeField = Validator.String(value: ref value, name: nameof(Purpose), required: true, min: 0, max: 210);
        }

        string PurposeField;
    }
}
