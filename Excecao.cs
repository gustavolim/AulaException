using System;
using System.Collections.Generic;
using System.Text;

namespace AulaException
{
    class Excecao : Exception
    {
        public Excecao(string message) : base(message)
        {
        }
    }
}
