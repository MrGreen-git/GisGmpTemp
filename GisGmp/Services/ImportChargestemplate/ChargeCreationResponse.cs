using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportChargestemplate
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0", IsNullable = false)]
    public class ChargeCreationResponse : ResponseType
    {
        /// <summary/>
        protected ChargeCreationResponse() { }

        /// <summary/>
        public ChargeCreationResponse(ResponseType config, ChargeType charge)
            : base(config) => Charge = charge;

        /// <summary/>
        public ChargeType Charge
        {
            get => ChargeField;
            set => ChargeField = Validator.IsNull(value: value, name: nameof(Charge));
        }

        ChargeType ChargeField;
    }
}
