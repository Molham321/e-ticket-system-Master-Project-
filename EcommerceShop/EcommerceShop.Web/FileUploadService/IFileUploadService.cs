
namespace EcommerceShop.Business.Implementations.FileUploadService
{
    public interface IFileUploadService
    {
        public Task<string> UploadFileAsync(IFormFile fileName);
    }
}
