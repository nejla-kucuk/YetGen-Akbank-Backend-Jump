using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W4._1_ShapeMaster.Domain.Abstract;
using W4._1_ShapeMaster.Infrastructure.Services;

namespace W4._1_ShapeMaster.Infrastructure.Services
{
    public class DirectoryService
    {
        public static string GetNotepadDirectory()
        {
            return $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}/Database";
        }

        public static void DirectoryCreateIfNotExist(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }

}
