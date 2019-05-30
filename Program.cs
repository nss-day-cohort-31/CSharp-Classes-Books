using System;
using System.Collections.Generic;

namespace Books
{
    class Book
    {
        public Book(string title) {
            Title = title;
            SubTitle = "";
            Author = "";
            ReleaseDate = DateTime.Now;
            Price = double.MaxValue;
        }

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string FullTitle {
            get {
                return Title + " " + SubTitle;
            }
        }

        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }

        private void DisplayDetails() {
            Console.WriteLine($"Full Title: {FullTitle}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Released: {ReleaseDate}");
            Console.WriteLine($"Price: ${Price}");
        }

        public void DisplayDetailsWithHeader(string header) {
            Console.WriteLine(header);
            DisplayDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            3 books
 ``           each book (dictionary)
                Title
                Author
                Release Date
                Price
             */
            Book book0 = new Book("The 0th Book");
            Console.WriteLine(book0.Author.Length);


            Book book1 = new Book("Being Awesome isn't so Great");
            book1.Author = "Juanita Voss";
            book1.SubTitle = "And other depressing things";
            book1.ReleaseDate = new DateTime(2000, 2, 28);
            book1.Price = 21.17;

            Book book2 = new Book("How to Win Friends and Get Their Money")
            {
                SubTitle = "And then get rid of them",
                Author = "Richy Guy",
                ReleaseDate = new DateTime(1980, 10, 10),
                Price = 100.29,
            };


            Book book3 = new Book("Bookie Book")
            {
                Author = "Bookie The Bookie",
                ReleaseDate = new DateTime(2020, 11, 1),
                Price = 34.00,
            };

            book3.Price = 10.00;
            //book3.FullTitle = "something";

            List<Book> shelf = new List<Book>() {
                book1, book2, book3
            };
            List<double> prices = new List<double>() {
                book1.Price, book2.Price, book3.Price
            };

            double sum = 0;
            foreach(Book book in shelf) {
                sum += book.Price;
            }

            foreach(Book book in shelf) {
                book.DisplayDetailsWithHeader("The BOOK Header");
                Console.WriteLine("----------------------");
            }

            Console.WriteLine(sum);


            /*
                        Dictionary<string, string> book1 = new Dictionary<string, string>() {
                            { "Title", "The Big Sleep" },
                            { "Author", "Raymond Chandler" },
                            { "Release Date", "1939" },
                            { "Price", "$5.00 "},
                        };
                        Dictionary<string, string> book2 = new Dictionary<string, string>() {
                            { "Title", "The Lady in the Lake" },
                            { "Author", "Raymond Chandler" },
                            { "Release Date", "1943" },
                            { "Price", "$10.00 "},
                        };
                        Dictionary<string, string> book3 = new Dictionary<string, string>() {
                            { "Title", "C# For Fun and Profit" },
                            { "Author", "Some Body" },
                            { "Release Date", "Last Week" },
                        };

                        List<Dictionary<string, string>> shelf = new List<Dictionary<string, string>>() {
                            book1, book2, book3
                        };

                        foreach(Dictionary<string, string> book in shelf) {
                            Console.WriteLine(
                                book["Price"]
                            );
                        }
                        */
        }
    }
}
