using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Реквизиты документа-основания для осуществления возврата
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundBasis
    {
        protected RefundBasis() { }

        /// <summary>
        /// Реквизиты документа-основания для осуществления возврата
        /// </summary>
        /// <param name="docKind">Поле номер 3005: Вид документа-основания для осуществления возврата</param>
        /// <param name="docNumber">Поле номер 3006: Номер документа-основания для осуществления возврата</param>
        /// <param name="docDate">Поле номер 3007: Дата документа-основания для осуществления возврата</param>
        public RefundBasis(string docKind, string docNumber, DateTime docDate)
        {
            DocKind = docKind;
            DocNumber = docNumber;
            DocDate = docDate;
        }

        /// <summary>
        /// Поле номер 3005: Вид документа-основания для осуществления возврата
        /// <para>use: required</para>
        /// <para>length: 1..160</para>
        /// </summary>
        [XmlAttribute("docKind")]
        public string DocKind
        {
            get => DocKindField;
            set => DocKindField = value.IsRequired().IsLength(min: 1, max: 160);
        }

        string DocKindField;

        /// <summary>
        /// Поле номер 3006: Номер документа-основания для осуществления возврата
        /// <para>use: required</para>
        /// <para>length: 1..6</para>
        /// <para>pattern: "\d{1,6}"</para>
        /// </summary>
        [XmlAttribute("docNumber")]
        public string DocNumber
        {
            get => DocNumberField;
            set => DocNumberField = value.IsRequired().IsLength(min: 1, max: 6); //.IsPattern(@"\d{1,6}");
        }

        string DocNumberField;

        /// <summary>
        /// Поле номер 3007: Дата документа-основания для осуществления возврата
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("docDate", DataType = "date")]
        public DateTime DocDate { get; set; }
    }
}
