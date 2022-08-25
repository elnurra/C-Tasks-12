using System;
using System.Collections;
using System.Collections.Generic;

namespace TaskForList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(7);
            list.Add(17);
            list.TheLastIndexOf(7);
            
            
            list.Remove(4);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            




        }

    }
    
    class MyList<T>
    {
        T[] _arr;
        public int Count { get => _arr.Length; }
        public MyList()
        {
            _arr = new T[0];

        }
        public T this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        
        public void Add(T value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public void Clear()
        {
            _arr = new T[0];


        }
        public bool Exist(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(item, _arr[i]))
                {
                    Console.WriteLine("Exist in the index: " + i);
                    return true;
                }
            }
            return false;

        }
       
        public void Reverse() 
        {
            Array.Reverse(_arr);
        
        }
        public void Remove(int item) 
        {
            int count = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                count++;
                if (object.Equals(item, _arr[i]))
                {

                    
                    
                }                
            }

        }
        public void IndexOf(T item)
        {
            
            for (int i = 0; i < _arr.Length; i++)
            {
                
                if (object.Equals(item, _arr[i]))
                {

                    Console.WriteLine("IN the list index of " + _arr[i] + " in:  " + i );

                }
            }

        }
        public void TheLastIndexOf(T item)
        {
            int i;
            int count=0;
            bool condition = false;
            for ( i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(item, _arr[i]))
                {

                    condition = true;
                    count = i;
                }
            }
            if (condition)
            {
                Console.WriteLine(" The last index of Item: " +item +" is "+ count);
            }
            else
            {
                Console.WriteLine("Index is not found");
            }

        }

    }
}

