using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Идентификация получателя средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
    public class Beneficiary
    {
        /// <summary/>
        protected Beneficiary() { }

        /// <summary/>
        public Beneficiary(string inn) => Inn = inn;

        /// <summary/>
        public Beneficiary(string inn, string kpp) : this(inn) => Kpp = kpp;

        /// <summary>
        /// ИНН получателя средств | required
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП получателя средств | not required
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }
    }
}
