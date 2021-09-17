using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class TimeConditionsType
    {
        /// <summary>
        protected TimeConditionsType() { }

        /// <summary>
        public TimeConditionsType(TimeIntervalType timeInterval) => TimeInterval = timeInterval;

        /// <summary>
        public TimeConditionsType(TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbkList = default)
            : this(timeInterval)
        {
            Beneficiary = beneficiary;
            KBKlist = kbkList;
        }

        /// <summary>
        /// Временной интервал, за который запрашиваются сведения | required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public TimeIntervalType TimeInterval
        {
            get => TimeIntervalField;
            set => TimeIntervalField = Validator.IsNull(value: value, name: nameof(TimeInterval));
        }

        TimeIntervalType TimeIntervalField;

        /// <summary>
        /// Идентификация получателя средств | not required
        /// </summary>
        [XmlElement("Beneficiary")]
        public Beneficiary[] Beneficiary
        {
            get => BeneficiaryField;
            set => BeneficiaryField = Validator.ArrayObj(value: value, name: nameof(Beneficiary), required: false, min: 1, max: 10);
        }

        Beneficiary[] BeneficiaryField;


        /// <summary>
        /// Перечень КБК | not required
        /// </summary>   
        [XmlIgnore]
        public KBKType[] KBKlist
        {
            get => KBKlistField;
            set => KBKlistField = Validator.ArrayObj(value: value, name: nameof(KBKlist), required: false, min: 1, max: 10);
        }

        KBKType[] KBKlistField;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlArray(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] WrapperKBKlist
        {
            get => KBKlist?.ToArrayString();
            set => KBKlist = value?.ToArray<KBKType>(s => s);
        }
    }
}
