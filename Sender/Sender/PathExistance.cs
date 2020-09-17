using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class PathExistance
    {
        public bool checkFileExistorNot(string path)
        {
            if (File.Exists(path))
                return true;
            else
                return false;
        }
    }
}
