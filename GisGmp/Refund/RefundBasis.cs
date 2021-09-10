using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundBasis
    {
        /// <summary/>
        protected RefundBasis() { }

        /// <summary/>
        public RefundBasis(string docKind, string docNumber, DateTime docDate)
        {
            DocKind = docKind;
            DocNumber = docNumber;
            DocDate = docDate;
        }

        [XmlAttribute("docKind")]
        public string DocKind
        {
            get => DocKindField;
            set => DocKindField = Validator.String(value: ref value, name: nameof(DocKind), required: true, min: 1, max: 160);
        }

        string DocKindField;

        [XmlAttribute("docNumber")]
        public string DocNumber
        {
            get => DocNumberField;
            set => DocNumberField = Validator.String(value: ref value, name: nameof(DocNumber), required: true, min: 1, max: 160);
        }

        string DocNumberField;


        [XmlAttribute("docDate", DataType = "date")]
        public DateTime DocDate { get; set; }
    }
}
