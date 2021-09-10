using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Данные организации
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
    public class OrganizationType
    {
        /// <summary/>
        protected OrganizationType() { }

        /// <summary/>
        public OrganizationType(string name, INNType inn, KPPType kpp)
        {
            Name = name;
            Inn = inn;
            Kpp = kpp;
        }

        /// <summary/>
        public OrganizationType(string name, INNType inn, KPPType kpp, OGRNType ogrn = null)
            : this(name, inn, kpp) => Ogrn = ogrn;

        /// <summary/>
        public OrganizationType(OrganizationType organization) => Clone.Field(this, organization);
        
        
        /// <summary>
        /// Поле номер 16: Наименование организации
        /// </summary>
        [XmlAttribute("name")]
        public string Name
        {
            get => NameField;
            set => NameField = Validator.String(value: ref value, name: nameof(Name), required: true, min: 0, max: 160);
        }

        string NameField;


        [XmlIgnore]
        public INNType Inn
        {
            get => InnField;
            set => InnField = Validator.IsNull(value: value, name: nameof(Inn));
        }

        INNType InnField;

        /// <summary>
        /// Поле номер 61: ИНН организации
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("inn")]
        public string WrapperInn { get => Inn; set => Inn = value; }

        /// <summary>
        /// Поле номер 103: КПП организации
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Поле номер 200: ОГРН организации
        /// </summary>
        [XmlAttribute("ogrn")]
        public string Ogrn { get; set; }
    }
}
