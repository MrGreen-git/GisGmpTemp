namespace GisGmp.Tests;

public class ImportCharges
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportCharges)}";

    [Fact]
    public void ImportChargesRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_fce0c544-b08d-44bc-83d8-738f10e9d068",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 15, minute: 27, second: 53, millisecond: 045, kind: DateTimeKind.Local),
            SenderIdentifier = "3eacb7",
            SenderRole = "1"
        };

        //Act
        var request = gisgmp.CreateImportChargesRequest(
            importedChargeTypes: new ImportedChargeType[]
            {
                new(
                    id: "I_54a59db2-3845-4915-8770-dd95394aadb4",
                    supplierBillID: "32116102414550976332",
                    billDate: new(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                    totalAmount: 500000,
                    purpose: "Плата за предоставление сведений из Единого государственного реестра недвижимости",
                    kbk: "32111301031016000130",
                    oktmo: "45348000",
                    payee: new(
                        organization: new(
                            name: "ФГБУ «ФКП Росреестра» по г Москва",
                            inn: "7705401341",
                            kpp: "770542151",
                            ogrn: "7723819340452"),
                        orgAccount: new(
                            bank: new(
                                name: "ОПЕРАЦИОННЫЙ ДЕПАРТАМЕНТ БАНКА РОССИИ//Межрегиональное операционное управление Федерального казначейства г. Москва",
                                bik: "024501901",
                                correspondentBankAccount: "40102810045370000002"),
                            accountNumber: "03100643000000019500")),
                    payer: new(
                        payerIdentifier: "1220000000007712579832",
                        payerName: "Тестовый плательщик"),
                    budgetIndex: new(
                        status: "01", //Status.Item01,
                        paytReason: "0", //PaytReason.Item0,
                        taxPeriod: "0",
                        taxDocNumber: "0",
                        taxDocDate: "0"))
                {
                    OriginatorId = "3eb5fa",
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ImportChargesRequest)}", pathRoot));
    }

    [Fact]
    public void ImportChargesResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_36a89db2-3845-4915-1234-dd95394aadb4",
            RqId = "G_fce0c544-b08d-44bc-83d8-738f10e9d068",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 15, minute: 28, second: 43, millisecond: 045, kind: DateTimeKind.Local),
            RecipientIdentifier = "3eacb7",
        };

        //Act
        var response = gisgmp.CreateImportChargesResponse(
            importProtocol: new ImportProtocolType[]
            {
                new(
                    entityID: "I_54a59db2-3845-4915-8770-dd95394aadb4",
                    code: "0",
                    description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)")
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(ImportChargesResponse)}", pathRoot));
    }
}
