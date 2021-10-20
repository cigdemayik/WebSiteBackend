using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.WebUI.Extensions
{
    public static class ControllerExtension
    {
        public static int GetActiveCulture(this Controller controller)
        {
            var culture = controller.HttpContext.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>();
            var currentCullture = culture.RequestCulture.Culture;
            return currentCullture.Name == "tr" ? (int)LanguageEnum.Türkçe : (int)LanguageEnum.English;
        }
        public static async Task<string> UploadFileAsync(this Controller controller, IFormFile file, string filePath, string savePath)
        {

            if (!Directory.Exists(filePath))
            {

                Directory.CreateDirectory(filePath);

            }

            var fileName = Path.Combine(filePath, file.FileName);

            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                await file.CopyToAsync(stream);
                stream.Flush();
            }

            return savePath + "\\" + file.FileName;
        }
    }
}
