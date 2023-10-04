



using W4._1_ShapeMaster.Domain.Entities;
using W4._1_ShapeMaster.Infrastructure.Services;

Triangle triangle = new Triangle()
{

    Base = 10,
    Height = 5
};

NotepadService notepadService = new NotepadService();
notepadService.SaveToNotepad(triangle);
