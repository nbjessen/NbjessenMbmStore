using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public static class Repository
    {
        // List of products and invoices
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();



        static Repository()
        {
            Book turner = new Book(1,"A Hard Day's Writer: The Story Behind Every Beatles Song", 150.00M, "Steve Turner", 2005, "It Books", "0060844094", "turner.jpg");
            turner.Category = "Book";
            Book rowling = new Book(2,"Harry Potter and the magic of the sticks", 999.00M, "R. Roll", 1337, "Rickrowl", "0063244094", "harrypotter2.jpg");
            rowling.Category = "Book";

            Movie jungleBook = new Movie(3,"Jungle Book", 160.50M, "junglebook.jpg", "person");
            jungleBook.Category = "Movie";
            Movie forrestgump = new Movie(4,"Forrest Gump", 314.23M, "forrest-gump.jpg", "person2");
            forrestgump.Category = "Movie";
            Movie gladiator = new Movie(5,"Gladiator", 421.23M, "gladiator.jpg", "person3");
            gladiator.Category = "Movie";

            MusicCD beatles = new MusicCD(6,"Abbey Road (Remastered)", 128.00M, "EMI", "Beatles", 2009, "abbey.jpg");
            beatles.AddTrack(new Track("Come Together", "Beatles", new TimeSpan(0, 3, 23)));
            beatles.AddTrack(new Track("Something", "Beatles", new TimeSpan(0, 3, 26)));
            beatles.AddTrack(new Track("Maxwell's Silver Hammer", "Beatles", new TimeSpan(0, 3, 27)));
            beatles.AddTrack(new Track("Oh! Darling", "Beatles", new TimeSpan(0, 3, 22)));
            beatles.AddTrack(new Track("Octopu's Garden", "Beatles", new TimeSpan(0, 3, 2)));
            beatles.AddTrack(new Track("I Want You (She's So Heavy", "Beatles", new TimeSpan(0, 3, 25)));
            beatles.AddTrack(new Track("Here Comes The Sun", "Beatles", new TimeSpan(0, 3, 23)));
            beatles.AddTrack(new Track("Become", "Beatles", new TimeSpan(0, 3, 28)));
            beatles.AddTrack(new Track("You Never Give Me Your Money", "Beatles", new TimeSpan(0, 3, 25)));
            beatles.AddTrack(new Track("Sun King", "Beatles", new TimeSpan(0, 3, 32)));
            beatles.AddTrack(new Track("Mean Mr. Mustard", "Beatles", new TimeSpan(0, 3, 24)));
            beatles.AddTrack(new Track("Ploythane Pam", "Beatles", new TimeSpan(0, 3, 52)));
            beatles.AddTrack(new Track("She Came Through The Bedroom Window", "Beatles", new TimeSpan(0, 3, 52)));
            beatles.AddTrack(new Track("Golden Slumbers", "Beatles", new TimeSpan(0, 3, 42)));
            beatles.AddTrack(new Track("Carry That Weight", "Beatles", new TimeSpan(0, 3, 22)));
            beatles.AddTrack(new Track("The End", "Beatles", new TimeSpan(0, 3, 2)));
            beatles.AddTrack(new Track("Her Majesty", "Beatles", new TimeSpan(0, 3, 42)));
            beatles.Category = "MusicCD";

            MusicCD toto = new MusicCD(7,"Best of ToTo", 252.23M, "Hans", "ToTo", 2002, "toto.jpg");
            for (int i = 0; i < 13; i++)
            {
                toto.AddTrack(new Track("Africa " + i, "ToTo", new TimeSpan(0, 3, 24)));
            }
            toto.Category = "MusicCD";
            Products.Add(turner);
            Products.Add(rowling);
            Products.Add(jungleBook);
            Products.Add(forrestgump);
            Products.Add(gladiator);
            Products.Add(beatles);
            Products.Add(toto);


            //Exercise 3

            Customer nicolai = new Customer(1, "Nicolai", "Jessen", "Nødkær Alle 100 st. th.", "8270", "Højbjerg");
            Customer julemanden = new Customer(2, "Santa", "Claus", "Hvidkløvervej 1", "1337", "Nordpolen");

            Invoice nicolaiInvoice = new Invoice(1, DateTime.Now, nicolai);
            Invoice julemandenInvoice = new Invoice(2, DateTime.Now, julemanden);

            Book warren = new Book(8,"What on earth am i here for?", 200.00M, "Rick Warren", 2018, "Zondervan", "0023254253", "rick.jpg");
            warren.Category = "Book";

            Movie avatar = new Movie(9,"Avatar", 500.00M, "avatar.jpg", "James Cameron");
            avatar.Category = "Movie";

            Movie harrypotter = new Movie(10,"Harry Potter", 200.00M, "harrypotter.jpg", "Emil Thorup");
            harrypotter.Category = "Movie";

            Movie martian = new Movie(11,"The Martian", 130.00M, "martian.jpg", "Matt Damon");
            martian.Category = "Movie";

            Movie interstellar = new Movie(12,"Interstellar", 520.00M, "interstella.jpg", "Michael Caine");
            interstellar.Category = "Movie";

            Products.Add(warren);
            Products.Add(interstellar);
            Products.Add(harrypotter);
            Products.Add(avatar);
            Products.Add(martian);

            nicolaiInvoice.AddOrderItem(harrypotter, 2);
            nicolaiInvoice.AddOrderItem(avatar, 1);
            julemandenInvoice.AddOrderItem(warren, 1);
            julemandenInvoice.AddOrderItem(beatles, 1);

            Invoices.Add(nicolaiInvoice);
            Invoices.Add(julemandenInvoice);

            





            //Exercise 4
        }
    }
}
