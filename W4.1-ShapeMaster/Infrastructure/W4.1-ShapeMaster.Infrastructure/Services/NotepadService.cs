using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W4._1_ShapeMaster.Domain.Abstract;
using W4._1_ShapeMaster.Domain.Entities;

namespace W4._1_ShapeMaster.Infrastructure.Services
{
    public class NotepadService
    {
        public void SaveToNotepad(ISaveable saveable)
        {
            string path = DirectoryService.GetNotepadDirectory();

            DirectoryService.DirectoryCreateIfNotExist(path);

            File.AppendAllText($"{path}/{saveable.GetType()}.txt", saveable.GetInfo());
        }

       
    }
}
