﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Skyward.Popcorn
{
    /// <summary>
    /// This attribute is used to mark methods, classes, or properties as unable to be passed to any client by Popcorn
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method |AttributeTargets.Property,AllowMultiple = false, Inherited = true )]
    public class InternalOnlyAttribute : Attribute
    {
        private bool throwException;

        public InternalOnlyAttribute(bool throwException = true)
        {
            this.throwException = throwException;
        }

        public bool ThrowException { get { return throwException; } }

    }

}
