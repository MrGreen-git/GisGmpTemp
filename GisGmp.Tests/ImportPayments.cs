namespace GisGmp.Tests;

public class ImportPayments
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportPayments)}";

    [Fact]
    public void ImportPaymentsRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new ()
        {
            TestEnable = true,
            //
            TestId = "I_13032ed0-4a7a-49ed-ad46-2a7206d3bca7",
            TestTimestamp = new (day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "3eb646",
            SenderRole = "9"
        };

        //Act
        var request = gisgmp.CreateImportPaymentsRequest(
            importedPaymentTypes: new ImportedPaymentType[]
            {
                new (
                    id: "I_09bcf2c6-a08a-4ea2-959d-8e198ba689d9", 
                    payment: new (
                        paymentId: "10471020010005230107202100000001",
                        purpose: "Штраф",
                        amount: 50000,
                        paymentDate: new (day: 01, month: 07, year: 2021, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        transKind: TransKindType.Item01,
                        paymentOrg: new (
                            bank: new (
                                bik: "047252006")),
                        payee: new (
                            orgAccount: new (
                                bank: new (
                                    bik: "024501901", 
                                    correspondentBankAccount: "40102810045370000002"),
                                accountNumber:  "03100643000000019500"),
                            organization: new (
                                name: "УВД по ЦАО ГУ МВД России по г. Москве",
                                inn: "7706012716",
                                kpp: "770901011")))
                    {
                        Kbk = "18811630020016000140",
                        Oktmo = "45348000",
                        SupplierBillID = "18817072416285972102",
                        Payer = new (
                            payerIdentifier: "1010000000003751379232",
                            payerName: "Тестовый плательщик"),
                        BudgetIndex = new (
                            status: "01",
                            paytReason: "0",
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0")
                    })                   
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ImportPaymentsRequest)}", pathRoot));
    }

    [Fact]
    public void ImportPaymentsResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_1aa5aaca-d28f-48b1-9b39-b3a5f16d4e5c",
            RqId = "I_13032ed0-4a7a-49ed-ad46-2a7206d3bca7",
            TestTimestamp = new (day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eb646"
        };

        //Act
        var response = gisgmp.CreateImportPaymentsResponse(
            importProtocol: new ImportProtocolType[]
            {
                new (
                    entityID: "I_09bcf2c6-a08a-4ea2-959d-8e198ba689d9",
                    code: "0",
                    description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)")
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ImportPaymentsResponse)}", pathRoot));
    }
}
