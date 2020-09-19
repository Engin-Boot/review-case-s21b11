using System.IO;

namespace SenderModule
{
    public class PathExistence
    {
        public static bool CheckFileExistOrNot(string path)
        {
            return File.Exists(path);

        }
    }
}
