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

            // Look for any Users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            SeedUsers(context);
            SeedCategories(context);
            SeedNotes(context);
        }

        private static void SeedNotes(NotesContext context)
        {
            var user = context.Users.Find(1);
            var category = context.Categories.Find(1);

            var notes = new Notes[]
           {
                new Notes{
                        User=user,
                        Category=category,
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

        private static void SeedCategories(NotesContext context)
        {
            var categories = new Category[]
             {
                new Category{Name=Name.IMP}
             };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();
        }

        private static void SeedUsers(NotesContext context)
        {
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
        }
    }
}
