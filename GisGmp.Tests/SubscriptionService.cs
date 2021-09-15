namespace GisGmp.Tests;

public class SubscriptionService
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(SubscriptionService)}";

    #region SubscriptionService #1
    [Fact]
    public void SubscriptionServiceRequest1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_5e8e6ede-db3a-4fd4-af74-4e76268368b0",
            TestTimestamp = new(day: 30, month: 07, year: 2021, hour: 16, minute: 03, second: 25, millisecond: 932, kind: DateTimeKind.Local),
            SenderIdentifier = "000009",
            SenderRole = "7"
        };

        //Act
        var request = gisgmp.CreateSubscriptionServiceRequest(exportSubscriptions: true);

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(SubscriptionServiceRequest1)}", pathRoot));
    }

    [Fact]
    public void SubscriptionServiceResponse1()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "U_49655ef1-07fe-41f9-9538-c1bcdffb2b95",
            RqId = "G_5e8e6ede-db3a-4fd4-af74-4e76268368b0",
            TestTimestamp = new(day: 30, month: 07, year: 2021, hour: 16, minute: 04, second: 25, millisecond: 932, kind: DateTimeKind.Local),
            RecipientIdentifier = "000009"
        };

        //Act
        var response = gisgmp.CreateSubscriptionServiceResponse(
            subscriptions: new Subscriptions[]
            {
                new (
                    subscriptionCode: "NC0001",
                    subscriptionName: "Уведомления о начислениях по определенным значениям идентификатора плательщика (ТЕСТОВЫЕ ДАННЫЕ!)",
                    subscriptionOperation: "Уведомления о поступлении извещения о начислении (ТЕСТОВЫЕ ДАННЫЕ!)",
                    subscriptionParameter: new SubscriptionParameter[]
                    {
                        new (
                            parameterCode: "payerIdentifier",
                            parameterName: "Идентификатор плательщика",
                            required: true,
                            parameterPattern: @"(1((0[1-9])|(1[0-5])|(2[12456789])|(3[0]))[0-9a-zA-Zа-яА-Я]{19})|(200\d{14}[A-Z0-9]{2}\d{3})|(300\d{14}[A-Z0-9]{2}\d{3}|3[0]{7}\d{9}[A-Z0-9]{2}\d{3})|(4[0]{9}\d{12})")
                    })
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(SubscriptionServiceResponse1)}", pathRoot));
    }
    #endregion

    #region SubscriptionService #2
    [Fact]
    public void SubscriptionServiceRequest2()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "U_7994af15-f7f2-4a10-a055-5aacf6057d4f",
            TestTimestamp = new(day: 30, month: 07, year: 2021, hour: 16, minute: 03, second: 25, millisecond: 932, kind: DateTimeKind.Local),
            SenderIdentifier = "000009",
            SenderRole = "7"
        };

        //Act
        var request = gisgmp.CreateSubscriptionServiceRequest(
            createSubscription: new(
                subscriptionStatus: SubscriptionStatus.Item1,
                itemElementName: ItemChoiceType2.SubscriptionCode,
                item: "NC0001")
            {
                RoutingCode = "45382000",
                SubscriptionParameters = new SubscriptionParametersType[]
                {
                    new (
                        status: Status.Item1,
                        parameterId: "P_e5792842-b9b1-4515-859f-a309afeaa9d7",
                        parameterValue: new ParameterValue[]
                        {
                            new(
                                parameterCode: "payerIdentifier", 
                                value: "1010000000000164921814")
                        })
                },
            });

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(SubscriptionServiceRequest2)}", pathRoot));
    }

    [Fact]
    public void SubscriptionServiceResponse2()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_3df3e555-1dcd-48e1-8483-bb358a128b38",
            RqId = "U_7994af15-f7f2-4a10-a055-5aacf6057d4f",
            TestTimestamp = new(day: 30, month: 07, year: 2021, hour: 16, minute: 04, second: 25, millisecond: 932, kind: DateTimeKind.Local),
            RecipientIdentifier = "000009"
        };

        //Act
        var response = gisgmp.CreateSubscriptionServiceResponse(
            createSubscriptionResult: new CreateSubscriptionResult[]
            {
                new(
                    subscriptionProtocol: new SubscriptionProtocolType[]
                    {
                        new(
                            code: "0",
                            description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)",
                            parameterId: "P_e5792842-b9b1-4515-859f-a309afeaa9d7")
                    })
                {
                    DispatchDate = new(day: 30, month: 07, year: 2021, hour: 16, minute: 03, second: 52, millisecond: 932, kind: DateTimeKind.Local),
                    DispatchDateSpecified = true,
                    SubscriptionCode = "NC0001",
                    SubscriptionIdentifier = "000009NC0001",
                }
            });

        //Assert              
        Assert.True(CheckObjToXml(response, $@"{nameof(SubscriptionServiceResponse2)}", pathRoot));
    }
    #endregion
}
