using InteratorPattern.Menu;

namespace InteratorPattern
{
    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position;
        public DinerMenuIterator(MenuItem[] items)
        {
            this._items = items;
        }
        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}