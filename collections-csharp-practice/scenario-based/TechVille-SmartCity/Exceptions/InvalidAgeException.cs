using System;

namespace TechVilleSmartCity.Exceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
}
