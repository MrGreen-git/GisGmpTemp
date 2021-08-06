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
        /// <summary>
        /// Руководитель (уполномоченное лицо), должность
        /// </summary>
        public string HeadPost { get; set; }

        /// <summary>
        /// Руководитель (уполномоченное лицо), расшифровка подписи
        /// </summary>
        public string HeadName { get; set; }

        /// <summary>
        /// Ответственный исполнитель, должность
        /// </summary>
        public string ExecutorPost { get; set; }

        /// <summary>
        /// ФИО ответственного исполнителя
        /// </summary>
        public string ExecutorName { get; set; }

        /// <summary>
        /// Телефон ответственного исполнителя
        /// </summary>
        public string ExecutorNum { get; set; }

        /// <summary>
        /// Указывается дата подписания распоряжения.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime SignDate { get; set; }

        [XmlIgnore]
        public bool SignDateSpecified { get; set; }

        /// <summary>
        /// ТОФК Руководитель (уполномоченное лицо), должность
        /// </summary>
        public string TOFKheadPost { get; set; }

        /// <summary>
        /// ТОФК Руководитель (уполномоченное лицо), расшифровка подписи
        /// </summary>
        public string TOFKheadName { get; set; }

        /// <summary>
        /// Должность исполнителя ТОФК
        /// </summary>
        public string TOFKexecutorPost { get; set; }

        /// <summary>
        /// Исполнитель ТОФК
        /// </summary>
        public string TOFKexecutorName { get; set; }

        /// <summary>
        /// Телефон исполнителя ТОФК
        /// </summary>
        public string TOFKexecutorNum { get; set; }

        /// <summary>
        /// Дата отметки
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime TOFKsignDate { get; set; }

        [XmlIgnore]
        public bool TOFKsignDateSpecified { get; set; }
    }
}
