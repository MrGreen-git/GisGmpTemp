using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Ответ на запрос предоставления необходимой для уплаты информации (начисления)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0", IsNullable = false)]
    public class ExportChargesResponse : ResponseType
    {
        /// <summary />
        protected ExportChargesResponse() { }



        #region XmlAttribute
        /// <summary>
        /// <para>Признак конца выборки:</para>
        /// <para>false - достигнут конец выборки;</para>
        /// <para>true - после последнего предоставленного элемента в выборке имеются другие.</para>
        /// <para>required: true</para>
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }


        /// <summary>
        /// <para>Признак необходимости направления повторного запроса.</para>
        /// <para>Присутствует в ответе, если для предоставления ответа на запроос потребовалось зайдействовать внешнюю систему и ответ от нее не был получен(внешняя система недоступна либо получено сообщение об ошибке)</para>
        /// <para>required: false</para>
        /// </summary>
        [XmlIgnore]
        public bool? NeedReRequest { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValue(false)]
        [XmlAttribute("needReRequest")]
        public bool WrapperNeedReRequest { get => NeedReRequest.Value; set => NeedReRequest = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperNeedReRequestSpecified { get => NeedReRequest.HasValue; }
        #endregion


        [XmlElement("ChargeInfo", typeof(ChargeInfo))]
        [XmlElement("ChargeOffense", typeof(ChargeOffense))]
        public object[] Items { get; set; }

        public ChargeInfo ChargeInfo
        {
            get;
            set;
        }

        public ChargeOffense ChargeOffense
        {
            get;
            set;
        }
            
    }
}
