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
        /// <summary/>
        protected PartialPayt() { }

        public PartialPayt(
            AccDocType accDoc,
            TransKindType transKind
            )
        { 
            AccDoc = accDoc;
            TransKind = transKind;
        }

        /// <summary>
        /// Реквизиты платежного документа, по которому осуществляется частичное исполнение | required
        /// </summary>
        public AccDocType AccDoc { get; set; }

        /// <summary>
        /// Поле номер 39: Вид операции | required
        /// </summary>
        [XmlAttribute("transKind")]
        public TransKindType TransKind { get; set; }

        /// <summary>
        /// Поле номер 38: Номер частичного платежа | not required
        /// </summary>
        [XmlAttribute("paytNo")]
        public string PaytNo { get; set; }

        /// <summary>
        /// Поле номер 70: Содержание операции | not required
        /// </summary>
        [XmlAttribute("transContent")]
        public string TransContent { get; set; }

        /// <summary>
        /// Поле номер 42: Сумма остатка платежа | not required
        /// </summary>
        [XmlAttribute("sumResidualPayt", DataType = "integer")]
        public string SumResidualPayt { get; set; }
    }
}
