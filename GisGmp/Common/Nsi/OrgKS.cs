using System;
using System.Xml.Serialization;

namespace GisGmp.Common.NSI
{
    /// <summary>
    /// Реквизиты счета организации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public class OrgKS
    {
        /// <summary/>
        protected OrgKS() { }

        /// <summary/>
        public OrgKS(
            string kSNumber,
            string bankAccountNumber,
            StatKS statKS,
            DateTime dateIn
            ) 
        {  
            KSNumber = kSNumber;
            BankAccountNumber = bankAccountNumber;
            StatKS = statKS;
            DateIn = dateIn;
        }

        /// <summary>
        /// Номер казначейского счета или счета получателя средств в банке получателя |> request
        /// </summary>
        [XmlAttribute]
        public string KSNumber { get; set; }

        /// <summary>
        /// БИК ТОФК |> not required
        /// </summary>
        [XmlAttribute("bik")]
        public string Bik { get; set; }

        /// <summary>
        /// Номер единого казначейского счета |> required
        /// </summary>
        [XmlAttribute]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Статус казначейского счета |> required
        /// </summary>
        [XmlAttribute("statKS")]
        public StatKS StatKS { get; set; }

        /// <summary>
        /// Дата вступления изменений в силу |> required
        /// </summary>
        [XmlAttribute("dateIn", DataType = "date")]
        public DateTime DateIn { get; set; }
    }
}
