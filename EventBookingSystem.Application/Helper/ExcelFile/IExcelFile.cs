namespace EventBookingSystem.Application.Helper.ExcelFile;

public interface IExcelFile
{
    byte[] GenerateExcelFile<TList>(List<TList> list);
}
