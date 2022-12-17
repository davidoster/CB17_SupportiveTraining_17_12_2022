using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VariousRecapSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DummyClass dummyClass = new DummyClass();
            //Console.WriteLine(dummyClass.Add(1, 2)); // this Add comes from SuperDummy -- 3
            //Console.WriteLine(dummyClass.Add(1, 2)); // this Add comes from DummyClass -- 4
            // when I call Add I want to Add(1,2) but it returns 4(+1)

            //SuperDummyClass superDummyClass = new SuperDummyClass();
            //Console.WriteLine(superDummyClass.Add(1,2));

            //SuperDummyClass superDummyClass1 = new DummyClass(); // in order to get 4 we need to have virtual on
            // SuperDummyClass (Add) and override on DummyClass (Add)
            //Console.WriteLine(superDummyClass1.Add(1,2)); // Result = ? 3
            //Console.WriteLine((superDummyClass1 as DummyClass).Add(1,2)); // calling the method Add of DummyClass
            ABC abc = new ABC();
            abc.Increment = 20; 
            Console.WriteLine(abc.Increment); // 30

            ICollection collection = new ABC();
            IMyCollection collection1 = new MyClassCollection();
            ICollection collection2 = new MyClassCollection();

            MyDerivedClass myDerivedClass = new MyDerivedClass();
            MyAbstractClass myAbstractClass = new MyDerivedClass();
            myAbstractClass.
        }
    }

    internal class DummyClass : SuperDummyClass
    {
        public DummyClass() : base("Hello from Super Dummy! via Dummy!!!!")
        {

        }

        public override int Add(int i, int j) // hides the SuperDummy Add or put new
        {
            return base.Add(i, j) + 1;
        }
    }

    internal class SuperDummyClass
    {
        public SuperDummyClass()
        {
            Console.WriteLine("Hello from Super Dummy!");
        }

        public SuperDummyClass(string s)
        {
            Console.WriteLine(s);
        }

        public virtual int Add(int i, int j)
        {
            return i + j;
        }
    }

    internal class ABC : ICollection
    {
        private int _increment;

        public int Increment
        {
            get
            {
                return _increment + 10;
            }

            set
            {
                //_increment = value + 10;
                _increment = value;
            }
        }

        public int Count => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    interface IMyCollection : ICollection
    {
        int Add(int i, int j);
    }

    internal class MyClassCollection : IMyCollection
    {
        public int Count => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public int Add(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    abstract class MyAbstractClass 
    {
        public MyAbstractClass()
        {
            Console.WriteLine("MyAbsrtactClass");
        }

        public void Hello(string message)
        {
            Console.WriteLine($"Hello {message}");
        }

        public abstract int Add(int i, int j);

        private int Subtract(int i, int j)
        {
            return i - j;
        }

        public virtual int Multiply(int i, int j)
        {
            return i * j;
        }
    
    }

    internal class MyDerivedClass : MyAbstractClass
    {
        public override int Add(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}
