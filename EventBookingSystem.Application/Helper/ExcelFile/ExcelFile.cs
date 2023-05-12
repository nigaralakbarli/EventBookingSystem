using OfficeOpenXml;

namespace EventBookingSystem.Application.Helper.ExcelFile;

public class ExcelFile : IExcelFile
{
    public byte[] GenerateExcelFile<TList>(List<TList> list)
    {
        var package = new ExcelPackage();
        var worksheet = package.Workbook.Worksheets.Add("Reports");
        worksheet.Cells.LoadFromCollection(list, true);

        var memoryStream = new MemoryStream();
        package.SaveAs(memoryStream);

        return memoryStream.ToArray();
    }
}
