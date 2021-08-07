﻿using GisGmp.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCharges
{
    /// <summary/>
    [Serializable()]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0", IsNullable = false)]
    public class ImportChargesResponse : ImportPackageResponseType
    {
        /// <summary/>
        protected ImportChargesResponse() { }

        /// <summary/>
        public ImportChargesResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol)
        {
        }
    }
}
