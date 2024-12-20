using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSoftServe
{
    internal class InTheHoomeBooks : IEnumerator
    {
        private readonly List<Book>  _books;
        private int _position=-1;

        public InTheHoomeBooks(List<Book> books) { _books = books; }
        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _books.Count)
                    throw new InvalidOperationException();
                return _books[_position];
            }
        }

        public bool MoveNext()
        {
            while (_position < _books.Count)
            {
                _position++;
                if (_position < _books.Count && _books[_position].InHome && _books[_position].Name.Length>3)
                {
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
