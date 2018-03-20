using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTrainer.StaticConstants
{
    public static class StaticVariables
    {
        public static string ModelFolderPath
        {
            get
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ModelFolder");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return path;
            }
        }
    }
}
