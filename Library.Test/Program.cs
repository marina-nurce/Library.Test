//namespace Library.Test
//class Program
//static void Main(string[] arg)
//Books book1 = new Books("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Fiction");
//Books book2 = new Books("To Kill a Mockingbird", "Harper Lee", 1960, "Fiction");
//Books book3 = new Books("The Catcher in the Rye", "J.D. Salinger", 1951, "Fiction");

using Library.Test;

var allBooks = new List<Library.Test.Books>()
{
    new Library.Test.Books()
    {
        Title = "The Great Gatsby"
    },
    new Library.Test.Books()
    {
        Title = "To Kill a Mockingbird"
    },
    new Library.Test.Books()
    {
        Title = "The Catcher in the Rye"

    }


};


foreach (var student in allBooks)
{
    Console.WriteLine();
}

Console.ReadLine();

        

    





