using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class PayersConditionsType
    {
        /// <summary/>
        protected PayersConditionsType() { }

        /// <summary/>
        public PayersConditionsType(PayerId[] payerId, Beneficiary[] beneficiary
            ) 
        {
            PayerId = payerId;
            Beneficiary = beneficiary;
        }

        /// <summary/>
        public PayersConditionsType(INNType[] payerInn, Beneficiary[] beneficiary
            )
        {
            PayerInn = payerInn;
            Beneficiary = beneficiary;
        }

        /// <summary>
        /// required
        /// </summary>
        [XmlElement("PayerIdentifier", typeof(PayerId))]
        [XmlElement("PayerInn", typeof(INNType))]
        //[XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }


        [XmlIgnore]
        public PayerId[] PayerId
        {
            get => Items as PayerId[];
            set => Items = value;
        }

        [XmlIgnore]
        public INNType[] PayerInn
        { 
            get => Items as INNType[];
            set => Items = value;
        }

        //[XmlElement("ItemsElementName")]
        //[XmlIgnore]
        //public ItemsChoiceType[] ItemsElementName { get; set; }

        /// <summary>
        /// Временной интервал, за который запрашивается информация из ГИС ГМП | not required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public TimeIntervalType TimeInterval { get; set; }

        /// <summary>
        /// Перечень КБК | not required
        /// </summary>
        [XmlArray(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] KBKlist { get; set; }

        /// <summary>
        /// Идентификация получателя средств | required
        /// </summary>
        [XmlElement("Beneficiary")]
        public Beneficiary[] Beneficiary { get; set; }
    }
}
