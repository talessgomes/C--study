﻿using System;


namespace Personalize.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        } 
    }
}
