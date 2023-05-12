using EventBookingSystem.Application.Helper.ExcelFile;
using EventBookingSystem.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers
{
    [Route("Admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IReportService _reportService;

        public AdminController(
            IReportService reportService)
        {
            _reportService = reportService;
        }


        [Route("/GetParticipantsByEvent")]
        [HttpGet]
        public IActionResult ParticipantsByEvent(int eventId)
        {
            return Ok(_reportService.ParticipantsByEvent(eventId));
        }


        [Route("/GetEvaluationByEvent")]
        [HttpGet]
        public IActionResult EvaluationByEvent(int eventId)
        {
            return Ok(_reportService.EvaluationByEvent(eventId));
        }


        [Route("/DownloadParticipants")]
        [HttpPost]
        public ActionResult ExcelFileForParticipantsByEvent(int eventId)
        {

            // Generate Excel file
            var excelFile = _reportService.ExcelFileForParticipantsByEvent(eventId);

            // Write Excel file to disk
            var filePath = Path.Combine(Path.GetTempPath(), "Reports.xlsx");
            System.IO.File.WriteAllBytes(filePath, excelFile);

            // Return file as download
            var fileStream = new FileStream(filePath, FileMode.Open);
            var fileStreamResult = new FileStreamResult(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            fileStreamResult.FileDownloadName = "Reports.xlsx";

            return fileStreamResult;
        }


        [Route("/DownloadEvaluations")]
        [HttpPost]
        public ActionResult ExcelFileForEvaluationByEvent(int eventId)
        {
            // Generate Excel file
            var excelFile = _reportService.ExcelFileForEvaluationByEvent(eventId);

            // Write Excel file to disk
            var filePath = Path.Combine(Path.GetTempPath(), "Reports.xlsx");
            System.IO.File.WriteAllBytes(filePath, excelFile);

            // Return file as download
            var fileStream = new FileStream(filePath, FileMode.Open);
            var fileStreamResult = new FileStreamResult(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            fileStreamResult.FileDownloadName = "Reports.xlsx";

            return fileStreamResult;
        }
    }
}
