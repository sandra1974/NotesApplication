using NotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NotesApp.DAL
{
    public class NoteInitializer : System.Data.Entity.  DropCreateDatabaseIfModelChanges<NoteContext>
    {
        protected override void Seed(NoteContext context)
        {
            var note = new List<Note> {
            new Note {Title = "Reminder", Description = "Visit dentist on Monday at 7pm", CreatedOn = DateTime.Parse("2020-01-05")},
             new Note {Title="Task", Description="Buy present for Xmas", CreatedOn=DateTime.Parse("2019-12-20")},
            new Note {Title="Meeting", Description="Tomorrow at 7 pm meeting with my friend", CreatedOn=DateTime.Parse("2020-01-12")},
                new Note {Title="Call", Description="Call client to check if he is satisfied with our product", CreatedOn=DateTime.Parse("2020-01-15")},
                             };
          
            note.ForEach(s => context.Note.Add(s));
            context.SaveChanges();
        }



    }
}