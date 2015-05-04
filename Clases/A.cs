using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Console; esta mal

namespace Clases
{
    public class A
    {
        private string NombreInstancia;

        public A(){
            NombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre)
        {
            NombreInstancia = nombre;
        }

        public void MostrarNombre(){
            
            Console.WriteLine(NombreInstancia);           
        }

        public void M1(){
            Console.WriteLine("El método M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("El método M2 fue invocado");
        }

        public void M3()
        {
            Console.WriteLine("El método M3 fue invocado");
        }
    }

}
