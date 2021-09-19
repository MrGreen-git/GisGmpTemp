using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Данные нового уточнения вида и принадлежности платежа
    /// </summary>
    [XmlInclude(typeof(ImportedClarificationType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class ClarificationType : AbstractClarificationType
    {
        /// <summary/>
        protected ClarificationType() { }

        /// <summary/>
        public ClarificationType(ClarificationType clarification) => Clone.Field(this, clarification);

        public ClarificationType(
            ClarificationApplicationType clarificationApplication,
            SignsClarificationType signs,
            string clarificationNumber,
            DateTime clarificationDate,
            string clarificationId,
            string paymentId,
            string authorAccount,
            string authorName,
            string codeUBP,
            BudgetLevel budgetLevel,
            string okpo,
            string financialBody,
            string tofkName,
            string tofkCode
            )
        { 
            ClarificationApplication = clarificationApplication;
            Signs = signs;
            ClarificationNumber = clarificationNumber;
            ClarificationDate = clarificationDate;
            ClarificationId = clarificationId;
            PaymentId = paymentId;
            AuthorAccount = authorAccount;
            AuthorName = authorName;
            CodeUBP = codeUBP;
            BudgetLevel = budgetLevel;
            Okpo = okpo;
            FinancialBody = financialBody;
            TofkName = tofkName;
            TofkCode = tofkCode;
        }

        /// <summary>
        /// Реквизиты платежного документа |> required
        /// </summary>
        public ClarificationApplicationType ClarificationApplication { get; set; }

        /// <summary>
        /// Подписи и отметка ТОФК |> required
        /// </summary>
        public SignsClarificationType Signs { get; set; }

        /// <summary>
        /// Номер документа |> required
        /// </summary>
        [XmlAttribute("clarificationNumber")]
        public string ClarificationNumber { get; set; }

        /// <summary>
        /// Дата документа |> required
        /// </summary>
        [XmlAttribute("clarificationDate", DataType = "date")]
        public DateTime ClarificationDate { get; set; }

        /// <summary>
        /// УВПП |> required
        /// </summary>
        [XmlAttribute("clarificationId")]
        public string ClarificationId { get; set; }

        /// <summary>
        /// УПНО(УИП) |> required
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// УИН |> not required
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Номер лицевого счета ПБС/АДБ/АИФДБ. |> required
        /// /// </summary>
        [XmlAttribute("authorAccount")]
        public string AuthorAccount { get; set; }

        /// <summary>
        /// Наименование ПБС/АДБ/АИФДБ |> required
        /// </summary>
        [XmlAttribute("authorName")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Код по Сводному реестру ПБС/АДБ/АИФДБ |> required
        /// </summary>
        [XmlAttribute("codeUBP")]
        public string CodeUBP { get; set; }

        /// <summary>
        /// Наименование ГРБС/ГАДБ/ГАИФДБ |> not required
        /// </summary>
        [XmlAttribute("mainAuthorName")]
        public string MainAuthorName { get; set; }

        /// <summary>
        /// Глава по БК |> not required
        /// </summary>
        [XmlAttribute("kbkGlavaCode")]
        public string KbkGlavaCode { get; set; }

        /// <summary>
        /// Уровень бюджета |> required
        /// </summary>
        [XmlAttribute("budgetLevel")]
        public BudgetLevel BudgetLevel { get; set; }

        /// <summary>
        /// Код по ОКПО |> required
        /// </summary>
        [XmlAttribute("okpo")]
        public string Okpo { get; set; }

        /// <summary>
        /// Номер лицевого счета финансового органа |> not required
        /// </summary>
        [XmlAttribute("finBodyAccount")]
        public string FinBodyAccount { get; set; }

        /// <summary>
        /// Финансовый орган |> required
        /// </summary>
        [XmlAttribute("financialBody")]
        public string FinancialBody { get; set; }

        /// <summary>
        /// Федеральное казначейство, орган Федерального казначейства |> required
        /// </summary>
        [XmlAttribute("tofkName")]
        public string TofkName { get; set; }

        /// <summary>
        /// Код по КОФК |> required
        /// </summary>
        [XmlAttribute("tofkCode")]
        public string TofkCode { get; set; }

        /// <summary>
        /// Плательщик |> not required
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Идентификатор плательщика |> not required
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }

        /// <summary>
        /// ИНН |> not required
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП |> not required
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Паспортные данные плательщика |> not required
        /// </summary>
        [XmlAttribute("payerDocument")]
        public string PayerDocument { get; set; }

        /// <summary>
        /// Номер банковского счета плательщика |> not required
        /// </summary>
        [XmlAttribute("payerAccount")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// Номер запроса |> not required
        /// </summary>
        [XmlAttribute("findingoutRequestNum")]
        public string FindingoutRequestNum { get; set; }

        /// <summary>
        /// Дата запроса |> not required
        /// </summary>
        [XmlAttribute("findingoutRequestDate", DataType = "date")]
        public DateTime FindingoutRequestDate { get; set; }

        [XmlIgnore]
        public bool FindingoutRequestDateSpecified { get; set; }
    }
}
