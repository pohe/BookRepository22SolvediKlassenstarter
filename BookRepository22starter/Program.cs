// See https://aka.ms/new-console-template for more information
using BookRepository22starter;

BookRepositoryList bookRepositoryList = new BookRepositoryList();
BookRepositoryDictionary bookRepositoryDictionary = new BookRepositoryDictionary();

//Test af AddBook

//Console.WriteLine("Test af AddBook");
Book firstBook = new Book("121212", "C# programming", "John Sharp", 597);
//Console.WriteLine($"Antal bøger inden add af bog {bookRepositoryList.Count}");
//bookRepositoryList.AddBook(firstBook);
Book secondBook = new Book("131313", "Pascal programming", "John Pascal", 444);
Book thirdBook = new Book("141414", "Python programming", "John Python", 888);
//bookRepositoryList.AddBook(secondBook);
//bookRepositoryList.AddBook(thirdBook);
//Console.WriteLine($"Antal bøger efter add af 3 bøger {bookRepositoryList.Count}");

////Test af LookUpBook
//Console.WriteLine("Test af LookUpBook");
//Book foundBook = bookRepositoryList.LookupBook("131313");
//if (foundBook != null)
//{
//    //Udskriv foundBook
//    Console.WriteLine($"Bog fundet {foundBook.ToString()}");
//}
//else
//{
//    //Udskriv bog ikke fundet
//    Console.WriteLine("Bog ikke fundet");
//}

////Test af DeleteBook
//Console.WriteLine("Test af DeleteBook");
//Console.WriteLine($"Antal bøger inden delete af bog {bookRepositoryList.Count}");
//bookRepositoryList.DeleteBook("131313");
//Console.WriteLine($"Antal bøger efter delete af bog {bookRepositoryList.Count}");

////Test af PrintBooks
//Console.WriteLine("Print books");
//bookRepositoryList.PrintBooks();

////Test af upDatedBook
//Book upDatedBook = new Book("141414", "Python 2.0 programming", "John Python v2", 566);
//bookRepositoryList.UpdateBook("141414", upDatedBook);
//Console.WriteLine("Print books after update");
//bookRepositoryList.PrintBooks();

Console.WriteLine("Test of BookRepositoryDictionary");
// Tilføj dine egne test sætninger

bookRepositoryDictionary.AddBook(firstBook);
bookRepositoryDictionary.AddBook(secondBook);
bookRepositoryDictionary.AddBook(thirdBook);
bookRepositoryDictionary.PrintBooks();

Book newBook = new Book("131313", "bla bla bla", "John bla", 45455);
bookRepositoryDictionary.AddBook(newBook);
bookRepositoryDictionary.DeleteBook("141414");

//Console.WriteLine("Books after add(with existing isbn and delete af book with isbn 141414");
//bookRepositoryDictionary.PrintBooks();


//Menu menu = new Menu(bookRepositoryList, bookRepositoryDictionary);
//menu.Run();
Console.ReadLine();
