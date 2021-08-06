using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    /// <summary>
    /// Поле 4010: Реквизиты зачисления после обработки и классификации кредитовых распоряжений
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
    public class IncomeIndex
    {
        /// <summary>
        /// Поле номер 4011: КБК после обработки и классификации кредитовых распоряжений
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Поле номер 4012: ОКТМО после обработки и классификации кредитовых распоряжений
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Поле номер 4013: ИНН получателя после обработки и классификации кредитовых распоряжений
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Поле номер 4014: КПП получателя после обработки и классификации кредитовых распоряжений
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Поле номер 4015: Номер казначейского счета получателя средств после обработки и классификации кредитовых распоряжений
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; }
    }
}
