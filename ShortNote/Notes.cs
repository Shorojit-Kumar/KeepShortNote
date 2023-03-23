using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShortNote
{

    internal class Notes
    {
        public int counter;
        List<Note> notes;
        public Notes() {
          notes = new List<Note>();
            counter = 0;
        }
        public void addNote(Note note) {
          //Console.WriteLine("prev : "+ notes.Count);
          notes.Add(note);
           // Console.WriteLine("Post : " + notes.Count);

        }

        public int NextNoteNumber() {
           counter++;
          return counter;
        }

        private int FindNoteById(int id)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].getNoteId() == id)
                {
                    return i;
                }
            }
            // No note with the specified id was found
            return 0;
        }
        public void EditTitle(int noteId,string title)
        {
            int indexOfNotes=FindNoteById(noteId);
            notes[indexOfNotes].setNoteTitle(title);
        }

        public void EditDescription(int noteId, string description)
        {
            int indexOfNotes = FindNoteById(noteId);
            notes[indexOfNotes].setNoteDescriptions(description);
        }

        public void removeNote(int noteId) {
           
            notes.RemoveAt(FindNoteById(noteId ));
        }
        public void ViewNotes()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
      
             for(int i=0; i < notes.Count; i++)
            {
   
                Console.WriteLine(" " + notes[i].getNoteId()+"  "+ notes[i].getNoteTitle()+" "+notes[i].getNoteDescription());
            }
            Console.WriteLine("---------------------------------------------------------------------------");
        }

    }
}
