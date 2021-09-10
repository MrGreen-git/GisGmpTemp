namespace GisGmp.Tests;

public class ImportRefunds
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportRefunds)}";

    [Fact]
    public void ImportRefundsRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new ()
        {
            TestEnable = true,
            //
            TestId = "I_07d5a0d1-5183-4efc-86a8-93b4d341872c",
            TestTimestamp = new (day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "aaa111",
            SenderRole = "70"
        };

        //Act
        var request = gisgmp.CreateImportRefundsRequest(
            importedRefundTypes: new ImportedRefundType[]
            {
                new (
                    id: "I_46488813-8080-49f4-b60f-7f87af897c6a",
                    originatorId: null,
                    refund: new (
                        refundId: "64999010720210000000000000000001",
                        refundDocDate: new (day: 01, month: 07, year: 2021, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        budgetLevel: BudgetLevel.Item1,
                        refundPayee: new (
                            payerIdentifier: "1220000000007712579832",
                            name: "Тестовый получатель",
                            bankAccountNumber: new (
                                bank: new (
                                    bik: "044552272",
                                    correspondentBankAccount: "30101810800000010022"))),
                        refundApplication: new (
                            appNum: "256894",
                            appDate: new (day: 01, month: 07, year: 2021),
                            paymentIdType: "10471020010005233009202000000012",
                            cashType: 1,
                            amount: 50000,
                            purpose: "Штраф за нарушение ПДД.Управление транспортным средством с нечитаемыми государственными регистрационными знаками"),
                        refundBasis: new (
                            docKind: "Заявление",
                            docNumber: "235",
                            docDate: new (day: 01, month: 07, year: 2021)),
                        refundPayer: new (
                            codeUBP: "28519",
                            name: "Тестовый участник",
                            inn: "7706012716",
                            kpp: "770901011"))
                    {
                        Kbk = "18811630020016000140",
                        Oktmo = "45381000"
                    })
            });
               
        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ImportRefundsRequest)}", pathRoot));
    }

    [Fact]
    public void ImportRefundsResponse()
    {
        //Arrange
        //Act
        //Assert              
        Assert.True(false);
    }
}
