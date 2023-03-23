
using ShortNote;
using System;

namespace Program
{

    class Prgram
    {
        static void Main(string[] args)
        {
            Notes notes = new Notes();
            while (true)
            {
            
                Console.WriteLine(" 1 for add notes");
                Console.WriteLine(" 2 for delete notes");
                Console.WriteLine(" 3 for edit notes");
                Console.WriteLine(" 4 for display all notes");


                Console.WriteLine(" Enter your choice: ");
                int select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {
                    Console.WriteLine(" Enter your note title");
                    string noteTitle = Console.ReadLine();
                    Console.WriteLine(" Enter your note descriptions");
                    string noteDescriptions = Console.ReadLine();
                    Note note = new Note(notes.NextNoteNumber(), noteTitle, noteDescriptions);
                   
                    notes.addNote(note);
                }
                else if (select == 2)
                {
                    Console.WriteLine(" Enter note id: ");
                    int noteId = Convert.ToInt32(Console.ReadLine());
                    notes.removeNote(noteId);
                }
                else if (select == 3)
                {
                    Console.WriteLine(" Enter note id which want to edit: ");
                    int noteId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" 1 for title \n   2 for descriptions");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        string noteTitle = Console.ReadLine();
                        notes.EditTitle(noteId, noteTitle);
                    }
                    else if (option == 2)
                    {
                        string noteDescription = Console.ReadLine();
                        notes.EditDescription(noteId, noteDescription);
                    }
                    else { Console.WriteLine("  Sorry, Please select write option"); }
                }
                else if (select == 4)
                {
                    notes.ViewNotes();
                }
                else
                {
                    Console.WriteLine("  Sorry, Please select write option");
                }

            }
        }
    }

}