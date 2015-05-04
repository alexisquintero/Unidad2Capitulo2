using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class B : A 
    {
        public void M4()
        {
            Console.WriteLine("Método del hijo Invocado");
        }

        public B():base("Instancia de B")
        {        
        }
    }
}
