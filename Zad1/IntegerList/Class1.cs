using System;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage { get; set; }
        private int brojac = 0;

        public IntegerList()
        {
            _internalStorage = new int[4];
        }
    
        public IntegerList(int initialSize)
        {
            if (initialSize <= 0)
            {
                Console.WriteLine("Unesen broj ne smije biti nula ili negativan.");
                Console.ReadLine();
                return;
            }
            _internalStorage = new int[initialSize];
        }

        public void Add(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Broj ne smije biti 0.");
                Console.ReadLine();
                return;
            }
            if (brojac >= _internalStorage.Length)
            {
                var temp = new int[(_internalStorage.Length)*2];
                Array.Copy(_internalStorage, temp, _internalStorage.Length);
                _internalStorage = temp;
            }

            _internalStorage[brojac] = number;
            brojac++;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index >= _internalStorage.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index >= brojac) return false;
            for (int i = index; i< (_internalStorage.Length)-1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _internalStorage[(_internalStorage.Length) - 1] = 0;
            brojac--;
            return true;
        }

        public int GetElement(int index)
        {
            if (index < _internalStorage.Length && index >= 0)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] == item) return i;
            }
            return -1;

        }

        public void Clear()
        {
            Array.Clear(_internalStorage, 0, _internalStorage.Length);
            brojac = 0;
        }

        public bool Contains(int item)
        {
            if (IndexOf(item) >= 0) return true;
            return false;
        }

        public int Count => brojac;

    }

    public interface IIntegerList
    {
        /// <summary >
        /// Adds an item to the collection .
        /// </ summary >

        void Add(int item);
        /// <summary >
        /// Removes the first occurrence of an item from the collection .
        /// If the item was not found , method does nothing and returns false .
        /// </ summary >
        bool Remove(int item);
        /// <summary >
        /// Removes the item at the given index in the collection .
        /// Throws IndexOutOfRange exception if index out of range .
        /// </ summary >
        bool RemoveAt(int index);
        /// <summary >
        /// Returns the item at the given index in the collection .
        /// Throws IndexOutOfRange exception if index out of range .
        /// </ summary >
        int GetElement(int index);
        /// <summary >
        /// Returns the index of the item in the collection .
        /// If item is not found in the collection , method returns -1.
        /// </ summary >
        int IndexOf(int item);
        /// <summary >
        /// Readonly property . Gets the number of items contained in the collection.
        /// </ summary >
        int Count { get; }
        /// <summary >
        /// Removes all items from the collection .
        /// </ summary >
        void Clear();
        /// <summary >
        /// Determines whether the collection contains a specific value .
        /// </ summary >
        bool Contains(int item);
    }

}