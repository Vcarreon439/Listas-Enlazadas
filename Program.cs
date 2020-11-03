using System;


namespace Listas_Enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaE Enlazada = new ListaE();

            Console.WriteLine(Enlazada.Lista_Vacia());


            Enlazada.InsertarALaCabeza(20);
            Enlazada.InsertarALaCabeza(15);
            Enlazada.InsertarALaCabeza(1);
            Enlazada.InsertarALaCabeza(13);
            Enlazada.InsertarALaCabeza(10);

            Enlazada.Mostrar();

            Enlazada.ContarParImpar();

            Console.WriteLine(Enlazada.Lista_Vacia());

            Console.ReadKey();

        }
    }
}
