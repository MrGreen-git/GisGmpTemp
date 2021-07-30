using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        ClarificationId,

        IncomeId,

        PaymentId,

        RefundId,

        RenouncementID,

        SupplierBillId,
    }
}
