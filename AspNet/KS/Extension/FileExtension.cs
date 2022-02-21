using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Extension
{
    public static class FileExtension
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType == "image/jpeg" ||
                file.ContentType == "image/jpg" ||
                file.ContentType == "image/png" ||
                file.ContentType == "image/gif" ||
                file.ContentType == "image/jfif";
        }

        public static bool IsCV(this IFormFile file)
        {
            return file.ContentType == "application/pdf" ||
                file.ContentType == "application/dox" ||
                file.ContentType == "application/docx" ||
                file.ContentType == "application/pptx";
        }

        public async static Task<string> SaveAsync(this IFormFile file, string root, string folder)
        {
            //@"images\uploads
            string path = Path.Combine(root, folder);
            string fileName = Path.Combine(Guid.NewGuid().ToString() + Path.GetFileName(file.FileName));
            string resultPath = Path.Combine(path, fileName);
            using(FileStream fileStream=new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }

        public static void Delete(string root, string folder, string filename)
        {
            string path = Path.Combine(root, folder, filename);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
