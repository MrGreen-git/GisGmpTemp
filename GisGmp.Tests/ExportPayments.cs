using GisGmp.SearchConditions;
using GisGmp.Services.ExportPayments;

namespace GisGmp.Tests;

public class ExportPayments
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportPayments)}";

    [Fact]
    public void ExportPaymentsRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_a108e1f7-e0f0-48d2-8e80-b64a423efe4e",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "3eb646",
            SenderRole = "9",

            PageNumber = 1,
            PageLength = 100
        };

        //Act
        var request = gisgmp.CreateExportPaymentsRequest(
            paymentsKind: ExportPaymentsKind.Payment,
            uin: new SupplierBillIDType[]
            {
                new("32117072411021588933")
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportPaymentsRequest)}", pathRoot));
    }

    [Fact]
    public void ExportPaymentsResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_17f81555-2452-42a3-8c8b-4679c2bdf2b7",
            RqId = "G_a108e1f7-e0f0-48d2-8e80-b64a423efe4e",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eb646",
        };

        //Act
        var response = gisgmp.CreateExportPaymentsResponse(
            hasMore: false,
            paymentInfo: new PaymentInfo[]
            {
                new(
                    changeStatusInfo: new(
                        meaning: "1"),
                    payment: new(
                        paymentId: "10471020010005233001202100000001",
                        paymentDate: new(day: 30, month: 01, year: 2021, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        paymentOrg: new(
                            bank: new(
                                bik: "047252006")),
                        payee: new(
                            organization: new(
                                name: "ФГБУ «ФКП Росреестра» по г Москва",
                                inn: "7705401341",
                                kpp: "770542151"),
                            orgAccount: new(
                                bank: new(
                                    bik: "044525000"),
                                accountNumber: "40101810045250010041")),
                        budgetIndex: new(
                            status: "01",//Status.Item01,
                            paytReason: "0",//PaytReason.Item0,
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0"),
                        purpose: "ФГБУ «ФКП Росреестра» по г Москва (ТЕСТОВЫЕ ДАННЫЕ!)",
                        amount: 500000,
                        transKind: TransKindType.Item01)
                    {
                        SupplierBillID = "32117072411021588933",
                        Kbk = "32111301031016000130",
                        Oktmo = "45348000",
                        Payer = new(
                            payerIdentifier: "1010000000008751379232",
                            payerName: "Тестовый плательщик")
                    })
                { 
                    AcknowledgmentInfo = new(
                        supplierBillID: "32117072411021588933")
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportPaymentsResponse)}", pathRoot));
    }
}
