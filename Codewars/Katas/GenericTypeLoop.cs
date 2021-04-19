using System.Collections;
using System.Collections.Generic;

namespace Codewars.Katas
{
    public class GenericTypeLoop<T> : IEnumerable<T>
    {
        private int _pointer = 0;
        private List<T> _loop = new List<T>();

        public void Add(T item)
        {
            _loop.Add(item);
        }

        public void Right()
        {
            _pointer -= 1;
            if (_pointer < 0)
            {
                _pointer = _loop.Count - 1;
            }
        }

        public void Left()
        {
            _pointer += 1;
            if (_pointer > _loop.Count - 1)
            {
                _pointer = 0;
            }
        }

        public T PopOut()
        {
            var itemToPop = _loop[_pointer];
            _loop.RemoveAt(_pointer);
            return itemToPop;
        }

        public T ShowFirst()
        {
            return _loop[_pointer];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _loop.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
