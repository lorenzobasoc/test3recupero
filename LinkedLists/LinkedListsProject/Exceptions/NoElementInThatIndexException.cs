using System;

namespace LinkedListsProject.Exceptions
{
    public class NoElementInThatIndexException : Exception
    {
        public new string  Message { get; set; } 
        public NoElementInThatIndexException(string message) {
            Message = message;
        }
    }
}