namespace GisGmp.Tests;

public class ImportIncomes
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportIncomes)}";

    [Fact]
    public void ImportIncomesRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_fce0c522-b08d-44bc-55d8-738f10e9d068",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 16, minute: 03, second: 05, millisecond: 041, kind: DateTimeKind.Local),
            SenderIdentifier = "aaa111",
            SenderRole = "70"
        };

        //Act
        var request = gisgmp.CreateImportIncomesRequest(
            importedIncomeTypes: new ImportedIncomeType[]
            {
                new (
                    id: "I_22ccd2c6-a33a-3ea2-959d-8e198ba673a9",
                    income: new(
                        paymentOrg: new(
                            bank: new(
                                bik: "047252006")),
                        payee: new(
                            orgAccount: new(
                                bank: new(
                                    bik: "024501901",
                                    correspondentBankAccount: "40102810045370000002"),
                                accountNumber: "03100643000000019500"),
                            organization: new(
                                name: "УВД по ЦАО ГУ МВД России по г. Москве",
                                inn: "7706012716",
                                kpp: "770901011")),
                        purpose: "Штраф",
                        amount: 50000,
                        transKind: TransKindType.Item01,
                        incomeId: "49999010720210000000000000301067",
                        incomeDate: new(day: 01, month: 07, year: 2021, hour: 15, minute: 01, second: 30, millisecond: 511, kind: DateTimeKind.Local),
                        edCode: EdCode.ED101,
                        edNo: "0012345",
                        edDate: new(day: 01, month: 07, year: 2021),
                        isUncertain: "0"))
                    {
                        PaymentId = "10471020010005232407201700000001",
                        Oktmo = "45348000",
                        Kbk = "18811630020016000140",
                        SupplierBillID = "18817072416285972102",
                        Payer = new(
                            payerIdentifier: "1010000000003751379232",
                            payerName: "Тестовый плательщик"),
                        BudgetIndex = new(
                            status: "01",
                            paytReason: "0",
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0")
                    }
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ImportIncomesRequest)}", pathRoot));
    }

    [Fact]
    public void ImportIncomesResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_1bb7dbca-d28f-48b1-7b39-b4a5f16d5e5c",
            RqId = "G_fce0c522-b08d-44bc-55d8-738f10e9d068",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 16, minute: 03, second: 25, millisecond: 932, kind: DateTimeKind.Local),
            RecipientIdentifier = "aaa111"
        };

        //Act
        var response = gisgmp.CreateImportIncomesResponse(
            importProtocol: new ImportProtocolType[]
            {
                new (
                    entityID: "I_22ccd2c6-a33a-3ea2-959d-8e198ba673a9",
                    code: "0",
                    description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)")
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ImportIncomesResponse)}", pathRoot));
    }
}