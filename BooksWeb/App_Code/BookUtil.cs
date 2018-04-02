using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookUtil
/// </summary>
public class BookUtil
{
    public static List<Book> CreateBookList()
    {
        List<Book> BookList = new List<Book>();

        Book AnimalFarm = new Book()
        {
            ID = 1,
            Title = "Animal Farm",
            ItemUrl = "animal-farm",
            Writer = "George Orwel",
            BooksImageUrl = "/Html/img/animal farm.jpg",
            Category = "Satire",
            CategoryImageUrl = "/Html/img/satire.png",
            CategoryUrl = "category/satire"
        };

        Book Catch22 = new Book()
        {
            ID = 2,
            Title = "Catch-22",
            ItemUrl = "catch-22",
            Writer = "Joseph Heller",
            BooksImageUrl = "/Html/img/catch-22.jpg",
            Category = "Satire",
            CategoryImageUrl = "/Html/img/satire.png",
            CategoryUrl = "category/satire"
        };

        Book SlaughterHouseFive = new Book()
        {
            ID = 3,
            Title = "Slaughter House - Five2",
            ItemUrl = "slaughter-house-five2",
            Writer = "Kurt Vonegurt",
            BooksImageUrl = "/Html/img/slaughter house - five.jpg",
            Category = "Satire",
            CategoryImageUrl = "/Html/img/satire.png",
            CategoryUrl = "category/satire"
        };

        Book GulliversTravels = new Book()
        {
            ID = 4,
            Title = "Gulliver's Travels",
            ItemUrl = "gulivers-travels",
            Writer = "Jonathan Swift",
            BooksImageUrl = "/Html/img/Gulliver's Travels.jpg",
            Category = "Satire",
            CategoryImageUrl = "/Html/img/satire.png",
            CategoryUrl = "category/satire"
        };

        Book Candide = new Book()
        {
            ID = 5,
            Title = "Candide",
            ItemUrl = "candide",
            Writer = "Voltaire",
            BooksImageUrl = "/Html/img/Candide.jpg",
            Category = "Satire",
            CategoryImageUrl = "/Html/img/satire.png",
            CategoryUrl = "category/satire"
        };

        BookList.Add(AnimalFarm);
        BookList.Add(Catch22);
        BookList.Add(SlaughterHouseFive);
        BookList.Add(GulliversTravels);
        BookList.Add(Candide);

        Book Dune = new Book()
        {
            ID = 6,
            Title = "Frank Herbert",
            ItemUrl = "frank-herbert",
            BooksImageUrl = "/Html/img/dune.jpg",
            Category = "Science Fiction",
            CategoryImageUrl = "/Html/img/sci-fi.png",
            CategoryUrl = "category/science-fiction"
        };

        Book Resistance = new Book()
        {
            ID = 7,
            Title = "Resistance",
            ItemUrl = "resistance",
            Writer = "Israel Gutman",
            BooksImageUrl = "/Html/img/resistance.jpg",
            Category = "Science Fiction",
            CategoryImageUrl = "/Html/img/sci-fi.png",
            CategoryUrl = "category/science-fiction"
        };

        Book Frankenstein = new Book()
        {
            ID = 8,
            Title = "Frankenstein",
            ItemUrl = "frankenstein",
            Writer = "Nick Dear",
            BooksImageUrl = "/Html/img/frankenstein.jpg",
            Category = "Science Fiction",
            CategoryImageUrl = "/Html/img/sci-fi.png",
            CategoryUrl = "category/science-fiction"
        };

        Book TheHandmaidsTale = new Book()
        {
            ID = 9,
            Title = "The Handmaid's Tale",
            ItemUrl = "the-handmaids-tale",
            Writer = "Margaret Atwood",
            BooksImageUrl = "/Html/img/the handmaid's tale.jpg",
            Category = "Science Fiction",
            CategoryImageUrl = "/Html/img/sci-fi.png",
            CategoryUrl = "category/science-fiction"
        };

        Book ReadyPlayerOne = new Book()
        {
            ID = 10,
            Title = "Ready Player One",
            ItemUrl = "ready-player-one",
            Writer = "Ernest Cline",
            BooksImageUrl = "/Html/img/ready player one.jpg",
            Category = "Science Fiction",
            CategoryImageUrl = "/Html/img/sci-fi.png",
            CategoryUrl = "category/science-fiction"
        };

        BookList.Add(Dune);
        BookList.Add(Resistance);
        BookList.Add(Frankenstein);
        BookList.Add(TheHandmaidsTale);
        BookList.Add(ReadyPlayerOne);

        Book DramaBook = new Book
        {
            ID = 11,
            Title = "Drama",
            ItemUrl = "drama",
            Writer = "Raina Telgemeier",
            BooksImageUrl = "/Html/img/Drama.jpg",
            Category = "Drama",
            CategoryImageUrl = "/Html/img/drama.png",
            CategoryUrl = "category/drama"
        };

        Book RomeoandJuliet = new Book
        {
            ID = 12,
            Title = "Romeo and Juliet",
            ItemUrl = "romeo-and-juliet",
            Writer = "William Shakespeare",
            BooksImageUrl = "/Html/img/Romeo and Juliet.jpg",
            Category = "Drama",
            CategoryImageUrl = "/Html/img/drama.png",
            CategoryUrl = "category/drama"
        };

        Book Macbeth = new Book
        {
            ID = 13,
            Title = "Macbeth",
            ItemUrl = "macbeth",
            Writer = "William Shakespeare",
            BooksImageUrl = "/Html/img/Macbeth.jpg",
            Category = "Drama",
            CategoryImageUrl = "/Html/img/drama.png",
            CategoryUrl = "category/drama"
        };

        BookList.Add(DramaBook);
        BookList.Add(RomeoandJuliet);
        BookList.Add(Macbeth);

        Book Mockingjay = new Book
        {
            ID = 14,
            Title = "Mockingjay",
            ItemUrl = "mockingjay",
            Writer = "Suzanne Collins",
            BooksImageUrl = "/Html/img/Mockingjay.jpg",
            Category = "Action and Adventure",
            CategoryImageUrl = "/Html/img/action.png",
            CategoryUrl = "category/action-and-adventure"
        };

        Book CatchingFire = new Book
        {
            ID = 15,
            Title = "Catching Fire",
            ItemUrl = "catching-fire",
            Writer = "Suzanne Collins",
            BooksImageUrl = "/Html/img/Catching Fire.jpg",
            Category = "Action and Adventure",
            CategoryImageUrl = "/Html/img/action.png",
            CategoryUrl = "category/action-and-adventure"
        };

        BookList.Add(Mockingjay);
        BookList.Add(CatchingFire);

        return BookList;
    }
}