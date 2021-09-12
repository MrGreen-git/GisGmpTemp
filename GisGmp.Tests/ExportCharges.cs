using GisGmp.Services.ExportCharges;

namespace GisGmp.Tests;

public class ExportCharges
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportCharges)}";

    [Fact]
    public void ExportChargesRequest()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "G_cfe0c895-b33d-33bc-28d8-697f21d9e561",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
            SenderIdentifier = "3eacb7",
            SenderRole = "1",
            //
            PageLength = 100,
            PageNumber = 1
        };

        //Act
        var request = gisgmp.CreateExportChargesRequest(
            chargesKind: ExportChargesKind.CHARGESTATUS,
            supplierBillID: new SupplierBillIDType[] { "32117072411021588933" }
            );

        //Assert              
        Assert.True(CheckObjToXml(request, $@"{nameof(ExportChargesRequest)}", pathRoot));
    }

    [Fact]
    public void ExportChargesResponse()
    {
        //Arrange
        GisGmpBuilder gisgmp = new()
        {
            TestEnable = true,
            //
            TestId = "I_66a12db2-8953-2155-1664-dd95394aadb4",
            RqId = "G_cfe0c895-b33d-33bc-28d8-697f21d9e561",
            TestTimestamp = new(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
            RecipientIdentifier = "3eacb7",
        };

        //Act
        var response = gisgmp.CreateExportChargesResponse(false,
            new ChargeInfo[]
            {
                    new(
                        amountToPay: 0,
                        changeStatusInfo: new(meaning: "1"),
                        supplierBillID: "32117072411021588933",
                        billDate: new(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        totalAmount: 500000,
                        purpose: "Ïëàòà çà ïðåäîñòàâëåíèå ñâåäåíèé èç Åäèíîãî ãîñóäàðñòâåííîãî ðååñòðà íåäâèæèìîñòè (ÒÅÑÒÎÂÛÅ ÄÀÍÍÛÅ!)",
                        kbk: "32111301031016000130",
                        oktmo: "45348000",
                        payee: new Payee()
                        {
                            Name = "ÔÃÁÓ «ÔÊÏ Ðîñðååñòðà» ïî ã Ìîñêâà",
                            Inn = "7705401341",
                            Kpp = "770542151",
                            OrgAccount = new(
                                bank: new(
                                    bik: "024501901",
                                    correspondentBankAccount: "40102810045370000002"),
                                accountNumber: "03100643000000019500"),
                        },
                        payer: new ChargePayer(
                            payerIdentifier: "1010000000008751379232",
                            payerName: "Òåñòîâûé ïëàòåëüùèê"
                            ),
                        budgetIndex: new(
                            status: Status.Item01,
                            paytReason: PaytReason.Item0,
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0"
                            )
                        )
                    {
                        AcknowledgmentStatus = AcknowledgmentStatusType.Item1
                    }
            });

        //Assert    
        XmlDocument xmlDoc = default;
        Assert.Null(Record.Exception(() => xmlDoc = SerializerObject(response, true)));
        Assert.Null(Record.Exception(() => Deserialize<ExportChargesResponse>(xmlDoc)));

        Assert.True(CheckObjToXml(response, $@"{nameof(ExportChargesResponse)}", pathRoot));
    }
}
