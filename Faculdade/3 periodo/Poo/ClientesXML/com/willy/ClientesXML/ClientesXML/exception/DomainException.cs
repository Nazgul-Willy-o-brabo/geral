﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesXML.exception
{
    public class DomainException : ApplicationException
    {
        public DomainException(string msg) : base(msg) { }
    }
}
