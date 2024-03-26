using Core.Utilities.Result;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelpers
{
    public interface IFileHelper
    {
        IResult Upload(IFormFile file, string root);
        IResult Update(IFormFile file, string filePath, string root);
        IResult Delete(string filePath);
    }
}
