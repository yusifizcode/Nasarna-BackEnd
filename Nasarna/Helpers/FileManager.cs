using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pustok.Helpers
{
    public static class FileManager
    {

        public static string Save(string root, string folder, IFormFile file)
        {
            var newFileName = Guid.NewGuid().ToString() + (file.FileName.Length > 64 ? file.FileName.Substring(file.FileName.Length - 64, 64) : file.FileName);
            string path = Path.Combine(root, folder, newFileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return newFileName;
        }

        public static bool Delete(string root, string folder, string filename)
        {
            string path = Path.Combine(root, folder, filename);
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            return false;
        }

        public static void DeleteAll(string root, string folder, List<string> fileNames)
        {
            foreach (var filename in fileNames)
            {
                string path = Path.Combine(root, folder, filename);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }
    }
}