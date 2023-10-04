using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3._1_Freelancer.Abstract;
using W3._1_Freelancer.Constants;

namespace W3._1_Freelancer.Service
{
    public class NotepadService
    {
        public void SaveToNotepad(ICsvConvertible data)
        {
            string path = $"{FileLocation.ProjectFolder}\\Database";

            string type = data.GetType().ToString().Split(".").LastOrDefault();

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string filePath = $"{path}\\{type}s.txt";

            File.AppendAllText(filePath, $"{data.GetValuesCSV()}\n");
        }

        public string GetOnNotepad(string path)
        {
            if (File.Exists(path))
                return File.ReadAllText(path);

            throw new Exception("File Doesn't Exist");
        }
    }
}
