using GisGmp.Organization;
using GisGmp.SearchConditions;

namespace GisGmp.Tests;

public class ExportRefunds
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportRefunds)}";

    [Fact]
    public void ExportRefundsRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_98c04cf8-d42a-4b60-a288-b62d86f4dba5",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "3eb551",
            SenderRole = "3",

            PageNumber = 1,
            PageLength = 100
        };

        //Act
        var request = gisgmp.CreateExportRefundsRequest(
            kind: ExportRefundsKind.Refund,
            uip: new UIP[]
            {
                new("10471020010005233009202000000012")
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportRefundsRequest)}", pathRoot));
    }

    [Fact]
    public void ExportRefundsResponse()
    {
        // Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_cf6899af-40c2-4e48-8f62-d666a6b4f63c",
            RqId = "G_98c04cf8-d42a-4b60-a288-b62d86f4dba5",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eb551"
        };

        //Act
        var response = gisgmp.CreateExportRefundsResponse(
            hasMore: false,
            refund: new Services.ExportRefunds.Refund[]
            {
                new(
                    changeStatusInfo: new(
                        meaning: "1"),
                    refund: new(
                        refundId: "0410964930092020000000013",
                        refundDocDate: new(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        budgetLevel: BudgetLevel.Item1,
                        refundPayee: new(
                        payerIdentifier: "1220000000005512349832",
                        name: "Тестовый получатель",
                        bankAccountNumber: new(
                            bank: new(
                                bik: "044552272"))),
                        refundApplication: new(
                            appNum: "987894",
                            appDate: new(day: 30, month: 09, year: 2020),
                            paymentId: "10471020010005233009202000000012",
                            cashType: 1,
                            amount: 300000,
                            purpose: "Штраф за нарушение ПДД (ТЕСТОВЫЕ ДАННЫЕ!)"),
                        refundBasis: new(
                            docKind: "Заявление",
                            docNumber: "331254",
                            docDate: new(day: 30, month: 09, year: 2020)),
                        refundPayer: new(
                            codeUBP: "28519",
                            name: "Тестовый участник",
                            inn: "7706012716",
                            kpp: "770901011")))
                {
                    Kbk = "18811630020016000140",
                    Oktmo = "45381000"
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ExportRefundsResponse)}", pathRoot));
    }
}
