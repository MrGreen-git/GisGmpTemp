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
        protected ClarificationType() { }

        public ClarificationType(ClarificationType clarification) => Clone.Field(this, clarification);

        /// <summary>
        /// Данные нового уточнения вида и принадлежности платежа
        /// </summary>
        /// <param name="clarificationNumber">Номер документа</param>
        /// <param name="clarificationDate">Дата документа</param>
        /// <param name="clarificationId">УВПП</param>
        /// <param name="paymentId">УПНО(УИП)</param>
        /// <param name="authorAccount">Номер лицевого счета ПБС/АДБ/АИФДБ</param>
        /// <param name="authorName">Наименование ПБС/АДБ/АИФДБ</param>
        /// <param name="codeUBP">Код по Сводному реестру ПБС/АДБ/АИФДБ</param>
        /// <param name="budgetLevel">Уровень бюджета</param>
        /// <param name="okpo">Код по ОКПО</param>
        /// <param name="financialBody">Финансовый орган</param>
        /// <param name="tofkName">Федеральное казначейство, орган Федерального казначейства</param>
        /// <param name="tofkCode">Код по КОФК</param>
        /// <param name="clarificationApplication">Реквизиты платежного документа</param>
        /// <param name="signs">Подписи и отметка ТОФК</param>
        public ClarificationType(
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
            string tofkCode,
            ClarificationApplicationType clarificationApplication,
            SignsClarificationType signs                                                                                                             
            )
        {
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
            ClarificationApplication = clarificationApplication;
            Signs = signs;                                                                                    
        }


        /// <summary>
        /// Номер документа
        /// <para>use: required</para>
        /// <para>length: 1..15</para>
        /// <para>pattern: "\w+"</para>
        /// </summary>
        [XmlAttribute("clarificationNumber")]
        public string ClarificationNumber { get; set; }

        /// <summary>
        /// Дата документа
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("clarificationDate", DataType = "date")]
        public DateTime ClarificationDate { get; set; }

        /// <summary>
        /// УВПП
        /// <para>use: required</para>
        /// <para>type: com:ClarificationIdType</para>
        /// </summary>
        [XmlAttribute("clarificationId")]
        public string ClarificationId { get; set; }

        /// <summary>
        /// УПНО(УИП)
        /// <para>use: required</para>
        /// <para>type: com:PaymentIdType</para>
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// УИН
        /// <para>use: not required</para>
        /// <para>type: com:SupplierBillIDType</para>
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Номер лицевого счета ПБС/АДБ/АИФДБ.
        /// <para>use: required</para>
        /// <para>type: com:PayeeAccountType</para>
        /// </summary>
        [XmlAttribute("authorAccount")]
        public string AuthorAccount { get; set; }

        /// <summary>
        /// Наименование ПБС/АДБ/АИФДБ
        /// <para>use: required</para>
        /// <para>length: 0..2000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("authorName")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Код по Сводному реестру ПБС/АДБ/АИФДБ
        /// <para>use: required</para>
        /// <para>type: org:kodUBPType</para>
        /// <para>pattern: "\w{5}"</para>
        /// <para>pattern: "\w{8}"</para>
        /// </summary>
        [XmlAttribute("codeUBP")]
        public string CodeUBP { get; set; }

        /// <summary>
        /// Наименование ГРБС/ГАДБ/ГАИФДБ
        /// <para>use: not required</para>
        /// <para>length: 0..2000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("mainAuthorName")]
        public string MainAuthorName { get; set; }

        /// <summary>
        /// Глава по БК
        /// <para>use: not required</para>
        /// <para>length: 3..3</para>
        /// <para>pattern: "\d{3}"</para>
        /// </summary>
        [XmlAttribute("kbkGlavaCode")]
        public string KbkGlavaCode { get; set; }

        /// <summary>
        /// Уровень бюджета
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("budgetLevel")]
        public BudgetLevel BudgetLevel { get; set; }

        /// <summary>
        /// Код по ОКПО
        /// <para>use: required</para>
        /// <para>pattern: "\d{8}"</para>
        /// </summary>
        [XmlAttribute("okpo")]
        public string Okpo { get; set; }

        /// <summary>
        /// Номер лицевого счета финансового органа
        /// <para>use: not required</para>
        /// <para>type: com:PayeeAccountType</para>
        /// <para>pattern: "[\d\w]{11}"</para>
        /// </summary>
        [XmlAttribute("finBodyAccount")]
        public string FinBodyAccount { get; set; }

        /// <summary>
        /// Финансовый орган
        /// <para>use: required</para>
        /// <para>length: 0..2000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("financialBody")]
        public string FinancialBody { get; set; }

        /// <summary>
        /// Федеральное казначейство, орган Федерального казначейства
        /// <para>use: required</para>
        /// <para>length: 0..2000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("tofkName")]
        public string TofkName { get; set; }

        /// <summary>
        /// Код по КОФК
        /// <para>use: required</para>
        /// <para>pattern: "\d{4}"</para>
        /// </summary>
        [XmlAttribute("tofkCode")]
        public string TofkCode { get; set; }

        /// <summary>
        /// Плательщик
        /// <para>use: not require</para>
        /// <para>length: 0..2000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Идентификатор плательщика
        /// <para>use: not required</para>
        /// <para>type: com:PayerIdentifierType</para>
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }

        /// <summary>
        /// ИНН
        /// <para>use: not required</para>
        /// <para>type: com:INNAllType</para>
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// <para>use: not required</para>
        /// <para>type: com:KPPType</para>
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Паспортные данные плательщика
        /// <para>use: not required</para>
        /// /// <para>length: 0..1000</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("payerDocument")]
        public string PayerDocument { get; set; }

        /// <summary>
        /// Номер банковского счета плательщика
        /// <para>use: not required</para>
        /// <para>length: 1..34</para>
        /// <para>pattern: "[A-Z0-9]+"</para>
        /// </summary>
        [XmlAttribute("payerAccount")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// Номер запроса
        /// <para>use: not required</para>
        /// <para>length: 1..15</para>
        /// <para>pattern: "\w+"</para>
        /// </summary>
        [XmlAttribute("findingoutRequestNum")]
        public string FindingoutRequestNum { get; set; }

        /// <summary>
        /// Дата запроса
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("findingoutRequestDate", DataType = "date")]
        public DateTime FindingoutRequestDate { get; set; }

        [XmlIgnore]
        public bool FindingoutRequestDateSpecified { get; set; }

        /// <summary>
        /// Реквизиты платежного документа
        /// <para>use: required</para>
        /// </summary>
        public ClarificationApplicationType ClarificationApplication { get; set; }

        /// <summary>
        /// Подписи и отметка ТОФК
        /// <para>use: required</para>
        /// </summary>
        public SignsClarificationType Signs { get; set; }  
    }
}
