using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Тип для хранения подписей
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public class SignsClarificationType
    {
        protected SignsClarificationType() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="executorPost">Ответственный исполнитель, должность</param>
        /// <param name="executorName">ФИО ответственного исполнителя</param>
        /// <param name="executorNum">Телефон ответственного исполнителя</param>
        public SignsClarificationType(
            string executorPost,
            string executorName,
            string executorNum
            )
        { 
            ExecutorPost = executorPost;
            ExecutorName = executorName;
            ExecutorNum = executorNum;
        }

        /// <summary>
        /// Руководитель (уполномоченное лицо), должность
        /// <para>use: not required</para>
        /// <para>length: 0..100</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string HeadPost { get; set; }

        /// <summary>
        /// Руководитель (уполномоченное лицо), расшифровка подписи
        /// <para>use: not required</para>
        /// <para>length: 0..50</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string HeadName { get; set; }

        /// <summary>
        /// Ответственный исполнитель, должность
        /// <para>use: required</para>
        /// <para>length: 0..100</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string ExecutorPost { get; set; }

        /// <summary>
        /// ФИО ответственного исполнителя
        /// <para>use: required</para>
        /// <para>length: 0..50</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string ExecutorName { get; set; }

        /// <summary>
        /// Телефон ответственного исполнителя
        /// <para>use: required</para>
        /// <para>length: 0..50</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string ExecutorNum { get; set; }

        /// <summary>
        /// Указывается дата подписания распоряжения.
        /// <para>use: not required</para>
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime SignDate { get; set; }

        [XmlIgnore]
        public bool SignDateSpecified { get; set; }

        /// <summary>
        /// ТОФК Руководитель (уполномоченное лицо), должность
        /// <para>use: not required</para>
        /// <para>length: 0..100</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string TOFKheadPost { get; set; }

        /// <summary>
        /// ТОФК Руководитель (уполномоченное лицо), расшифровка подписи
        /// <para>use: not required</para>
        /// <para>length: 0..50</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string TOFKheadName { get; set; }

        /// <summary>
        /// Должность исполнителя ТОФК
        /// <para>use: not required</para>
        /// <para>length: 0..100</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string TOFKexecutorPost { get; set; }

        /// <summary>
        /// Исполнитель ТОФК
        /// <para>use: not required</para>
        /// <para>length: 0..50</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string TOFKexecutorName { get; set; }

        /// <summary>
        /// Телефон исполнителя ТОФК
        /// <para>use: not required</para>
        /// <para>length: 0..50</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        public string TOFKexecutorNum { get; set; }

        /// <summary>
        /// Дата отметки
        /// <para>use: not required</para>
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime TOFKsignDate { get; set; }

        [XmlIgnore]
        public bool TOFKsignDateSpecified { get; set; }
    }
}
