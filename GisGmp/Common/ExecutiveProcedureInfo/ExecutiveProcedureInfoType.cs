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
        protected ExecutiveProcedureInfoType() { }

        /// <summary>
        /// Информация, необходимая для осуществления исполнительного производства
        /// </summary>
        /// <param name="deedInfo">Данные исполнительного документа</param>
        /// <param name="executOrgan">Данные органа, выдавшего исполнительный документ</param>
        /// <param name="debtor">Сведения о должнике</param>
        /// <param name="idDeloNo">Поле номер 1101: Номер дела или материалов</param>
        /// <param name="idDesDate">Поле номер 1103: Дата принятия решения по делу</param>
        /// <param name="aktDate">Поле номер 1104: Дата вступления решения в законную силу</param>
        /// <param name="srokPrIsp">Поле номер 1105: Срок предъявления исполнительного документа к исполнению</param>
        /// <param name="srokPrIspType">Поле номер 1106: Тип периода срока предъявления исполнительного документа</param>
        /// <param name="claimerAdr">Поле номер 1107: Адрес взыскателя</param>
        /// <param name="notifFSSPDate">Поле номер 1108: Дата уведомления ФССП России о неуплате штрафа в установленный законом</param>
        public ExecutiveProcedureInfoType(
            DeedInfo deedInfo,
            ExecutOrgan executOrgan,
            Debtor debtor,
            string idDeloNo,
            DateTime idDesDate,
            string aktDate,
            string srokPrIsp,
            SrokPrIspType srokPrIspType,
            string claimerAdr,
            DateTime notifFSSPDate
            ) {
            DeedInfo = deedInfo;
            ExecutOrgan = executOrgan;
            Debtor = debtor;
            IdDeloNo = idDeloNo;
            IdDesDate = idDesDate;
            AktDate = aktDate;
            SrokPrIsp = srokPrIsp;
            SrokPrIspType = srokPrIspType;
            ClaimerAdr = claimerAdr;
            NotifFSSPDate = notifFSSPDate;
        }

        /// <summary>
        /// Данные исполнительного документа
        /// <para>use: required</para>
        /// </summary>
        public DeedInfo DeedInfo { get; set; }

        /// <summary>
        /// Данные органа, выдавшего исполнительный документ
        /// <para>use: required</para>
        /// </summary>
        public ExecutOrgan ExecutOrgan { get; set; }

        /// <summary>
        /// Сведения о должнике
        /// <para>use: required</para>
        /// </summary>
        public Debtor Debtor { get; set; }

        /// <summary>
        /// Поле номер 1101: Номер дела или материалов
        /// <para>use: required</para>
        /// <para>length: 1..25</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("idDeloNo")]
        public string IdDeloNo { get; set; }

        /// <summary>
        /// Поле номер 1102: Место рассмотрения дела
        /// <para>use: not required</para>
        /// <para>length: 1..150</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("deloPlace")]
        public string DeloPlace { get; set; }

        /// <summary>
        /// Поле номер 1103: Дата принятия решения по делу
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("idDesDate", DataType = "date")]
        public DateTime IdDesDate { get; set; }

        /// <summary>
        /// Поле номер 1104: Дата вступления решения в законную силу
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("AktDate")]
        public string AktDate { get; set; }

        /// <summary>
        /// Поле номер 1105: Срок предъявления исполнительного документа к исполнению
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("srokPrIsp", DataType = "integer")]
        public string SrokPrIsp { get; set; }

        /// <summary>
        /// Поле номер 1106: Тип периода срока предъявления исполнительного документа
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("srokPrIspType")]
        public SrokPrIspType SrokPrIspType { get; set; }

        /// <summary>
        /// Поле номер 1107: Адрес взыскателя
        /// <para>use: required</para>
        /// <para>length: 1..200</para>
        /// </summary>
        [XmlAttribute("claimerAdr")]
        public string ClaimerAdr { get; set; }

        /// <summary>
        /// Поле номер 1108: Дата уведомления ФССП России о неуплате штрафа в установленный законом
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("notifFSSPDate", DataType = "date")]
        public DateTime NotifFSSPDate { get; set; }
    }
}
