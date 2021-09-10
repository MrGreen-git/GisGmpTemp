using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0", IsNullable = false)]
    public class RefundPayer : OrganizationType
    {
        /// <summary/>
        protected RefundPayer() { }

        /// <summary/>
        public RefundPayer(string codeUBP, string name, INNType inn, KPPType kpp)
            : base(name, inn, kpp) => CodeUBP = codeUBP;

        /// <summary/>
        public RefundPayer(string codeUBP, string name, INNType inn, KPPType kpp, OGRNType ogrn)
            : base(name, inn, kpp, ogrn) => CodeUBP = codeUBP;


        [XmlAttribute("codeUBP")]
        public string CodeUBP
        {
            get => CodeUBPField;
            set => CodeUBPField = Validator.IsNull(value: value, name: nameof(CodeUBP));
        }

        string CodeUBPField;
    }
}
