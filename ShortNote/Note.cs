using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortNote
{
    internal class Note
    {

        private int NoteId;
        private string NoteTitle;
        private string NoteDescription;
        public Note() { } 
        public Note(int NoteId,string NoteTitle,string NoteDescription) {
            this.NoteId = NoteId;
            this.NoteTitle = NoteTitle;
            this.NoteDescription = NoteDescription;

        }
       

        public void setNoteId(int noteId) {  NoteId = noteId; }
        public void setNoteTitle(string noteTitle) {  NoteTitle = noteTitle; }
        public void setNoteDescriptions(string notes) { NoteDescription = notes; }
        public int getNoteId() {  return NoteId; }
        public string getNoteTitle() {  return NoteTitle; } 
        public string getNoteDescription() {  return NoteDescription; }
         

        

    }
}
