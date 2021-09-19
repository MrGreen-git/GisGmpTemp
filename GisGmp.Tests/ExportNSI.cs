using GisGmp.Common.NSI;

namespace GisGmp.Tests;

public class ExportNSI
{
    static readonly string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportNSI)}";

    #region ExportNSI #1
    [Fact]
    public void ExportNSIRequest1()
    {
        ////Arrange
        //GisGmpBuilder gisgmp = new()
        //{
        //    TestEnable = true,
        //    //
        //    TestId = "G_cfe0c598-b35d-34bc-28d8-697f21d9e251",
        //    TestTimestamp = new(day: 12, month: 06, year: 2020, hour: 10, minute: 18, second: 43, millisecond: 684, kind: DateTimeKind.Local),
        //    SenderIdentifier = "3637ed",
        //    SenderRole = "7"
        //};

        ////Act
        //var request = gisgmp.CreateExportNSIRequest(
        //    new NSIExportConditions(
        //        payeeData: new(
        //            inn: "7705401341", 
        //            kpp: "770542151"))
        //    );

        ////Assert              
        //Assert.True(CheckObjToXml(request, $@"{nameof(ExportNSIRequest1)}", pathRoot));
        Assert.True(false);
    }

    [Fact]
    public void ExportNSIResponse1()
    {
        ////Arrange
        //GisGmpBuilder gisgmp = new()
        //{
        //    TestEnable = true,
        //    //
        //    TestId = "I_56a25db2-7954-2145-1764-dd85395aadb6",
        //    RqId = "G_cfe0c598-b35d-34bc-28d8-697f21d9e251",
        //    TestTimestamp = new(day: 12, month: 06, year: 2020, hour: 10, minute: 18, second: 44, millisecond: 723, kind: DateTimeKind.Local),
        //    RecipientIdentifier = "3637ed",
        //};

        ////Act
        //var response = gisgmp.CreateExportNSIResponse(
        //    new PayeeNSIInfoType(
        //        name: "ФГБУ «ФКП Росреестра» по г Москва (Тестовые данные!)",
        //        inn: "7705401341",
        //        kpp: "770542151",
        //        orgStatus: "1",
        //        changeDate: new(day: 11, month: 04, year: 2020, hour: 12, minute: 10, second: 21)
        //        )
        //    );

        ////Assert              
        //Assert.True(CheckObjToXml(response, $@"{nameof(ExportNSIResponse1)}", pathRoot));
        Assert.True(false);
    }
    #endregion

    #region ExportNSI #2
    [Fact]
    public void ExportNSIRequest2()
    {
        ////Arrange
        //GisGmpBuilder gisgmp = new()
        //{
        //    TestEnable = true,
        //    //
        //    TestId = "U_7994af15-f7f2-4a10-a055-5aacf6057d4f",
        //    TestTimestamp = new(day: 12, month: 06, year: 2020, hour: 10, minute: 19, second: 43, millisecond: 684, kind: DateTimeKind.Local),
        //    SenderIdentifier = "3637ed",
        //    SenderRole = "7"
        //};

        ////Act
        //var request = gisgmp.CreateExportNSIRequest(
        //    new NSIExportConditions(oktmo: "82720000")
        //    );

        ////Assert              
        //Assert.True(CheckObjToXml(request, $@"{nameof(ExportNSIRequest2)}", pathRoot));
        Assert.True(false);
    }

    [Fact]
    public void ExportNSIResponse2()
    {
        ////Arrange
        //GisGmpBuilder gisgmp = new()
        //{
        //    TestEnable = true,
        //    //
        //    TestId = "G_3df3e555-1dcd-48e1-8483-bb358a128b38",
        //    RqId = "U_7994af15-f7f2-4a10-a055-5aacf6057d4f",
        //    TestTimestamp = new(day: 12, month: 06, year: 2020, hour: 10, minute: 19, second: 45, millisecond: 713, kind: DateTimeKind.Local),
        //    RecipientIdentifier = "3637ed",
        //};

        ////Act
        //var response = gisgmp.CreateExportNSIResponse(
        //    new oktmoNSIInfoType(
        //        name: "город Каспийск (Тестовые данные!)",
        //        oktmo: "82720000",
        //        status: "1",
        //        changeDate: new(day: 04, month: 04, year: 2020, hour: 18, minute: 13, second: 51))
        //    );

        ////Assert              
        //Assert.True(CheckObjToXml(response, $@"{nameof(ExportNSIResponse2)}", pathRoot));
        Assert.True(false);
    }
    #endregion
}
