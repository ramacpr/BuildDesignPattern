using System;

namespace HelloBuilder.Exceptions
{
    public class InvalidBurgerException : Exception
    {
        public override string Message => "\nOne or more burger ingredients are not set by user. Check the burger data and try again\n" + base.Message;
    }
}
