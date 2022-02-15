using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Тип для хранения реквизитов уточняемого платежного документа, которые могут быть уточнены, или новых (уточненных) реквизитов.
    /// </summary>
    [XmlInclude(typeof(setDetailType))]
    [XmlInclude(typeof(originalDetailType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class paymentDetailType
    {
        /// <summary>
        /// Наименование получателя
        /// <para>use: not required</para>
        /// <para>length: 0..500</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("payeeName")]
        public string PayeeName { get; set; }

        /// <summary>
        /// ИНН получателя
        /// <para>use: not required</para>
        /// <para>type: com:INNType</para>
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП получателя
        /// <para>use: not required</para>
        /// <para>type: com:KPPType</para>
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Лицевой счет Получателя
        /// <para>use: not required</para>
        /// <para>type: com:PayeeAccountType</para>
        /// </summary>
        [XmlAttribute("payeeAccount")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// Код по ОКТМО
        /// <para>use: not required</para>
        /// <para>type: com:OKTMOType</para>
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Код по БКБ
        /// <para>use: not required</para>
        /// <para>type: com:KBKType</para>
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Код цели субсидии (субвенции)
        /// <para>use: not required</para>
        /// <para>length: 1..25</para>
        /// <para>pattern: "\w+"</para>
        /// </summary>
        [XmlAttribute("subsidy")]
        public string Subsidy { get; set; }

        /// <summary>
        /// Назначение платежа
        /// <para>use: not required</para>
        /// <para>length: 0..210</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Примечание
        /// <para>use: not required</para>
        /// <para>length: 0..210</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}
