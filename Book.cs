using System;

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

        public string Title { get; }
        public string SubTitle { get; set; }
        public string FullTitle {
            get {
                if (string.IsNullOrWhiteSpace(SubTitle)) {
                    return Title;
                }
                return $"{Title}:\n            {SubTitle}";
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
}
