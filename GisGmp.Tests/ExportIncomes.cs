using GisGmp.Organization;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportIncomes;

namespace GisGmp.Tests;

public class ExportIncomes
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportIncomes)}";

    [Fact]
    public void ExportIncomesRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            TestId = "G_dae1c895-d47d-33ac-28d8-597f11d9e561",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 17, minute: 25, second: 44, millisecond: 585, kind: DateTimeKind.Local),

            SenderIdentifier = "aaa111",
            SenderRole = "70",
            //
            PageLength = 100,
            PageNumber = 1
        };

        //Act
        var request = gisgmp.CreateExportIncomesRequest(
            incomesKind: ExportIncomesKind.Income,
            incomeId: new string[] 
            { 
                new("49999300920200000000000000301067") 
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportIncomesRequest)}", pathRoot));
    }

    [Fact]
    public void ExportIncomesResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_54a39db1-8753-5522-1739-bc94254ccdb4",
            RqId = "G_dae1c895-d47d-33ac-28d8-597f11d9e561",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 17, minute: 25, second: 45, millisecond: 031, kind: DateTimeKind.Local),
            RecipientIdentifier = "aaa111",
        };

        //Act
        var request = gisgmp.CreateExportIncomesResponse(
            hasMore: false,
            incomeInfo: new IncomeInfo[]
            { 
                new(
                    changeStatusInfo: new(
                        meaning: "1"),
                    income: new(
                        paymentOrg: new(
                            bank:new(
                                bik: "047252006")),
                        payee: new(
                            organization: new(
                                name: "УВД по ЦАО ГУ МВД России по г. Москве",
                                inn: "7706012716",
                                kpp: "770901011"),
                            orgAccount: new(
                                accountNumber: "03100643000000019500",
                                bank: new(
                                    bik: "024501901",
                                    correspondentBankAccount: "40102810045370000002"))),
                        budgetIndex: new(
                            status: "01",
                            paytReason: "0",
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0"),
                        purpose: "Штраф",
                        amount: 50000,
                        transKind: TransKindType.Item01,
                        incomeId: "49999300920200000000000000301067",
                        incomeDate: new(day: 30, month: 09, year: 2020, hour: 15, minute: 01, second: 30, millisecond: 511, kind: DateTimeKind.Local),
                        edCode: EdCode.ED101,
                        edNo: "0012345",
                        edDate: new(day: 30, month: 09, year: 2020),
                        isUncertain: "0")
                    {
                        Kbk = "18811630020016000140",
                        Oktmo = "45348000",
                        PaymentId = "10471020010005233009202000000001",
                        SupplierBillID = "18817072416285972102",
                        Payer = new(
                            payerName: "Тестовый плательщик",
                            payerIdentifier: "1010000000003751379232")
                    })                       
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportIncomesResponse)}", pathRoot));
    }
}
