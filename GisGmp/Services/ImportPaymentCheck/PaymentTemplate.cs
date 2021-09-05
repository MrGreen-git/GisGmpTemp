using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPaymentCheck
{
    /// <summary>
    /// Данные необходимые для приема информации об уплате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
    public class PaymentTemplate
    {
        /// <summary>
        /// Сведения о получателе средств
        /// </summary>
        [XmlElement("Payee", Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Поле номер 1000: УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Дата поступления распоряжения в банк плательщика
        /// </summary>
        [XmlAttribute("receiptDate", DataType = "date")]
        public DateTime ReceiptDate { get; set; }

        [XmlIgnore]
        public bool ReceiptDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 104: КБК.
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Поле номер 105: Код ОКТМО, указанный в распоряжении о переводе денежных средств.
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }
    }
}
