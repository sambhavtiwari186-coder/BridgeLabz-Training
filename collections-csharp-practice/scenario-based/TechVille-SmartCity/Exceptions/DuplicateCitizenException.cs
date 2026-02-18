using System;

namespace TechVilleSmartCity.Exceptions
{
    public class DuplicateCitizenException : Exception
    {
        public DuplicateCitizenException(string message) : base(message)
        {
        }
    }
}
