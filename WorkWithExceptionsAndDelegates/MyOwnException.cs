using System;

namespace Task1
{
    internal class MyOwnException : Exception
    {
        public MyOwnException(string message) : base(message) { }
        public MyOwnException() { }
    }
}
