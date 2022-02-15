using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <summary>
    /// Поле номер 2009 Информация о частичном платеже
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    public class PartialPayt
    {
        protected PartialPayt() { }

        /// <summary>
        /// Поле номер 2009 Информация о частичном платеже
        /// </summary>
        /// <param name="transKind">Поле номер 39: Вид операции</param>
        /// <param name="accDoc">Реквизиты платежного документа, по которому осуществляется частичное исполнение</param>
        public PartialPayt(
            TransKindType transKind,
            AccDocType accDoc            
            )
        {            
            TransKind = transKind;
            AccDoc = accDoc;
        }


        /// <summary>
        /// Поле номер 39: Вид операции
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("transKind")]
        public TransKindType TransKind { get; set; }

        /// <summary>
        /// Поле номер 38: Номер частичного платежа
        /// <para>use: not required</para>
        /// <para>length: 0..3</para>
        /// </summary>
        [XmlAttribute("paytNo")]
        public string PaytNo { get; set; }

        /// <summary>
        /// Поле номер 70: Содержание операции
        /// <para>use: not required</para>
        /// <para>length: 0..16</para>
        /// </summary>
        [XmlAttribute("transContent")]
        public string TransContent { get; set; }

        /// <summary>
        /// Поле номер 42: Сумма остатка платежа
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("sumResidualPayt", DataType = "integer")]
        public string SumResidualPayt { get; set; } //TODO integer

        /// <summary>
        /// Реквизиты платежного документа, по которому осуществляется частичное исполнение
        /// <para>use: required</para>
        /// </summary>
        public AccDocType AccDoc { get; set; } 
    }
}
