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
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        public ClarificationApplicationType ClarificationApplication { get; set; }

        /// <summary>
        /// Подписи и отметка ТОФК
        /// </summary>
        public SignsClarificationType Signs { get; set; }

        /// <summary>
        /// Указывается уникальный цифровой порядковый номер распоряжения о совершении казначейского платежа (далее - распоряжение), присвоенный прямым участником системы казначейских платежей, в пределах даты составления распоряжения.
        /// </summary>
        [XmlAttribute("clarificationNumber")]
        public string СlarificationNumber { get; set; }

        /// <summary>
        /// Указывается дата составления распоряжения, не превышающая дату его представления в орган Федерального казначейства. В распоряжении на бумажном носителе указываются день, месяц и год составления распоряжения цифрами в формате "ДД.ММ.ГГГГ". В распоряжении в электронной форме указываются день, месяц и год составления распоряжения цифрами.
        /// </summary>
        [XmlAttribute("clarificationDate", DataType = "date")]
        public DateTime ClarificationDate { get; set; }

        /// <summary>
        /// Идентификатор уточнении вида и принадлежности платежа - УВПП
        /// </summary>
        [XmlAttribute("clarificationId")]
        public string ClarificationId { get; set; }

        /// <summary>
        /// УПНО(УИП)
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Номер лицевого счета ПБС/АДБ/АИФДБ. Указывается номер лицевого счета прямого участника системы казначейских платежей, соответствующий номеру лицевого счета, открытого в территориальном органе Федерального казначейства.
        /// </summary>
        [XmlAttribute("authorAccount")]
        public string AuthorAccount { get; set; }

        /// <summary>
        /// Указывается наименование получателя бюджетных средств, администратора доходов бюджета или администратора источников финансирования дефицита бюджета - прямого участника системы казначейских платежей, формирующего распоряжение.
        /// </summary>
        [XmlAttribute("authorName")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Указывается уникальный код плательщика - прямого участника системы казначейских платежей в соответствии со Сводным реестром
        /// </summary>
        [XmlAttribute("codeUBP")]
        public string CodeUBP { get; set; }

        /// <summary>
        /// Указывается полное наименование главного распорядителя бюджетных средств, главного администратора доходов бюджета или главного администратора источников финансирования дефицита бюджета, в ведении которого находится прямой участник системы казначейских платежей, формирующий распоряжение
        /// </summary>
        [XmlAttribute("mainAuthorName")]
        public string MainAuthorName { get; set; }

        /// <summary>
        /// Указывается код главы по бюджетной классификации вышестоящего участника бюджетного процесса, в ведении которого находится прямой участник системы казначейских платежей, в соответствии со Сводным реестром.
        /// </summary>
        [XmlAttribute("kbkGlavaCode")]
        public string KbkGlavaCode { get; set; }

        /// <summary>
        /// Уровень бюджета. Допустимые значения: 1 - «федеральный»; 2 – «бюджет субъекта РФ»; 3 – «местный бюджет»; 4 – «бюджет ГВФ РФ»; 5 – «бюджет ТГВФ РФ»; 6 – «средства ЮЛ».
        /// </summary>
        [XmlAttribute("budgetLevel")]
        public BudgetLevel BudgetLevel { get; set; }

        /// <summary>
        /// Указывается код финансового органа, органа управления государственным внебюджетным фондом по Общероссийскому классификатору предприятий и организаций.
        /// </summary>
        [XmlAttribute("okpo")]
        public string Okpo { get; set; }

        /// <summary>
        /// Указывается номер лицевого счета прямого участника системы казначейских платежей (финансового органа), соответствующий номеру лицевого счета, открытого в территориальном органе Федерального казначейства.
        /// </summary>
        [XmlAttribute("finBodyAccount")]
        public string FinBodyAccount { get; set; }

        /// <summary>
        /// Указывается:для прямого участника системы казначейских платежей, являющегося участником бюджетного процесса федерального уровня, - "Министерство финансов Российской Федерации"; для прямого участника системы казначейских платежей, являющегося участником бюджетного процесса субъекта Российской Федерации, муниципального образования, государственного внебюджетного фонда - полное наименование финансового органа соответствующего бюджета, органа управления государственным внебюджетным фондом.
        /// </summary>
        [XmlAttribute("financialBody")]
        public string FinancialBody { get; set; }

        /// <summary>
        /// Указывается полное наименование территориального органа Федерального казначейства, в котором осуществляется обслуживание лицевого счета прямого участника системы казначейских платежей.
        /// </summary>
        [XmlAttribute("tofkName")]
        public string TofkName { get; set; }

        /// <summary>
        /// Указывается код территориального органа Федерального казначейства, в котором осуществляется обслуживание лицевого счета прямого участника системы казначейских платежей, присвоенный Федеральным казначейством.
        /// </summary>
        [XmlAttribute("tofkCode")]
        public string TofkCode { get; set; }

        /// <summary>
        /// Указывается наименование учреждения, организации-плательщика или фамилия, имя, отчество физического лица - плательщика в соответствии с полученным территориальным органом Федерального казначейства в качестве приложения к выписке из казначейского счета распоряжением.
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Указывается идентификационный номер плательщика.
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }

        /// <summary>
        /// Указывается ИНН плательщика.
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Указывается код причины постановки на учет в налоговом органе плательщика.
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Указываются для физического лица - плательщика - серия и номер паспорта, кем и когда выдан соответствующий документ в соответствии с полученным территориальным органом Федерального казначейства в качестве приложения к выписке из казначейского счета распоряжением (при необходимости). Для учреждения, организации-плательщика строка не заполняется.
        /// </summary>
        [XmlAttribute("payerDocument")]
        public string PayerDocument { get; set; }

        /// <summary>
        /// Указывается номер банковского счета или казначейского счета плательщика
        /// </summary>
        [XmlAttribute("payerAccount")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// Указывается номер Запроса на выяснение принадлежности платежа, направленного прямому участнику системы казначейских платежей.
        /// </summary>
        [XmlAttribute("findingoutRequestNum")]
        public string FindingoutRequestNum { get; set; }

        /// <summary>
        /// Указывается дата Запроса на выяснение принадлежности платежа, направленного прямому участнику системы казначейских платежей.
        /// </summary>
        [XmlAttribute("findingoutRequestDate", DataType = "date")]
        public DateTime FindingoutRequestDate { get; set; }

        [XmlIgnore]
        public bool FindingoutRequestDateSpecified { get; set; }
    }
}
