using GisGmp.Services.ImportPaymentCheck;

namespace GisGmp.Tests;

public class PaymentCheck
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(PaymentCheck)}";

    [Fact]
    public void PaymentCheckRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_13032ed0-4a7a-49ed-ad46-2a7206d3bca7",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "3eb646",
            SenderRole = "9",

            PageNumber = 1,
            PageLength = 100
        };

        //Act
        var request = gisgmp.CreatePaymentCheckRequest(
            template: new()
            { 
                SupplierBillID = "0",
                Kbk = "18811630020016000140",
                Oktmo = "45348000",
                Payee = new(
                    organization: new(
                        name: "УВД по ЦАО ГУ МВД России по г. Москве",
                        inn: "7706012716",
                        kpp: "770901011"),
                    orgAccount: new(
                        accountNumber: "03100643000000019500",
                        bank: new(
                            bik: "024501901",
                            correspondentBankAccount: "40102810045370000002")))
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(PaymentCheckRequest)}", pathRoot));
    }

    [Fact]
    public void PaymentCheckResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_1aa5aaca-d28f-48b1-9b39-b3a5f16d4e5c",
            RqId = "I_13032ed0-4a7a-49ed-ad46-2a7206d3bca7",
            TestTimestamp = new(day: 01, month: 07, year: 2021, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eb646"
        };

        //Act
        var response = gisgmp.CreatePaymentCheckResponse(
            importProtocol: new ImportProtocolType(
                entityID: "I_09bcf2c6-a08a-4ea2-959d-8e198ba689d9",
                code: "0",
                description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)")
            {
                    RequisiteCheckCode = "63F8FC076978E444EDC0BBA8F6EF45EC5527CD7490C567896A3CE4A0F996FB5B2021-07-01T18:06:30+03:00"                
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(PaymentCheckResponse)}", pathRoot));
    }
}
