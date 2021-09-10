using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [XmlInclude(typeof(ImportedRefundType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundType
    {
        /// <summary />
        protected RefundType() { }

        /// <summary>
        public RefundType(RefundType refund) => Clone.Field(this, refund);

        /// <summary />
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

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public RefundPayer RefundPayer
        {
            get => RefundPayerField;
            set => RefundPayerField = Validator.IsNull(value: value, name: nameof(RefundPayer));
        }

        RefundPayer RefundPayerField;

        public RefundApplication RefundApplication
        {
            get => RefundApplicationField;
            set => RefundApplicationField = Validator.IsNull(value: value, name: nameof(RefundApplication));
        }

        RefundApplication RefundApplicationField;

        public RefundBasis RefundBasis
        {
            get => RefundBasisField;
            set => RefundBasisField = Validator.IsNull(value: value, name: nameof(RefundBasis));
        }

        RefundBasis RefundBasisField;

        public RefundPayee RefundPayee
        {
            get => RefundPayeeField;
            set => RefundPayeeField = Validator.IsNull(value: value, name: nameof(RefundPayee));
        }

        RefundPayee RefundPayeeField;



        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData
        {
            get => AdditionalDataField;
            set => AdditionalDataField = Validator.ArrayObj(value: value, name: nameof(AdditionalData), required: false, min: 0, max: 10);
        }

        AdditionalDataType[] AdditionalDataField;

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


        [XmlAttribute("refundDocDate")]
        public DateTime RefundDocDate { get; set; }

        [XmlAttribute("budgetLevel")]
        public BudgetLevel BudgetLevel
        {
            get => BudgetLevelField;
            set => BudgetLevelField = Validator.IsNull(value: value, name: nameof(BudgetLevel));
        }

        BudgetLevel BudgetLevelField;

        
        [XmlIgnore]
        public KBKType Kbk { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }
    }
}
