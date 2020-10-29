using System;


namespace Listas_Enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaE Enlazada = new ListaE();
            
            Enlazada.InsertarALaCabeza(95);
            Enlazada.InsertarALaCabeza(72);
            Enlazada.InsertarALaCabeza("abc");

            Enlazada.InsertarAlFinal("SSS");

            Enlazada.Mostrar();
            Enlazada.ContarElementos();
            Console.ReadKey();

        }
    }
}
