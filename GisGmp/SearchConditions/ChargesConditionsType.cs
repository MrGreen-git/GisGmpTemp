using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class ChargesConditionsType
    {
        /// <summary/>
        protected ChargesConditionsType() { }

        /// <summary/>
        public ChargesConditionsType(SupplierBillIDType[] supplierBillID) 
            => SupplierBillID = supplierBillID;

        /// <summary/>
        public ChargesConditionsType(SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = null)
            : this(supplierBillID) => TimeInterval = timeInterval;


        /// <summary>
        /// УИН | required
        /// </summary>
        [XmlIgnore]
        public SupplierBillIDType[] SupplierBillID
        {
            get => SupplierBillIDField;
            set => SupplierBillIDField = Validator.ArrayObj(value: value, name: nameof(SupplierBillID), required: true, min: 1, max: 100);
        }

        SupplierBillIDType[] SupplierBillIDField;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("SupplierBillID")]
        public string[] WrapperSupplierBillID
        {
            get => SupplierBillID?.ToArrayString();
            set => SupplierBillID = value?.ToArray<SupplierBillIDType>(s => s);
        }

        /// <summary>
        /// Временной интервал, за который запрашиваются сведения | not required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public TimeIntervalType TimeInterval { get; set; }


        [XmlElement("paymentMethod")]
        public PaymentMethodType PaymentMethod { get; set; }

        [XmlIgnore]
        public bool PaymentMethodSpecified { get; set; }
    }
}
