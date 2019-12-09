using Chord.IO.Service.Models;
using Chord.IO.Service.Models.Arithmetic;

namespace Chord.IO.Service.Dto
{
    public class NoteDto
    {
        public char Key { get; set; }
        public int Pitch { get; set; }
        public int Alteration { get; set; }

        public Note ToModelObject()
        {
            return new Note(this.Key, this.Pitch, this.Alteration);
        }

        public static NoteDto FromModelObject(Note model)
        {
            return new NoteDto
            {
                Key = model.Key,
                Pitch = model.Pitch,
                Alteration = model.Alteration
            };
        }
    }
}
