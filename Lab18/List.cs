using System;
using System.Collections.Generic;
using System.Text;

namespace Lab18
{
    public class List
    {
        private int _count = 0;
        private readonly string[] _array;

        public List(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _array.Length;
        }

        public bool Insert(string value)
        {
            if (IsFull())
            {
                return false;
            }

            _array[_count] = value;
            _count++;
            return true;
        }

        //Lab 18 Number 1
        public void RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
            
            _count--;
        }

        //Lab 18 Number 2
        public void PrintReverse(string[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                Array.Reverse(newArray);
            }
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            
        }
       //Lab 18 Number 3
        public bool InsertAt(int index, Object o)
        {

            o = "testing";
            for (int i = index; i < _count; i++)
            {
                Console.WriteLine(i);
            }
            if (index > _count)
            {
                return false;
            }
            else
            {
                _array[_count] = (string)o;
                _count++;
                foreach (var item in _array)
                {
                    Console.WriteLine(item);
                }
                return true;
            }
            ;
        }
    }


}

