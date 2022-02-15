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
        public IncomeIndex() { }

        /// <summary>
        /// Поле номер 4011: КБК после обработки и классификации кредитовых распоряжений
        /// <para>use: not required</para>
        /// <para>type: com:KBKType</para>
        /// <para>pattern: "[0-9a-zA-Zа-яА-Я]{20}"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; } //TODO type

        /// <summary>
        /// Поле номер 4012: ОКТМО после обработки и классификации кредитовых распоряжений
        /// <para>use: not required</para>
        /// <para>type: com:OKTMOType</para>
        /// <para>length: 1..11</para>
        /// <para>pattern: "\d{11}"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; } //TODO type

        /// <summary>
        /// Поле номер 4013: ИНН получателя после обработки и классификации кредитовых распоряжений
        /// <para>use: not required</para>
        /// <para>type: com:INNType</para>
        /// <para>pattern: "([^0^\D]\d|\d[^0^\D])\d{8}"</para>
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; } //TODO type

        /// <summary>
        /// Поле номер 4014: КПП получателя после обработки и классификации кредитовых распоряжений
        /// <para>use: not required</para>
        /// <para>type: com:KPPType</para>
        /// <para>pattern: "([^0^\D]\d|\d[^0^\D])\d{2}[A-Z0-9]{2}\d{3}"</para>
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; } //TODO type

        /// <summary>
        /// Поле номер 4015: Номер казначейского счета получателя средств после обработки и классификации кредитовых распоряжений
        /// <para>use: not required</para>
        /// <para>type: com:AccountNumType</para>
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; } //TODO type
    }
}
