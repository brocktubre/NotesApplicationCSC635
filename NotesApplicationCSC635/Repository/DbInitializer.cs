using NotesApplicationCSC635.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApplicationCSC635.Repository
{
    public class DbInitializer
    {
        public static void Initialize(NotesContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{Name="Carson", Email="carson@mail.com",  CreatedOn=DateTime.Parse("2005-09-01")},
                new User{Name="Brock", Email="brock@mail.com", CreatedOn=DateTime.Parse("2005-09-01")},
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category{Name=Name.IMP}
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var notes = new Notes[]
            {
                new Notes{
                        User=users[0].ID,
                        Category=categories[0].ID,
                        Note ="This is a note.",
                        Title ="New Note",
                        CreatedOn =DateTime.Parse("2005-09-01"),
                        IsDeleted =false
                }
            };
            foreach (Notes n in notes)
            {
                context.Notes.Add(n);
            }
            context.SaveChanges();
        }
    }
}
