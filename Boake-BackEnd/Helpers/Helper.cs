using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Boake_BackEnd.Helpers
{
    public static class Helper
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool CheckSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 > kb;
        }


        public static void DeleteFile(IWebHostEnvironment env, string folder, string file)
        {
            string path = env.WebRootPath;
            string result = Path.Combine(path, folder, file);

            if (System.IO.File.Exists(result))
            {
                System.IO.File.Delete(result);
            }

        }
        
    }
    public enum Roless
    {
        Admin, Member, SuperAdmin
    }
}
