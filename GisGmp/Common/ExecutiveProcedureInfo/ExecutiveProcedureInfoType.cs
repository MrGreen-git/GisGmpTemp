using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Информация, необходимая для осуществления исполнительного производства
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ExecutiveProcedureInfoType
    {
        public DeedInfo DeedInfo { get; set; }

        /// <summary>
        /// Данные органа, выдавшего исполнительный документ
        /// </summary>
        public ExecutOrgan ExecutOrgan { get; set; }

        /// <summary>
        /// Сведения о должнике
        /// </summary>
        public Debtor Debtor { get; set; }

        /// <summary>
        /// Поле номер 1101: Номер дела или материалов
        /// </summary>
        [XmlAttribute("idDeloNo")]
        public string IdDeloNo { get; set; }

        /// <summary>
        /// Поле номер 1102: Место рассмотрения дела
        /// </summary>
        [XmlAttribute("deloPlace")]
        public string DeloPlace { get; set; }

        /// <summary>
        /// Поле номер 1103: Дата принятия решения по делу
        /// </summary>
        [XmlAttribute("idDesDate", DataType = "date")]
        public DateTime IdDesDate { get; set; }

        /// <summary>
        /// Поле номер 1104: Дата вступления решения в законную силу
        /// </summary>
        [XmlAttribute("AktDate")]
        public string AktDate { get; set; }

        [XmlAttribute("srokPrIsp", DataType = "integer")]
        public string SrokPrIsp { get; set; }

        /// <summary>
        /// Поле номер 1105: Срок предъявления исполнительного документа к исполнению
        /// </summary>
        [XmlAttribute("srokPrIspType")]
        public SrokPrIspType SrokPrIspType { get; set; }

        /// <summary>
        /// Поле номер 1107: Адрес взыскателя
        /// </summary>
        [XmlAttribute("claimerAdr")]
        public string ClaimerAdr { get; set; }

        /// <summary>
        /// Поле номер 1108: Дата уведомления ФССП России о неуплате штрафа в установленный законом
        /// </summary>
        [XmlAttribute("notifFSSPDate", DataType = "date")]
        public DateTime NotifFSSPDate { get; set; }
    }
}
