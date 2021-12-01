using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        private List<Book> books;

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;
            public  LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

   
            public bool MoveNext()
            {
                if (++this.index < this.books.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                this.index = -1;
            }
            public void Dispose()
            {

            }
            public Book Current => this.books[index];
            object IEnumerator.Current => this.Current;
        }


    }
}
