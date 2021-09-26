using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Базовый тип для возврата
    /// </summary>
    [XmlInclude(typeof(ImportedRefundType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundType
    {
        protected RefundType() { }

        public RefundType(RefundType refund) => Clone.Field(this, refund);

        /// <summary>
        /// Базовый тип для возврата
        /// </summary>
        /// <param name="refundId">Уникальный идентификатор извещения о возврате (УИВ)</param>
        /// <param name="refundDocDate">Поле номер 3001: Дата и время формирования извещения о возврате</param>
        /// <param name="budgetLevel">Поле номер 3002: Уровень бюджета</param>
        /// <param name="refundPayee">Сведения об организации, осуществляющей возврат денежных средств</param>
        /// <param name="refundApplication">Реквизиты документа-основания для осуществления возврата</param>
        /// <param name="refundBasis">Реквизиты документа-основания для осуществления возврата</param>
        /// <param name="refundPayer">Сведения об организации, осуществляющей возврат денежных средств</param>
        public RefundType(
            string refundId,
            DateTime refundDocDate,
            BudgetLevel budgetLevel,
            RefundPayee refundPayee,
            RefundApplication refundApplication,
            RefundBasis refundBasis,
            RefundPayer refundPayer)
        {
            RefundId = refundId;
            RefundDocDate = refundDocDate;
            BudgetLevel = budgetLevel;
            RefundPayee = refundPayee;
            RefundApplication = refundApplication;
            RefundBasis = refundBasis;
            RefundPayer = refundPayer;
        }

        /// <summary>
        /// Уникальный идентификатор извещения о возврате (УИВ)
        /// <para>use: required</para>
        /// </summary>
        [XmlIgnore]
        public RefundIdType RefundId
        {
            get => RefundIdField;
            set => RefundIdField = Validator.IsNull(value: value, name: nameof(RefundId));
        }

        RefundIdType RefundIdField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("refundId")]
        public string WrapperRefundId { get => RefundId; set => RefundId = value; }

        /// <summary>
        /// Поле номер 3001: Дата и время формирования извещения о возврате
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("refundDocDate")]
        public DateTime RefundDocDate { get; set; }

        /// <summary>
        /// Поле номер 3002: Уровень бюджета
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("budgetLevel")]
        public BudgetLevel BudgetLevel
        {
            get => BudgetLevelField;
            set => BudgetLevelField = Validator.IsNull(value: value, name: nameof(BudgetLevel));
        }

        BudgetLevel BudgetLevelField;

        /// <summary>
        /// Поле номер 104: КБК
        /// <para>use: not required</para>
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }

        /// <summary>
        /// Поле номер 105: Код по ОКТМО
        /// <para>use: not required</para>
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }

        /// <summary>
        /// Сведения об организации, осуществляющей возврат денежных средств
        /// <para>use: required</para>
        /// </summary>
        [XmlElement("RefundPayer", Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public RefundPayer RefundPayer
        {
            get => RefundPayerField;
            set => RefundPayerField = Validator.IsNull(value: value, name: nameof(RefundPayer));
        }
        
        RefundPayer RefundPayerField;

        /// <summary>
        /// Данные заявки на возврат
        /// <para>use: required</para>
        /// </summary>
        public RefundApplication RefundApplication
        {
            get => RefundApplicationField;
            set => RefundApplicationField = Validator.IsNull(value: value, name: nameof(RefundApplication));
        }

        RefundApplication RefundApplicationField;

        /// <summary>
        /// Реквизиты документа-основания для осуществления возврата
        /// <para>use: required</para>
        /// </summary>
        public RefundBasis RefundBasis
        {
            get => RefundBasisField;
            set => RefundBasisField = value.IsRequired();
        }

        RefundBasis RefundBasisField;

        /// <summary>
        /// Сведения о получателе денежных средств
        /// <para>use: required</para>
        /// </summary>
        public RefundPayee RefundPayee
        {
            get => RefundPayeeField;
            set => RefundPayeeField = value.IsRequired();
        }

        RefundPayee RefundPayeeField;

        /// <summary>
        /// Поле номер 202: Дополнительные поля возврата
        /// <para>use: not required</para>
        /// <para>occurs: 0..10</para>
        /// <para></para>
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData
        {
            get => AdditionalDataField;
            set => AdditionalDataField = value.IsRange(min: 0, max: 10);
        }

        AdditionalDataType[] AdditionalDataField;
    }
}
