using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRepository22starter
{
    public class BookRepositoryList
    {
        #region Instance fields
        private List<Book> _books;
        #endregion

        #region Constructor
        public BookRepositoryList()
        {
            _books = new List<Book>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _books.Count; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method adds a single Book object 
        /// to the List of books 
        /// </summary>
        public void AddBook(Book aBook)
        {
            Book foundBook= LookupBook(aBook.ISBN);
            if (foundBook == null)
                _books.Add(aBook);
            // TODO
        }

        /// <summary>
        /// This method returns a Book object (if any) from
        /// the List of books, which has a matching ISBN number.
        /// If no such object exists, the method returns null.
        /// </summary>
        public Book LookupBook(string isbn)
        {
            // TODO
            //int a = 0;
            //while (a < _books.Count)
            //{
            //    if (_books[a].ISBN == isbn)
            //        return _books[a];
            //    a++;
            //}
            foreach (Book item in _books)
            {
                if (isbn == item.ISBN)
                    return item; 
            }
            return null;
        }

        /// <summary>
        /// This method deletes a Book object from the List
        /// of books, specifically the object which has a
        /// matching ISBN number. If no such object exists,
        /// no object is deleted.
        /// </summary>
        public void DeleteBook(string isbn)
        {
            Book item = LookupBook(isbn);
            _books.Remove(item);
            //_books.Remove(LookupBook(isbn));
            // TODO

        }

        /// <summary>
        /// This method printout all the books from the List
        /// </summary>
        public void PrintBooks()
        {
            //TODO
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }
           
        }

        /// <summary>
        /// This method updates a Book object from the List
        /// of books, specifically the object which has a
        /// matching ISBN number.
        /// </summary>
        public void UpdateBook(string isbn, Book bookToUpdate)
        {
            //TODO

            //int upBookIndex=_books.IndexOf(LookupBook(isbn));
            //_books[upBookIndex] = bookToUpdate;
            int d = 0; 
            while (d<_books.Count )
            {
                if (_books[d].ISBN == isbn)
                {
                    _books[d] = bookToUpdate;
                    break;
                }
                d++;
            }
        }

        #endregion
    }
}
