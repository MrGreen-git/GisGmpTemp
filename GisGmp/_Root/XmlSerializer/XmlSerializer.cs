using GisGmp.Services.ExportCharges;
using GisGmp.Services.ExportClarification;
using GisGmp.Services.ExportIncomes;
using GisGmp.Services.ExportNotice;
using GisGmp.Services.ExportNoticeNSI;
using GisGmp.Services.ExportNSI;
using GisGmp.Services.ExportPayments;
using GisGmp.Services.ExportQuittances;
using GisGmp.Services.ExportRefunds;
using GisGmp.Services.ForcedAckmowledgement;
using GisGmp.Services.ImportCharges;
using GisGmp.Services.ImportChargestemplate;
using GisGmp.Services.ImportClarification;
using GisGmp.Services.ImportIncomes;
using GisGmp.Services.ImportPaymentCheck;
using GisGmp.Services.ImportPayments;
using GisGmp.Services.ImportRefunds;
using GisGmp.Services.ImportRenouncement;
using GisGmp.Services.ImportСertificates;
using GisGmp.Services.SubscriptionService;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public static XmlDocument SerializerObject<T>(T obj, bool auto = false) where T : class => SerializerObject(obj, auto ? CreateXSN(obj) : null);

        /// <summary/>
        public static XmlDocument SerializerObject<T>(T obj, XmlSerializerNamespaces xsn) where T : class
        {
            XmlDocument xmlDocument = new XmlDocument();

            using (var xs = xmlDocument.CreateNavigator().AppendChild())
            {
                new XmlSerializer(typeof(T)).Serialize(xs, obj, xsn);
            }
            return xmlDocument;
        }


        /// <summary/>
        private static XmlSerializerNamespaces CreateXSN<T>(T obj) where T : class
        {
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();

            void AddPrefix(params string[] prefixs)
            {
                foreach (var prefix in prefixs)
                {
                    switch (prefix)
                    {
                        case "com": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Common/2.4.0"); break;
                        case "sub": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0"); break;
                        case "org": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0"); break;
                        case "chg": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0"); break;
                        case "sc": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0"); break;
                        case "rf":
                        case "rfnd":
                        case "rfd": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0"); break;
                        case "inc": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Income/2.4.0"); break;
                        case "pmnt": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0"); break;
                        case "clrf": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0"); break;
                        case "qt": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0"); break;
                        case "cn": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0"); break;
                        case "pkg": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Package/2.4.0"); break;
                        case "dv": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0"); break;
                        case "nc": xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0"); break;
                        case "xsi": xsn.Add(prefix, "http://www.w3.org/2001/XMLSchema-instance"); break;

                        //SubscriptionServiceRequest / SubscriptionServiceResponse
                        case "ser1": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0"); break;

                        //ChargeCreationRequest / ChargeCreationResponse
                        case "ser2": xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.4.0"); break;

                        //ExportRefundsRequest / ExportRefundsResponse
                        case "ser3": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0"); break;

                        //ExportIncomesRequest / ExportIncomesResponse
                        case "ser4": xsn.Add("n1", "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0"); break;

                        //ExportСlarificationsRequest
                        case "ser5i": xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0"); break;

                        //ExportClarificationResponse
                        case "ser5o": xsn.Add("n1", "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0"); break;

                        //ExportQuittancesRequest / ExportQuittancesResponse
                        case "ser6": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0"); break;

                        //ExportChargesRequest / ExportChargesResponse
                        case "ser7": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0"); break;

                        //ExportNSIRequest / ExportNSIResponse
                        case "ser8": xsn.Add("nsi", "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0"); break;

                        //ExportPaymentsRequest / ExportPaymentsResponse
                        case "ser9": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0"); break;

                        //ExportNoticeNSIRequest / ExportNoticeNSIResponse
                        case "ser10": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0"); break;

                        //ExportNoticeRequest / ExportNoticeResponse
                        case "ser11": xsn.Add("nt", "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0"); break;

                        //ImportRefundsRequest / ImportRefundsResponse
                        case "ser12": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0"); break;

                        //ImportIncomesRequest / ImportIncomesResponse 
                        case "ser13": xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-incomes/2.4.0"); break;

                        //ImportRenouncementRequest / ImportRenouncementResponse 
                        case "ser14": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/import-Renouncement/2.4.0"); break;

                        //ImportClarificationRequest / ImportClarificationResponse
                        case "ser15": xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-clarification/2.4.0"); break;

                        //ImportChargesRequest / ImportChargesResponse
                        case "ser16": xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.4.0"); break;

                        //ImportPaymentsRequest / ImportPaymentsResponse
                        case "ser17": xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.4.0"); break;

                        //ImportCertificateRequest / ImportCertificateResponse
                        case "ser18": xsn.Add("ic", "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0"); break;

                        //ForcedAcknowledgementRequest / ForcedAcknowledgementResponse
                        case "ser19": xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0"); break;

                        //PaymentCheckRequest / PaymentCheckResponse
                        case "ser20": xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0"); break;

                        default:
                            throw new Exception($"XSN нет указанного префикса {prefix}");
                    }
                }
            }

            switch (obj)
            {
                case SubscriptionServiceRequest _: 
                case SubscriptionServiceResponse _: AddPrefix("ser1", "sub", "com"); break;

                case ChargeCreationRequest _:
                case ChargeCreationResponse _: AddPrefix("ser2", "chg", "org", "com"); break;

                case ExportRefundsRequest _: AddPrefix("ser3", "rfd", "org", "com", "sc"); break;
                case ExportRefundsResponse _: AddPrefix("ser3", "rf", "org", "com", "sc"); break;

                case ExportIncomesRequest _: AddPrefix("ser4", "com", "sc"); break;
                case ExportIncomesResponse _: AddPrefix("ser4", "inc", "pmnt", "org", "com"); break;

                case ExportClarificationRequest _: AddPrefix("ser5i", "clrf", "chg", "com", "sc", "xsi"); break;
                case ExportClarificationResponse _: AddPrefix("ser5o", "clrf", "pmnt", "org", "com"); break;

                case ExportQuittancesRequest _:
                case ExportQuittancesResponse _: AddPrefix("ser6", "qt", "pmnt", "org", "com", "sc"); break;

                case ExportChargesRequest _: AddPrefix("ser7", "chg", "org", "com", "sc", "xsi"); break;
                case ExportChargesResponse _: AddPrefix("ser7", "chg", "org", "com", "sc"); break;

                case ExportNSIRequest _:
                case ExportNSIResponse _: AddPrefix("ser8", "cn", "com", "xsi"); break;

                case ExportPaymentsRequest _: 
                case ExportPaymentsResponse _: AddPrefix("ser9", "pmnt", "org", "com", "sc"); break;

                case ExportNoticeNSIRequest _:
                case ExportNoticeNSIResponse _: AddPrefix("ser10", "cn", "com", "xsi"); break;

                case ExportNoticeRequest _: AddPrefix("ser11", "nc", "pmnt", "dv", "org", "com", "xsi"); break;
                case ExportNoticeResponse _: AddPrefix("ser11"); break;

                case ImportRefundsRequest _: AddPrefix("ser12", "rfnd", "pmnt", "chg", "org", "com", "pkg"); break;
                case ImportRefundsResponse _: AddPrefix("ser12", "rfd", "pmnt", "chg", "org", "com", "pkg"); break;

                case ImportIncomesRequest _:
                case ImportIncomesResponse _: AddPrefix("ser13", "inc", "pmnt", "org", "com", "pkg"); break;

                case ImportRenouncementRequest _: AddPrefix("ser14", "org", "com", "pkg", "dv", "xsi"); break;
                case ImportRenouncementResponse _: AddPrefix("ser14", "com", "pkg", "dv", "xsi"); break;

                case ImportClarificationRequest _: AddPrefix("ser15", "clrf", "pmnt", "chg", "rfd", "org", "com", "pkg"); break;
                case ImportClarificationResponse _: AddPrefix("ser15", "pmnt", "inc", "org", "com", "pkg"); break;

                case ImportChargesRequest _: AddPrefix("ser16", "chg", "pmnt", "rfd", "org", "com", "pkg"); break;
                case ImportChargesResponse _: AddPrefix("ser16", "chg", "pmnt", "rfnd", "org", "com", "pkg"); break;

                case ImportPaymentsRequest _:
                case ImportPaymentsResponse _: AddPrefix("ser17", "pmnt", "chg", "rfd", "org", "com", "pkg"); break;

                case ImportCertificateRequest _:
                case ImportCertificateResponse _: AddPrefix("ser18", "com"); break;

                case ForcedAcknowledgementRequest _:
                case ForcedAcknowledgementResponse _: AddPrefix("ser19", "pmnt", "qt", "org", "com", "xsi"); break;

                case PaymentCheckRequest _:
                case PaymentCheckResponse _: AddPrefix("ser20", "org", "com"); break;

                default: break;
            }

            return xsn;
        }

        /// <summary/>
        public static T Deserialize<T>(XmlDocument xmlDocument)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            Stream xmlStream = new MemoryStream();
            xmlDocument.Save(xmlStream);
            xmlStream.Flush();
            xmlStream.Position = 0;
            T result = (T)serializer.Deserialize(xmlStream);
            xmlStream.Close();
            return result;
        }
    }
}




